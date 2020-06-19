using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmmiServices.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AmmiServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimeController : ControllerBase
    {
        private readonly ILogger<AnimeController> _logger;
        public AnimeController(ILogger<AnimeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            ANN animeNews = new ANN();
            animeNews.Run();

            Apihelper.InitializeClient();
            var anime = AnimeProcessor.LoadAnime(6);
        }
    }
}
