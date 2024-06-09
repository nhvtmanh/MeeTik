namespace MusicEvent.Repositories
{
    public interface IMusicEventRepository
    {
        Task<IEnumerable<Models.MusicEvent>> GetAllEventsAsync();
    }
}
