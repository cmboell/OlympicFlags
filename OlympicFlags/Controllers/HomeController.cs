using System;
using System.Collections.Generic;
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

        public IActionResult Index(CountryListViewModel model)
        {
            model.Categories = context.Categories.ToList();
            model.Games = context.Games.ToList();
            model.Sports = context.Sports.ToList();
            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveCategory(model.ActiveCategory);
            session.SetActiveGame(model.ActiveGame);
            session.SetActiveSport(model.ActiveSport);
            // if no count value in session, use data in cookie to restore fave countries/teams in session 
            int? count = session.GetMyTeamCount();
            if (count == null)
            {
                var cookies = new OlympicCookies(HttpContext.Request.Cookies);
                string[] ids = cookies.GetMyTeamIds();

                List<Country> myteams = new List<Country>();
                if (ids.Length > 0)
                    myteams = context.Countries.Include(t => t.Category)
                        .Include(t => t.Game)
                        .Include(t => t.Sport)
                        .Where(t => ids.Contains(t.CountryId.ToString())).ToList();
                session.SetMyTeams(myteams);
            }

            IQueryable<Country> query = context.Countries;
            if (model.ActiveCategory != "all")
                query = query.Where(
                    t => t.Category.CategoryId.ToLower() == model.ActiveCategory.ToLower());
            if (model.ActiveGame != "all")
                query = query.Where(
                    t => t.Game.GameId.ToLower() == model.ActiveGame.ToLower());
            if (model.ActiveSport != "all")
                query = query.Where(
                    t => t.Sport.SportId.ToLower() == model.ActiveSport.ToLower());
            model.Countries = query.ToList();

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(t => t.Category)
                    .Include(t => t.Game)
                    .Include(t => t.Sport)
                    .FirstOrDefault(t => t.CountryId.ToString() == id),
                ActiveSport = session.GetActiveSport(),
                ActiveGame = session.GetActiveGame(),
                ActiveCategory = session.GetActiveCategory()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel model)
        {
            model.Country = context.Countries
                .Include(t => t.Category)
                .Include(t => t.Game)
                .Include(t => t.Sport)
                .Where(t => t.CountryId == model.Country.CountryId)
                .FirstOrDefault();

            var session = new OlympicSession(HttpContext.Session);
            var countries = session.GetMyTeams();
            countries.Add(model.Country);
            session.SetMyTeams(countries);

            var cookies = new OlympicCookies(HttpContext.Response.Cookies);
            cookies.SetMyTeamIds(countries);

            TempData["message"] = $"{model.Country.Name} added to your favorites";

            return RedirectToAction("Index",
                new
                {
                    ActiveSport = session.GetActiveSport(),
                    ActiveGame = session.GetActiveGame(),
                    ActiveCategory = session.GetActiveCategory()
                });
        }
    }
}