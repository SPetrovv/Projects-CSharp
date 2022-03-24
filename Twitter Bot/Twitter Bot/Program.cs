using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
//using TweetSharp;

namespace Twitter_Bot
{
    internal class Program
    {
        private static string customer_key = "###############################";
        private static string customer_key_secret = "########################";
        private static string access_token = "#############################";
        private static string access_token_secret = "######################";

        private static TwitterService service = new TwitterService(customer_key, customer_key_secret, access_token, access_token_secret);

        private static int currentImageID = 0;
        private static List<string> imageList = new List<string> { "###################"};

        static void Main(string[] args)
        {
            Console.WriteLine($"<{DateTime.Now}> - Bot Started");
            SendMediaTweet("Test", currentImageID);
            Console.Read();


        }

        private static void SendTweet(string _status)
        {
            service.SendTweet(new SendTweetOptions { Status = _status }, (tweet, response) =>
           {
               if(response.StatusCode = HttpStatusCode.OK)
               {
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.WriteLine($"<{DateTime.Now}> - Tweet Sent!");
                   Console.ResetColor();

               }
               else
               {
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine($"ERROR " + response.Error.Message);
                   Console.ResetColor();
               }
           });
        }

        private static void SendMediaTweet(string _status, int imageID)
        {   
            using (var stream = new FileStream(imageList[imageID], FileMode.Open))
            {
                service.SendTweetWithMedia(new SendTweetWithMediaOptions
                {
                    Status = _status,
                    Images = new Dictionary<string, Stream> { { imageList[imageID], stream} } 
                });

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"<{DateTime.Now}> - Tweet Sent!");
                Console.ResetColor();


                if ((currentImageID + 1) == imageList.Count)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine($"BOT - End of image array");
                    Console.ResetColor();
                    currentImageID = 0; 

                }
                else
                {
                    currentImageID++;

                }
            }

        }
    }
}
