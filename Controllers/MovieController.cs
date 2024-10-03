using Microsoft.AspNetCore.Mvc;
using Week12_CodeFirstBasic.Context;
using Week12_CodeFirstBasic.Entities;

namespace Week12_CodeFirstBasic.Controllers
{
    public class MovieController : Controller
    {
        private readonly PatikaFirstDbContext _context;

        public MovieController(PatikaFirstDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            var newMovie = new MovieEntity()
            {
                title = "Yüzüklerin Efendisi: Yüzük Kardeşliği",
                genre = "Fantastik/Macera",
                releaseYear = 2001
            };

            _context.Movies.Add(newMovie);

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
