using System;
using XamiWhammy.Models;
using System.Collections.Generic;

namespace XamiWhammy
{
	public interface TwitterView
	{
		void ShowProgressBar ();

		void ShowTweets (List<Tweet> mocktweets);
	}
}
