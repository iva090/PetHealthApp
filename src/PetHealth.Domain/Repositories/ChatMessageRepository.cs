using Microsoft.EntityFrameworkCore;
using PetHealth.Data.Data;
using PetHealth.Data.Entities;
using PetHealth.Data.Interfaces;

namespace PetHealth.Data.Repositories
{
    public class ChatMessageRepository : Repository<ChatMessage>, IChatMessageRepository
    {
        public ChatMessageRepository(PetAppContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ChatMessage>> GetHistoryAsync(Guid petId, int take)
        {
            var latest = await _context.Set<ChatMessage>().Where(c => c.PetId == petId).OrderByDescending(c => c.SentAt).Take(take).ToListAsync();

            latest.Reverse();
            return latest;
        }
    }
}
