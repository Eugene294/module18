using System.Reflection;
using YoutubeExplode;

namespace module18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "https://youtube.com/watch?v=Gg8vBJvMQkQ";

            Sender sender = new Sender();
            Receiver receiver = new Receiver();
            YoutubeClient client = new YoutubeClient(); 

            CommandGetDesc commandGetDesc = new CommandGetDesc(receiver);
            sender.SetCommand(commandGetDesc);
            sender.Run(s, client);

            CommandDownload commandDownload = new CommandDownload(receiver);
            sender.SetCommand(commandDownload);
            sender.Run(s, client);

        }
    }
}
