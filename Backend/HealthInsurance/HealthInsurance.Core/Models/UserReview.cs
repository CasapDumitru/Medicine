namespace HealthInsurance.Core.Models
{
    public class UserReview : Review
    {
        public User Recipient { get; set; }
        public int RecipientId { get; set; }
    }
}
