using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecordCollection.DataAccess;

namespace RecordCollection.Controllers
{
    [Route("api/albums")]
    [ApiController]
    public class AlbumsAPIController : ControllerBase
    {
        private readonly RecordCollectionContext _context;
        private readonly Serilog.ILogger _logger;

        public AlbumsAPIController(RecordCollectionContext context, Serilog.ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult GetAll()
        {
            var albums = _context.Albums.ToList();
            return new JsonResult(albums);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int? id)
        {
            if (id == null)
            {
                _logger.Warning("Invalid Id sent in, Id must be an integer");
                return BadRequest();
            }
            var album = _context.Albums.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                _logger.Warning("Id does not belong to any album in the database.");
                return NotFound();
            }
            return new JsonResult(album);
        }

        [HttpDelete("{id}")]
        public void DeleteOne(int id)
        {
            if (id == null)
            {
                _logger.Warning("Invalid Id sent in, Id must be an integer");
                return;
            }
            var album = _context.Albums.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                _logger.Warning("Id does not belong to any album in the database.");
                return;
            }
            _context.Albums.Remove(album);
            _context.SaveChanges();
            _logger.Information($"Success! {album.Title} was removed from the database.(api)");
        }
    }
}
