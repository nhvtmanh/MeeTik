using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicEvent.Repositories;

namespace MusicEvent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicEventController : ControllerBase
    {
        private readonly IMusicEventRepository _musicEventRepository;

        public MusicEventController(IMusicEventRepository musicEventRepository)
        {
            _musicEventRepository = musicEventRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Models.MusicEvent>> GetAllEvents()
        {
            return await _musicEventRepository.GetAllEventsAsync();
        }
    }
}
