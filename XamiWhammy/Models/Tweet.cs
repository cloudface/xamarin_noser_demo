using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamiWhammy.Models
{
    public class Tweet
    {
        public string name { get; set; }
        public string text { get; set; }
        public string created_at { get; set; }
        public string profile_image_url { get; set; }
    }
}
