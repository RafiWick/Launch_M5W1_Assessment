using System.ComponentModel.DataAnnotations;

namespace RecordCollection.Models
{
    public class Album
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters in length")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Artist is required")]
        [StringLength(100, ErrorMessage = "Artist cannot exceed 100 characters in length")]
        public string Artist { get; set; }
        [Required(ErrorMessage = "Rating is required")]
        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5")]
        public int? Rating { get; set; }
    }
}
