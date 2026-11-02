namespace PetHealth.Business.Models
{
    public class ChatMessageModel
    {
        public Guid Id { get; set; }
        public Guid PetId { get; set; }
        public string Sender { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime SentAt { get; set; }
    }
}
