using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamiWhammy.Repos
{
    public interface ITwitterRepo
    {
       Task LoadTweetsAsync();
    }
}
