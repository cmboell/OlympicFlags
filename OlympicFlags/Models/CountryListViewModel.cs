using System.Collections.Generic;

namespace OlympicFlags.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public List<Country> Countries { get; set; }

        // use full properties for Conferences and Divisions 
        // so can add 'All' item at beginning
        private List<Category> categories;
        public List<Category> Categories {
            get => categories; 
            set {
                categories = value;
                categories.Insert(0, 
                    new Category { CategoryId = "all", Name = "All" });
            }
        }

        private List<Game> games;
        public List<Game> Games {
            get => games; 
            set {
                games = value;
                games.Insert(0,
                    new Game { GameId = "all", Name = "All" });
            }
        }

        // methods to help view determine active link
        public string CheckActiveCategory(string c) => 
            c.ToLower() == ActiveCategory.ToLower() ? "active" : "";
          
        public string CheckActiveGame(string d) => 
            d.ToLower() == ActiveGame.ToLower() ? "active" : "";
    }
}