using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamiWhammy.Models;

namespace XamiWhammy.Repos
{
    public class TwitterRepoImpl : ITwitterRepo
    {
        private const string CONSUMER_KEY = @"G1ooObIUlod50uILwmxgEdIec";
        private const string CONSUMER_SECRET = @"Fbo8lCQYO0IioJSxGWIDmOhSpf7J7P77Vq1wdo9fCWeVmvxi3I";
        private const string TWITTER_API_TIMELINE = "https://api.twitter.com/1.1/statuses/user_timeline.json";
        private const string TWITTER_API_TOKEN = "https://api.twitter.com/oauth2/token";
        private const int TWEET_COUNT = 10;
        private const string USERNAME = "NoserXamaDemo";

        public async Task<List<Tweet>> LoadTweetsAsync()
        {
            string twitterData = await GetTweetsAsJsonAsync();
            return DeserializeJson(twitterData);
        }

        private async Task<string> GetTweetsAsJsonAsync()
        {
            string twitterData = string.Empty;

            string accessToken = await GetAccessToken();

            var requestUserTimeline = new HttpRequestMessage(HttpMethod.Get,
                string.Format("https://api.twitter.com/1.1/statuses/user_timeline.json?count={0}&screen_name={1}&trim_user=1&exclude_replies=1",
                              TWEET_COUNT, USERNAME));
            requestUserTimeline.Headers.Add("Authorization", "Bearer " + accessToken);
            var httpClient = new HttpClient();
            HttpResponseMessage responseUserTimeLine = await httpClient.SendAsync(requestUserTimeline);
            return await responseUserTimeLine.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAccessToken()
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, TWITTER_API_TOKEN);
            var customerInfo = Convert.ToBase64String(new UTF8Encoding().GetBytes(CONSUMER_KEY + ":" + CONSUMER_SECRET));
            request.Headers.Add("Authorization", "Basic " + customerInfo);
            request.Content = new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded");
            HttpResponseMessage response = await httpClient.SendAsync(request);

            string json = await response.Content.ReadAsStringAsync();
			AccessToken item = JsonConvert.DeserializeObject<AccessToken>(json);
			return item.access_token;
        }

        private List<Tweet> DeserializeJson(string twitterData)
        {
            return JsonConvert.DeserializeObject<List<Tweet>>(twitterData);
        }
    }
}