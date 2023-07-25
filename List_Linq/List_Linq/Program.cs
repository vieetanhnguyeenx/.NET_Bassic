using System;
using System.Collections.Generic;

namespace List_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            do
            {
                Console.WriteLine("1.Add");
                Console.WriteLine("1.Update");
                Console.WriteLine("1.Delete");
                Console.WriteLine("1.Search");
                Console.WriteLine("1.Exit");
                Console.WriteLine("Input your selecttion: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        controller.addStudent();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:

                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;

                }
            } while (true);



        }
    }
}
