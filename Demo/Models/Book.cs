using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Author { get; set; }
        public DateTime Created { get; set; }
        public bool Status { get; set; }
        public int DisplayOrder { get; set; }

    }
}
