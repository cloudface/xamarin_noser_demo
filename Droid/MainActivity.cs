using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using XamiWhammy.Models;
using XamiWhammy.Presentation;
using XamiWhammy.Repos;

namespace XamiWhammy.Droid
{
	[Activity (Label = "XamiWhammy", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity, TwitterView
    {
		int count = 1;

        private TwitterPresenter Presenter { get; set; }

        private ListView TwitterList { get; set; }

        public void ShowNoTweetsMessage()
        {
            
        }

        public void ShowProgressBar()
        {
           
        }

        public void ShowTweets(List<Tweet> tweets)
        {
            ArrayAdapter adapter = new TweetAdapter(this, tweets);
            TwitterList.Adapter = adapter;
        }

        protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

            SetContentView (Resource.Layout.Main);

            Presenter = new TwitterPresenter(this, new TwitterRepoImpl());

            TwitterList = FindViewById<ListView> (Resource.Id.twitterList);

            Presenter.LoadFeed();
		}
	}
}


