using FactChecker.Api.Application.UseCases.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactChecker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AudioToTextController(IAudioToTextUseCases audioToTextUseCases) : ControllerBase
    {
        private readonly IAudioToTextUseCases _audioToTextUseCases = audioToTextUseCases ?? throw new ArgumentNullException(nameof(audioToTextUseCases));

        [HttpGet("get-log")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult GetLog()
        {
            _audioToTextUseCases.CreateLog();
            return Ok();
        }
    }
}
