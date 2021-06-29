namespace OlympicFlags.Models
{
    //countryviewmodel model
    public class CountryViewModel
    {
        //attributes
        public Country Country { get; set; }
        public string ActiveCategory { get; set; } = "all";
        public string ActiveGame { get; set; } = "all";
        public string ActiveSport { get; set; } = "all";
    }
}
