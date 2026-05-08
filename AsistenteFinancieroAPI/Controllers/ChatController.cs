using AsistenteFinancieroAPI.Models;
using AsistenteFinancieroAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AsistenteFinancieroAPI.Controllers
{
    [ApiController]
    [Route("api/chat")]
    public class ChatController : ControllerBase
    {
        private readonly OpenAIService _openAIService;

        public ChatController(OpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        [HttpPost]
        public async Task<IActionResult> Chat(ChatRequest request)
        {
            var response = await _openAIService.GetCompletion(request.Message);

            return Ok(response);
        }
    }
}