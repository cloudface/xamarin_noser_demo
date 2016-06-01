using System;
		
using UIKit;
using XamiWhammy.Presentation;

namespace XamiWhammy.iOS
{
	public partial class ViewController : UIViewController, TwitterView
	{
		private TwitterPresenter Presenter{ get; set;}

		public ViewController (IntPtr handle) : base (handle)
		{	
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Presenter = new TwitterPresenter (this);
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

		#endregion
	}
}
