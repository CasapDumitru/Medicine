namespace HealthInsurance.Core.Models
{
    public class Review
    {
        public int Mark { get; set; }
        public int Description { get; set; }

        public User Author { get; set; }
        public int? AuthorId { get; set; }
    }
}
