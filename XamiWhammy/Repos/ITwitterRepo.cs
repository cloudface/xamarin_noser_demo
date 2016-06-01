using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamiWhammy.Models;

namespace XamiWhammy.Repos
{
    public interface ITwitterRepo
    {
       Task<IEnumerable<Tweet>> LoadTweetsAsync();
    }
}
