using System;
		
using UIKit;

namespace XamiWhammy.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;
		private NoserService noserService;

		public ViewController (IntPtr handle) : base (handle)
		{	
			noserService = new NoserTwitterService ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate {
				var title = string.Format ("{0} clicks!", count++);
				Button.SetTitle (title, UIControlState.Normal);
			};
		}

		public override void DidReceiveMemoryWarning ()
		{		
			base.DidReceiveMemoryWarning ();		
			// Release any cached data, images, etc that aren't in use.		
		}

		partial void didPressFetchButton (UIButton sender)
		{
			Button.SetTitle("Whoa! Pressed the button!", UIControlState.Normal);
			noserService.fetchString();
		}
	}
}
