namespace bookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public string ISBN { get; set; }
        public decimal Price{ get; set; }
        public string Genre { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
