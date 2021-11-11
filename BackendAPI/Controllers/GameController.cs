using BackendAPI.Models;
using BackendAPI.Data;
using BackendAPI.Repositories;
using BackendAPI.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Controllers
{
    [Route("api/game")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly ISettingsRepository _settingsRepository;

        public GameController(ISettingsRepository settingsController)
        {
            _settingsRepository = settingsController;
        }


        [HttpGet]
        public async Task<ActionResult<Game>> GetNewGame()
        {
            Game NewGame = new Game();
            NewGame.Settings = await _settingsRepository.Get();
            // TODO: add min/max sizes for Width and Height?
            NewGame.Board = (new Board(NewGame.Settings.Width, NewGame.Settings.Height)).Get();
            return NewGame;
        }

    }
}
