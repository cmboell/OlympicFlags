using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OlympicFlags.Models
{
    public class OlympicSession
    {
        private const string TeamsKey = "myteams";
        private const string CountKey = "teamcount";
        private const string CatKey = "cat";
        private const string GameKey = "game";
        private const string SpoKey = "spo";

        private ISession session { get; set; }
        public OlympicSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyTeams(List<Country> countries)
        {
            session.SetObject(TeamsKey, countries);
            session.SetInt32(CountKey, countries.Count);
        }
        public List<Country> GetMyTeams() =>
            session.GetObject<List<Country>>(TeamsKey) ?? new List<Country>();
        public int? GetMyTeamCount() => session.GetInt32(CountKey);

        public void SetActiveCategory(string category) =>
            session.SetString(CatKey, category);
        public string GetActiveCategory() => session.GetString(CatKey);

        public void SetActiveGame(string game) =>
            session.SetString(GameKey, game);
        public string GetActiveGame() => session.GetString(GameKey);

        public void SetActiveSport(string sport) =>
            session.SetString(SpoKey, sport);
        public string GetActiveSport() => session.GetString(SpoKey);

        public void RemoveMyTeams()
        {
            session.Remove(TeamsKey);
            session.Remove(CountKey);
        }
    }
}