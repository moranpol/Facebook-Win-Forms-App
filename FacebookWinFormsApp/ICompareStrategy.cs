using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface ICompareStrategy
    {
        bool Compare(Post i_Post1, Post i_Post2);
    }
}
