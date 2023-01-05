using System;

namespace CS028
{
    class Program
    {

        static void ListFileDirectory(string path)
        {
            String[] directories = System.IO.Directory.GetDirectories(path);
            String[] files = System.IO.Directory.GetFiles(path);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
                ListFileDirectory(directory); // Đệ quy
            }
        }

        static void Main(string[] args)
        {
            /* kiem tra cac thong tin o dia
            var drives = DriveInfo.GetDrives();
            //DriveInfo drive = new DriveInfo("C");
            foreach (var drive in drives)
            {
                Console.WriteLine("Name: " + drive.Name);
                Console.WriteLine("Type: " + drive.DriveType);
                Console.WriteLine("Volume: " + drive.VolumeLabel);
                Console.WriteLine("Format: " + drive.DriveFormat);
                Console.WriteLine("Avilable: " + drive.AvailableFreeSpace);
                Console.WriteLine("Free: " + drive.TotalFreeSpace);
                Console.WriteLine("Size: " + drive.TotalSize + "\n");
            }
            */
            string path = "D:\\FPTUniversity\\Semester_5\\SWT\\GiaoLang";
            // Tao moi thu muc
            //Directory.CreateDirectory(path);
            // Xoa thu muc
            //Directory.Delete(path);

            // Kiem tra ton tai
            /*
            if (Directory.Exists(path))
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            */

            /*
            //Xem cac file
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("------------------------");

            var di = Directory.GetDirectories(path);
            foreach (var i in di)
            {
                Console.WriteLine(i);
            }
            */
            ListFileDirectory(path);
        }
    }
}
