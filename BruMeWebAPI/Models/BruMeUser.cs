using System.Collections.Generic;

namespace BruMeWebAPI.Models
{
    public class BruMeUser
    {
        public int UID { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Location { get; set; }
        public string UntappdURL { get; set; }
        public Statistics Stats { get; set; }
        public List<Beer> RecentBrews { get; set; }
        public class Statistics
        {
            public int TotalBadges { get; set; }
            public int TotalCheckins { get; set; }
            public int TotalBeers { get; set; }
            public int TotalFollowings { get; set; }
            public int TotalPhotos { get; set; }
        }
        public class Beer
        {
            public string Name { get; set; }
            public double ABV { get; set; }
            public string Description { get; set; }
            public string Style { get; set; }
            public double UserRating { get; set; }
            public string BreweryName { get; set; }
            public string CountryName { get; set; }
            public string BreweryCity { get; set; }
            public string BreweryState { get; set; }
        }
    }
}
