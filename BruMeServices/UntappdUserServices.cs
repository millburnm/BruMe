
using BruMeDomainObjects.BruMeObjects;
using BruMeDomainObjects.UntappdObjects;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BruMeServices
{
    public interface IUntappdUserServices
    {
        UntappdRequest untappdRequest { get; set; }
        BruMeUser GetUntappdUserInfo(string username);
    }

    public class UntappdUserServices : IUntappdUserServices
    {
        public UntappdRequest untappdRequest { get; set; }

        public UntappdUserServices()
        {
            untappdRequest = new UntappdRequest();
        }

        public UntappdUserServices(UntappdRequest untappdRequest)
        {
            this.untappdRequest = untappdRequest;
        }

        public BruMeUser GetUntappdUserInfo(string username)
        {
            string response = untappdRequest.GetUntappdUserInfo(username);
            RootObject user = JsonConvert.DeserializeObject<RootObject>(response);
            return ConvertToBruMeUser(user.response.user);
        }

        public string GetUntappdUserBeerList(string userName)
        {
            string response = untappdRequest.GetUntappdUserBeerDistinctBeers(userName);
            return response;
        }

        private BruMeUser ConvertToBruMeUser(User user)
        {
            BruMeUser bruMeUser = new BruMeUser
            {
                UID = user.uid,
                Id = user.id,
                Location = user.location,
                UntappdURL = user.untappd_url,
                UserName = user.user_name,
                Stats = new BruMeUser.Statistics {
                    TotalBadges = user.stats.total_badges,
                    TotalBeers = user.stats.total_beers,
                    TotalCheckins = user.stats.total_checkins,
                    TotalFollowings = user.stats.total_followings,
                    TotalPhotos = user.stats.total_photos
                },
                RecentBrews = new List<BruMeUser.Beer>()
            };

            foreach(Item item in user.recent_brews.items)
            {
                bruMeUser.RecentBrews.Add(new BruMeUser.Beer
                {
                    ABV = item.beer.beer_abv,
                    BreweryCity = item.brewery.location.brewery_city,
                    BreweryName = item.brewery.brewery_name,
                    BreweryState = item.brewery.location.brewery_state,
                    CountryName = item.brewery.country_name,
                    Description = item.beer.beer_description,
                    Name = item.beer.beer_name,
                    Style = item.beer.beer_style,
                    UserRating = item.beer.auth_rating
                });
            }

            return bruMeUser;
        }

    }
}
