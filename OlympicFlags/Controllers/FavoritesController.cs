using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//favorites controller
namespace OlympicFlags.Models
{
    public class FavoritesController : Controller
    {
        public ViewResult Index()
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryListViewModel
            {
                ActiveCategory = session.GetActiveCategory(),
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport(),
                Countries = session.GetMyTeams()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicSession(HttpContext.Session);
            var cookies = new OlympicCookies(HttpContext.Response.Cookies);

            session.RemoveMyTeams();
            cookies.RemoveMyTeamIds();

            TempData["message"] = "Favorite Teams Cleared";

            return RedirectToAction("Index", "Home",
                new
                {
                    ActiveCategory = session.GetActiveCategory(),
                    ActiveGame = session.GetActiveGame(),
                    ActiveSport = session.GetActiveSport()
                });
        }
    }
}