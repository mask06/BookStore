namespace BookStore.AspNetCoreMvc.Models
{
    public class AuthorViewModel
    {
        public string Adi { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public string City { get; set; }
        public bool Status { get; set; }
    }
}
