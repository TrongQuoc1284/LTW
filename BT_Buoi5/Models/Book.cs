using System.ComponentModel.DataAnnotations.Schema;

namespace BT_Buoi5.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ImageUrl { get; set; }

        public int TopicId { get; set; }

        [ForeignKey("TopicId")]
        public Topic Topic { get; set; }
    }
} 