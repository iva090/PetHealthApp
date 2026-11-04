using PetHealth.Business.Models;

namespace PetHealth.Business.Interfaces
{
    public interface IAiChatClient
    {
        Task<string> GetReplyAsync(string systemPrompt, IEnumerable<ChatMessageModel> history, string userMessage);
    }
}
