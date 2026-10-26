using PetHealth.Domain.Common;
using PetHealth.Domain.Entities;

namespace PetHealth.Data.Entities
{
    public class ChatMessage : BaseEntity
    {
        public string Sender { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        public int PetId { get; set; }
        public Pet? Pet { get; set; } = null;
    }
}
