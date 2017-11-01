using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImageDownload
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                WebClient webClient = new WebClient();
                // Proxy
                //webClient.Proxy = new WebProxy("190.109.64.4:3128");
                // My Document Folder with a new folder
                String newFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ExampleFolder/";
                Console.WriteLine("New Folder:" + newFolder);
                // Create the Folder
                if (!Directory.Exists(newFolder))
                {
                    Directory.CreateDirectory(newFolder);
                    Console.WriteLine("Folder created: " + newFolder);
                }
                // Download the File
                webClient.DownloadFile("https://www.google.com.mx/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png", newFolder + "googlelogo_color_272x92dp.png");
                Console.WriteLine("File downloaded");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Problem: " + ex.Message);

            }
            Console.ReadKey();
        }

    }
}
