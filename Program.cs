    using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
    using System.IO;

    namespace DriveAccessApp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                DriveInfo[] x = DriveInfo.GetDrives();
                int cnt = x.Length;
                Console.WriteLine("total number of drives in the system" + cnt + "Drives");
                int i;
                
                Console.WriteLine("Press any key to shutdown the system:");
                Console.ReadKey();
                Process.Start("shutdown", "/s /t 10");
                Console.ReadKey();
            }
        }
    }
