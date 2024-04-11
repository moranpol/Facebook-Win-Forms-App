using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class CompareByTimeStrategy : ICompareStrategy
    {
        public bool Compare(Post i_Post1, Post i_Post2)
        {
            return i_Post1.CreatedTime < i_Post2.CreatedTime;
        }
    }
}
