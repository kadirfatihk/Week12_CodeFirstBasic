using Microsoft.AspNetCore.Mvc;
using Week12_CodeFirstBasic.Context;
using Week12_CodeFirstBasic.Entities;

namespace Week12_CodeFirstBasic.Controllers
{
    public class GameController : Controller
    {
        private readonly PatikaFirstDbContext _context;

        public GameController(PatikaFirstDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            var newGame = new GameEntity()
            {
                name="Football Manager 2024",
                platform="Epic Games",
                rating=10
            };

            _context.Games.Add(newGame);

            _context.SaveChanges();

            return Ok();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
