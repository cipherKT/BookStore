namespace bookStore.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string comment { get; set; }
        public int Rating { get; set; }

    }
}
