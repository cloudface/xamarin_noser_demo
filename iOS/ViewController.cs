using System;
		
using UIKit;
using XamiWhammy.Presentation;
using XamiWhammy.Models;
using System.Collections.Generic;

namespace XamiWhammy.iOS
{
	public partial class ViewController : UIViewController, TwitterView,TwitterTableDelegateListener
	{
		private TwitterPresenter Presenter{ get; set;}
		private TwitterTableDatasource DataSource { get; set;}

		public ViewController (IntPtr handle) : base (handle)
		{	
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Presenter = new TwitterPresenter (this);
			DataSource = new TwitterTableDatasource ();
			TwitterTable.Delegate = new TwitterTableDelegate (this);
			TwitterTable.DataSource = DataSource;
			Presenter.LoadFeed ();
		}

		public override void DidReceiveMemoryWarning ()
		{		
			base.DidReceiveMemoryWarning ();		
			// Release any cached data, images, etc that aren't in use.		
		}

		#region TwitterView implementation

		public void ShowProgressBar ()
		{
			Spinner.StartAnimating ();
		}


		public void ShowTweets (System.Collections.Generic.List<XamiWhammy.Models.Tweet> mocktweets)
		{
			DataSource.Tweets = mocktweets;
			TwitterTable.ReloadData ();
			TwitterTable.Alpha = 1;
			Spinner.StopAnimating ();
		}
		#endregion

		#region TwitterTableDelegateListener implementation

		public void DidSelectRowAtIndexPath (Foundation.NSIndexPath indexPath)
		{
			PerformSegue ("showTwitterDetail", this);
		}

		#endregion
	}
}
