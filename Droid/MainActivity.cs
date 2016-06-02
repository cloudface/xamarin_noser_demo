using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using XamiWhammy.Models;
using XamiWhammy.Presentation;

namespace XamiWhammy.Droid
{
	[Activity (Label = "XamiWhammy", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity, TwitterView
    {
		int count = 1;

        private TwitterPresenter Presenter { get; set; }

        private ListView TwitterList { get; set; }

        public void ShowProgressBar()
        {
            throw new NotImplementedException();
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

            Presenter = new TwitterPresenter(this);

            TwitterList = FindViewById<ListView> (Resource.Id.twitterList);

            Presenter.LoadFeed();
		}
	}
}


