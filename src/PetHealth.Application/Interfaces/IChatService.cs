using PetHealth.Business.Models;

namespace PetHealth.Business.Interfaces
{
    public interface IChatService
    {
        Task<IEnumerable<ChatMessageModel>> GetHistoryAsync(Guid petId, int take);
        Task<ChatMessageModel> AskAsync(Guid petId, string message);
    }
}
