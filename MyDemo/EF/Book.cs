using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDemo.EF
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public int DisplayOrder { get; set; }
        public Double Price { get; set; }
        public string? Author { get; set; }
        public DateTime Created { get; set; }
        public bool Status { get; set; }
    }
}
