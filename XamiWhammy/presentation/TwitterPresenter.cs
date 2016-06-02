using System;
using System.Collections.Generic;
using XamiWhammy.Models;
using XamiWhammy.Repos;

namespace XamiWhammy.Presentation
{
	public class TwitterPresenter
	{
		public TwitterView View { get; set;}
		public ITwitterRepo Repository { get; set;}

		public TwitterPresenter (
			TwitterView view, ITwitterRepo repository)
		{
			View = view;
			Repository = repository;
		}

		public async void LoadFeed ()
		{
			View.ShowProgressBar ();
			var tweets = await Repository.LoadTweetsAsync();
			if (tweets.Count > 0) {
				View.ShowTweets (tweets);
			} else {
				View.ShowNoTweetsMessage ();
			}
		}
	}
}

