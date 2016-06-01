using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamiWhammy.Models;

namespace XamiWhammy.Repos
{
    public class TwitterRepoImpl : ITwitterRepo
    {
        private const string CONSUMER_KEY = @"G1ooObIUlod50uILwmxgEdIec";
        private const string CONSUMER_SECRET = @"Fbo8lCQYO0IioJSxGWIDmOhSpf7J7P77Vq1wdo9fCWeVmvxi3I";
        private const string ACCESS_TOKEN = @"4794667815-TfDOSGjmBFzj7byiAnNKmfvKe18XQsLoymfteZQ";
        private const string ACCESS_TOKEN_SECRET = @"kUwymd5fsubLsAmCDNUhqQIg4mG1o1x6AZaE2GvUoklES";
        private const string TWITTER_API_URL = "https://api.twitter.com/1.1/statuses/user_timeline.json";

        public async Task<IEnumerable<Tweet>> LoadTweetsAsync()
        {
            string twitterData = await GetTweetsAsJsonAsync();
            return DeserializeJson(twitterData);
        }

        private async Task<string> GetTweetsAsJsonAsync()
        {
            var test = LoadTweetsAsync();
            string twitterData = string.Empty;

            // TODO: WebApi Request

            return twitterData;
        }

        private IEnumerable<Tweet> DeserializeJson(string twitterData)
        {
            return JsonConvert.DeserializeObject<List<Tweet>>(twitterData);
        }
    }
}