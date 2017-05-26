using ObserverPatternTutorial.Observer;
using ObserverPatternTutorial.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            YouTubeChannel RedChannel = new YouTubeChannel(); // Create new youtube account.

            ISubscriber Joey = new User();
            ISubscriber Alex = new User();
            ISubscriber Gal = new Moderator();

            RedChannel.Subscribe(Joey);
            RedChannel.Subscribe(Alex);
            RedChannel.Subscribe(Gal);

            Console.WriteLine(" --- I upload a new video. --- ");
            RedChannel.NotifySubscribers(); // I upload a new video.

            Console.WriteLine(" --- Alex unsubscribe. --- ");
            RedChannel.Unsubscribe(Alex);

            Console.WriteLine(" --- I upload a new video. --- ");
            RedChannel.NotifySubscribers(); // I upload a new video.

            Console.ReadKey();
        }
    }
}
