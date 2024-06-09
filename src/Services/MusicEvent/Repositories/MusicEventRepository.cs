using Microsoft.EntityFrameworkCore;
using MusicEvent.Data;

namespace MusicEvent.Repositories
{
    public class MusicEventRepository : IMusicEventRepository
    {
        private readonly MusicEventDbContext _dbContext;

        public MusicEventRepository(MusicEventDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Models.MusicEvent>> GetAllEventsAsync()
        {
            return await _dbContext.MusicEvents.ToListAsync();
        }
    }
}
