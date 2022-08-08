using System.Net;
using System;
using System.Threading;

namespace CS021_ASYNCHRONOUS{
    public class DownloadWebite01{
        public static string DownloadWebPage(string url, bool showresult){
            using (var client = new WebClient()){
                Console.WriteLine("Downloading web...");
                string content = client.DownloadString (url);
                Thread.Sleep (3000);
                if (showresult)
                    Console.WriteLine (content.Substring (0, 150));

                return content;
            }
        }

        public static void TestDownloadWebPage(){
            string url = "https://code.visualstudio.com/";
            DownloadWebPage(url, true);
            Console.WriteLine("Do somthing ...");
        }
    }
}