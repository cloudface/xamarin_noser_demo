using System;
using UIKit;
using Foundation;

namespace XamiWhammy.iOS
{
	public class TwitterTableDelegate : UITableViewDelegate
	{
		public TwitterTableDelegateListener twitterTableDelegateListener;

		public TwitterTableDelegate (TwitterTableDelegateListener twitterTableDelegateListener)
		{
			this.twitterTableDelegateListener = twitterTableDelegateListener;
		}

		public override void  RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			twitterTableDelegateListener.DidSelectRowAtIndexPath (indexPath);

		}
	}

	public interface TwitterTableDelegateListener 
	{
		void DidSelectRowAtIndexPath( NSIndexPath indexPath );	
	}
}

