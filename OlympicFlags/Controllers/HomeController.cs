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
            var data = new CountryListViewModel
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
            if (ActiveCategory != "all")
                query = query.Where(
                    t => t.Category.CategoryId.ToLower() == ActiveCategory.ToLower());
            if (ActiveGame != "all")
                query = query.Where(
                    t => t.Sport.SportId.ToLower() == model.ActiveSport.ToLower());
            model.Countries = query.ToList();

            return View(model);
        }

        [HttpGet]
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
            return View(model); //displays view 
        }
    }
}