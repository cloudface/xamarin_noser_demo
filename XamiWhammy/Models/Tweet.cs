using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamiWhammy.Models
{
    public class Tweet
    {
        public string Username { get; set; }
        public string Content { get; set; }
        public DateTime TweetDate { get; set; }
        public string ProfilePicture { get; set; }
    }
}
