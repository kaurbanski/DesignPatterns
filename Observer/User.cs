using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class User : IObserver
    {
        public string Name { get; private set; }
        public int VideosToWatch { get; private set; }

        public User(string name)
        {
            Name = name;
            VideosToWatch = 0;
        }

        public void Update()
        {
            VideosToWatch++;
            Console.WriteLine("Dodano nowy film, masz do zobaczenia {0} filmów", VideosToWatch);
        }
    }
}
