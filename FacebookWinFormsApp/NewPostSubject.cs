using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class NewPostSubject
    {
        private List<INewPostObserver> m_Observers = new List<INewPostObserver>();

        public void Attach(INewPostObserver observer)
        {
            m_Observers.Add(observer);
        }

        public void Detach(INewPostObserver observer)
        {
            m_Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in m_Observers)
            {
                observer.NotifyNewPost();
            }
        }
    }
}
