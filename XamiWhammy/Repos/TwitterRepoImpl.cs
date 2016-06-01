using System;
using System.Threading.Tasks;

namespace XamiWhammy.Repos
{
    public class TwitterRepoImpl : ITwitterRepo
    {
        private const string CONSUMER_KEY = @"G1ooObIUlod50uILwmxgEdIec";
        private const string CONSUMER_SECRET = @"Fbo8lCQYO0IioJSxGWIDmOhSpf7J7P77Vq1wdo9fCWeVmvxi3I";
        private const string ACCESS_TOKEN = @"4794667815-TfDOSGjmBFzj7byiAnNKmfvKe18XQsLoymfteZQ";
        private const string ACCESS_TOKEN_SECRET = @"kUwymd5fsubLsAmCDNUhqQIg4mG1o1x6AZaE2GvUoklES";

        public async Task LoadTweetsAsync()
        {
            
        }

        private string GetTweetsAsJson()
        {
            string twitterData = String.Empty;

            return twitterData;
        }
    }
}
