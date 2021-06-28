namespace OlympicFlags.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public string GameId { get; set; }
        public Game Game { get; set; }
        public string LogoImage { get; set; }
        public string SportId { get; set; }
        public Sport Sport { get; set; }
    }
}
