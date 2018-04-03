using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class YoutubeChannel : IPublisher
    {
        private List<IObserver> observers;

        public YoutubeChannel()
        {
            observers = new List<IObserver>();
        }

        public void PublishNewVide()
        {
            Console.WriteLine("Yt channel: Published new vide.");
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach(var o in observers)
            {
                o.Update();
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
