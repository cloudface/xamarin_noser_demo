using System;

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
		}
	}
}

