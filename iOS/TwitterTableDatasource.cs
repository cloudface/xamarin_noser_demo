using System;
using UIKit;
using System.Collections.Generic;
using XamiWhammy.Models;

namespace XamiWhammy.iOS
{
	public class TwitterTableDatasource : UITableViewDataSource
	{
		private const string twitterTableIdentifier = "TwitterTableIdentifier";
		public List<Tweet> Tweets { get; set;}

		public TwitterTableDatasource ()
		{
		}

		#region implemented abstract members of UITableViewDataSource

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (twitterTableIdentifier);
			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Default, twitterTableIdentifier);
			}

			var tweet = Tweets [indexPath.Row];
			cell.TextLabel.Text = tweet.text;
			return cell;
		}

		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return Tweets.Count;
		}

		#endregion
	}
}

