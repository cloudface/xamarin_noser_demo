using System;
using System.Collections.Generic;
using XamiWhammy.Models;

namespace XamiWhammy.Presentation
{
	public class TwitterPresenter
	{
		public TwitterView View { get; set;}

		public TwitterPresenter (
			TwitterView view)
		{
			View = view;
		}

		public void LoadFeed ()
		{
			View.ShowProgressBar ();
			//TODO: fetch feed from repo
			var mocktweets = new List<Tweet>();

			mocktweets.Add(new Tweet(){ text = "Wow I love this soft icecream"});
			mocktweets.Add(new Tweet(){ text = "Humm smells a little funky"});
			mocktweets.Add(new Tweet(){ text = "where is RALF!"});
			View.ShowTweets (mocktweets);
			//"Wow I love this soft icecream","",""s
		}
	}
}

