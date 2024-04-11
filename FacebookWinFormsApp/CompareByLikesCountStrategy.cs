using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class CompareByLikesCountStrategy : ICompareStrategy
    {
        public bool Compare(Post i_Post1, Post i_Post2)
        {
            try 
            {
                return i_Post1.LikedBy.Count < i_Post2.LikedBy.Count;
            } 
            catch
            {
                throw new Exception("Cannot get Likes count, Error in Facebook API.");
            }
            
        }
    }
}
