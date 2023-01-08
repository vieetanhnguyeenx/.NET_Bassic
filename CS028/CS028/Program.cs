using System;
using System.Text;

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
            // DRIVE-INFO
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
            // DIRECTORY - THU MUC
            */
            //string path = "D:\\FPTUniversity\\Semester_5\\SWT\\GiaoLang";
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
            //ListFileDirectory(path);

            /*
            var path = "D:\\FPT_Study\\DotNet\\.NET_Bassic\\CS028\\ReadMe.txt";
            //string content1 = "Xin chao cac ban\n";
            //string content2 = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            //File.WriteAllText(path, content1);
            //File.AppendAllText(path, content2);

            string fileContent = File.ReadAllText(path);
            Console.WriteLine(fileContent);
            */
            /*
            var path = "D:\\FPT_Study\\DotNet\\.NET_Bassic\\CS028\\ReadMe.txt";
            using var stream = new FileStream(path: path, FileMode.Truncate);

            // steam luu du lieu
            byte[] buffer = { 1, 2, 3, 4 };
            //stream.Write(buffer, 0, buffer.Length);

            int soByteDocDuoc = stream.Read(buffer, 0, 3);
            int abc = 1;
            var byte_abc = BitConverter.GetBytes(abc);
            //byte -> int, double
            BitConverter.ToInt32(byte_abc, 0);
            */
            string s = "Abc";
            var byte_s = Encoding.UTF8.GetBytes(s);
            Console.WriteLine(byte_s);
        }
    }
}
