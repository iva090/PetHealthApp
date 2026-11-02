using Data.Interfaces;
using PetHealth.Data.Entities;

namespace PetHealth.Data.Interfaces
{
    public interface IChatMessageRepository : IRepository<ChatMessage>
    {
        Task<IReadOnlyList<ChatMessage>> GetHistoryAsync(Guid petId, int take);
    }
}
