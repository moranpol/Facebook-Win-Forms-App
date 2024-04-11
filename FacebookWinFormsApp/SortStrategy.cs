using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal enum eCompareTypes
    {
        Time,
        Likes,
    }

    internal class SortStrategy
    {
        private ICompareStrategy m_Compare;

        public SortStrategy(eCompareTypes i_Type)
        {
            if (i_Type == eCompareTypes.Time)
            {
                m_Compare = new CompareByTimeStrategy();
            }
            else
            {
                m_Compare = new CompareByLikesCountStrategy();
            }
        }

        public void Sort(List<Post> i_Posts)
        {
            int v_Size = i_Posts.Count;
            try
            {
                for (int i = 0; i < v_Size - 1; i++)
                {
                    for (int j = 0; j < v_Size - i - 1; j++)
                    {

                        if (!m_Compare.Compare(i_Posts[i], i_Posts[j]))
                        {
                            Post temp = i_Posts[j];
                            i_Posts[j] = i_Posts[j + 1];
                            i_Posts[j + 1] = temp;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
