using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Yepp.App.Services;
using Yepp.App.Services.Models;
using Yepp.App.WebServices.Models.Requests;

namespace Yepp.App.WebServices.Controllers
{
    /// <summary>
    /// The Game Info Endpoints
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GameInfoController : ControllerBase
    {
        private readonly IGameInfoService _gameInfoService;
        private readonly IHttpClientFactory _mandrillClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameInfoController"/> class.
        /// </summary>
        /// <param name="gameInfoService">The game information service.</param>
        /// <param name="mandrillClient">The mandrill client.</param>
        public GameInfoController(
             IGameInfoService gameInfoService,
             IHttpClientFactory mandrillClient)
        {
            _gameInfoService = gameInfoService;
            _mandrillClient = mandrillClient;
        }

        /// <summary>
        /// Adds the game information.
        /// </summary>
        /// <param name="gameInfoAddOptions">The game information add options.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddGameInfo(GameInfoAddOptions gameInfoAddOptions)
        {
            if (gameInfoAddOptions.GameScore.Value <3)
            {
                return
                    new ObjectResult("bunu başarabilmeniz imkansız :) iptal edildi.") { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status404NotFound };
            }

            gameInfoAddOptions.GameScore = Convert.ToDecimal(gameInfoAddOptions.GameScore);
            var _add = await _gameInfoService.AddAsync(gameInfoAddOptions);
            var allList = await _gameInfoService.ListAsync();
            var orderByList = allList
                .OrderBy(x=> x.GameScore)
                .ToList();
            var userMinScore = allList
                .Where(x => x.Email == _add.Email)
                .Min(x=> (decimal)x.GameScore.Value);
            var userMinScoreModel = orderByList
                .Where(x => x.Email == _add.Email && (decimal)x.GameScore.Value==userMinScore)
                .FirstOrDefault();
            int order = 0;
            foreach (var item in orderByList) { order++;  if (item == userMinScoreModel) { break; } }

            var data = new GameInfoEmailInformationRequest();
            data.Email = _add.Email;
            data.Language = _add.Language;
            data.Name = _add.Name;
            data.Order = order.ToString();

            var request = new HttpRequestMessage(HttpMethod.Post, "api/YeppEmailService/GameEmailInformation");
            string json = JsonSerializer.Serialize(data);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            var httpClient = _mandrillClient.CreateClient("yepp-mandrill-api");
            var response = await httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var responseString = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return
                new ObjectResult(order) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK };
        }
    }
}
