using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Collections;
using XamiWhammy.Models;

namespace XamiWhammy.Droid
{
    class TweetAdapter : ArrayAdapter<Tweet>
    {
        public TweetAdapter(Context ctx, IList<Tweet> tweets) : base(ctx, 0, tweets)
        {
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var inflater = LayoutInflater.From(Context);
            var view = inflater.Inflate(Resource.Layout.TweetView, parent, false);
            Tweet tweet = GetItem(position);
            view.FindViewById<TextView>(Resource.Id.tweetPreview).Text = tweet.text;
            view.FindViewById<TextView>(Resource.Id.userName).Text = tweet.user.name;
            //view.FindViewById<ImageView>(Resource.Id.profilePicture).SetImageURI(Android.Net.Uri.Parse(tweet.profile_image_url));
            return view;
        }
    }
}