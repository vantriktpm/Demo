namespace MyDemo.Models
{
    public class BookViewModel
    {
        public string? Title { get; set; }
        public int DisplayOrder { get; set; }
        public Double Price { get; set; }
        public string? Author { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public bool Status { get; set; }
    }
}
