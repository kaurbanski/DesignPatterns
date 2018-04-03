using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IObserver user1 = new User("Kamil");
            IObserver user2 = new User("Jan");

            YoutubeChannel channel = new YoutubeChannel();
            channel.Register(user1);
            channel.Register(user2);

            channel.PublishNewVide();
            channel.PublishNewVide();
            channel.Unregister(user1);
            channel.PublishNewVide();
            Console.ReadLine();
        }
    }
}
