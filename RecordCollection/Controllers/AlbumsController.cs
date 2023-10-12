using Microsoft.AspNetCore.Mvc;
using RecordCollection.DataAccess;
using RecordCollection.Models;

namespace RecordCollection.Controllers
{
    public class AlbumsController : Controller {

        private readonly RecordCollectionContext _context;
        private readonly Serilog.ILogger _logger;

        public AlbumsController(RecordCollectionContext context, Serilog.ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var albums = _context.Albums.ToList();
            return View(albums);
        }

        [Route("/albums/{id:int}")]
        public IActionResult Show(int? id)
        {
            var album = _context.Albums.FirstOrDefault(a => a.Id == id);
            // null validation
            if (album == null)
            {
                _logger.Warning("Id does not belong to any album in the database.");
                return NotFound();
            }
            return View(album);
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Album album)
        {
            // model state validation
            if (!ModelState.IsValid)
            {
                _logger.Warning("Album not created due to invalid model state");
                return View("New", album);
            }
            _context.Albums.Add(album);
            _context.SaveChanges();

            _logger.Information("Album created successfully");

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [Route("/albums/{id:int}")]
        public IActionResult Delete(int? id)
        {
            var album = _context.Albums.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                _logger.Warning("Album not deleted due to Id not matching with an existing album.");
                return NotFound();
            }
            _context.Albums.Remove(album);
            _context.SaveChanges();

            _logger.Information($"Success! {album.Title} was removed from the database.");

            return RedirectToAction(nameof(Index));
        }
    }
}
