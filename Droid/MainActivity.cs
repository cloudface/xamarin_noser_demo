using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using XamiWhammy.Models;
using XamiWhammy.Presentation;
using XamiWhammy.Repos;
using Android.Views;

namespace XamiWhammy.Droid
{
	[Activity (Label = "XamiWhammy", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity, TwitterView
    {

        private TwitterPresenter Presenter { get; set; }

        private ListView TwitterList { get; set; }

        private TextView NoTweetsLabel { get; set; }

        private ProgressDialog progressDialog { get; set; }

        public void ShowNoTweetsMessage()
        {
            progressDialog.Dismiss();
            NoTweetsLabel.Visibility = ViewStates.Visible;
            TwitterList.Visibility = ViewStates.Gone;
        }

        public void ShowProgressBar()
        {
            progressDialog.Show();
        }

        public void ShowTweets(List<Tweet> tweets)
        {
            progressDialog.Dismiss();
            ArrayAdapter adapter = new TweetAdapter(this, tweets);
            TwitterList.Adapter = adapter;
        }

        protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

            SetContentView (Resource.Layout.Main);

            Presenter = new TwitterPresenter(this, new TwitterRepoImpl());

            TwitterList = FindViewById<ListView> (Resource.Id.twitterList);

            NoTweetsLabel = FindViewById<TextView>(Resource.Id.noTweetsMessage);

            progressDialog = new ProgressDialog(this);
            progressDialog.SetTitle("Loading Tweets");

            Presenter.LoadFeed();
		}
	}
}


