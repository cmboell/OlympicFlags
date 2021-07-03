using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OlympicFlags.Models
{
    public class OlympicCookies
    {
        private const string TeamsKey = "myteams";
        private const string Delimiter = "-";

        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }
        public OlympicCookies(IRequestCookieCollection cookies)
        {
            requestCookies = cookies;
        }
        public OlympicCookies(IResponseCookies cookies)
        {
            responseCookies = cookies;
        }

        public void SetMyTeamIds(List<Country> myteams)
        {
            List<string> ids = myteams.Select(t => t.CountryId.ToString()).ToList();
            string idsString = String.Join(Delimiter, ids);
            CookieOptions options = new CookieOptions { Expires = DateTime.Now.AddDays(30) };
            RemoveMyTeamIds(); // delete old cookie first
            responseCookies.Append(TeamsKey, idsString, options);
        }

        public string[] GetMyTeamIds()
        {
            string cookie = requestCookies[TeamsKey];
            if (string.IsNullOrEmpty(cookie))
                return new string[] { };   // empty string array
            else
                return cookie.Split(Delimiter);
        }

        public void RemoveMyTeamIds()
        {
            responseCookies.Delete(TeamsKey);
        }
    }
}