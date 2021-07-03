using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlympicFlags.Models;
//homecontroller
namespace OlympicFlags.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string ActiveCategory = "all", 
                                   string ActiveGame = "all",
                                   string ActiveSport = "all")
        {
            var data = new CountryListViewModel
            {
                ActiveCategory = ActiveCategory,
                ActiveGame = ActiveGame,
                ActiveSport = ActiveSport,
                Categories = context.Categories.ToList(),
                Games = context.Games.ToList(),
                Sports = context.Sports.ToList()
            };

            IQueryable<Country> query = context.Countries;
            if (ActiveCategory != "all")
                query = query.Where(
                    t => t.Category.CategoryId.ToLower() == ActiveCategory.ToLower());
            if (ActiveGame != "all")
                query = query.Where(
                    t => t.Game.GameId.ToLower() == ActiveGame.ToLower());
            if (ActiveSport != "all")
                query = query.Where(
                    t => t.Sport.SportId.ToLower() == ActiveSport.ToLower());
            data.Countries = query.ToList();

            return View(data);
        }

        [HttpPost]
        public IActionResult Details(CountryViewModel model)
        {
            Utility.LogTeamClick(model.Country.CountryId.ToString());

            TempData["ActiveCategory"] = model.ActiveCategory;
            TempData["ActiveGame"] = model.ActiveGame;
            TempData["ActiveSport"] = model.ActiveSport;
            return RedirectToAction("Details", new { ID = model.Country.CountryId });
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(t => t.Category)
                    .Include(t => t.Game)
                    .Include(t => t.Sport)
                    .FirstOrDefault(t => t.CountryId.ToString() == id),
                ActiveSport = TempData?["ActiveSport"]?.ToString() ?? "all",
                ActiveGame = TempData?["ActiveGame"]?.ToString() ?? "all",
                ActiveCategory = TempData?["ActiveCategory"]?.ToString() ?? "all"
            };
            return View(model); //displays view 
        }
    }
}