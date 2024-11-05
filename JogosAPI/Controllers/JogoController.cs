using JogosAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace JogosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : Controller
    {
        private List<Jogo> _jogos;

        public JogoController()
        {
            _jogos = new List<Jogo>()
            {
                new Jogo("Hollow Knight", new DateTime(2017, 2, 24), "Metroidvania"),
                new Jogo("Celeste", new DateTime(2018, 1, 5), "Plataforma"),
                new Jogo("The Witcher 3", new DateTime(2015, 5, 18), "RPG"),
                new Jogo("GTA V", new DateTime(2013, 9, 17), "Aventura"),
            };
        }

        [HttpGet]
        public IActionResult Obter()
        {
            return Ok(_jogos);
        }
    }
}
