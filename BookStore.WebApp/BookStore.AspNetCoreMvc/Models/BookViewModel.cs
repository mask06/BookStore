namespace BookStore.AspNetCoreMvc.Models
{
    public class BookViewModel
    {
        public string Name { get; set; }
        public string BookType { get; set; }
        public string Author { get; set; }
        public DateOnly PublishedDate { get; set; }
        public string PublishingHouse { get; set; }
        public short PageCount { get; set; }
        public bool Status { get; set; }
    }
}
