using System;

namespace CS029
{
    class Program
    {
        static void DoSomeThing(int sec, string msg, ConsoleColor color)
        {
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg,-10} ...Start");
                Console.ResetColor();
            }



            for (int i = 1; i <= sec; i++)
            {
                lock (Console.Out)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine($"{msg,-10} {i,2}");
                    Console.ResetColor();
                }
                Thread.Sleep(1000);
            }
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg,-10} ...End");
                Console.ResetColor();
            }

        }
        static async Task Task2()
        {
            Task t2 = new Task(
                () =>
                {
                    DoSomeThing(10, "T2", ConsoleColor.Green);
                }

            );
            t2.Start();
            await t2;
            //t2.Wait();
            Console.WriteLine("T2 da hoan thanh");
            //return t2;
        }



        static async Task Task3()
        {
            Task t3 = new Task((object ojb) =>
            {
                string nameTask = (string)ojb;
                DoSomeThing(6, nameTask, ConsoleColor.Yellow);
            }, "T3");
            t3.Start();
            await t3;
            //t3.Wait();
            Console.WriteLine("T3 da hoan thanh");
            //return t3;
        }
        /*
        // tao 1 async task tu 1 ham static void
        static async Task Abc()
        {
            Task task = new Task(() =>
            {
                // ... cac chi thi lenh
            });
            task.Start();
            await task;
            //... cac chi thi lenh sau do
        }
        */
        static async Task<string> Task4()
        {

            Task<string> t4 = new Task<string>(() =>
            {
                DoSomeThing(10, "T4", ConsoleColor.DarkGray);
                return "Return from T4";
            });
            t4.Start();
            var rs = await t4;
            Console.WriteLine("T4 hoan thanh");
            return rs;
            //return t4;
        }

        static async Task<string> Task5()
        {
            Task<string> t5 = new Task<string>((object ob) =>
            {
                string s = (string)ob;
                DoSomeThing(8, "T5", ConsoleColor.DarkBlue);
                return $"Return from {s}";
            }, "T5");
            t5.Start();
            var rs = await t5;
            Console.WriteLine("T5 hoan thanh");
            return rs;
            //return t5;
        }
        /*
         // tao 1 async task tu 1 ham thong thuong co kieu tra ve
        static async Task<object> Abc()
        {
            Task<object> task = new Task<object>
            (
               () =>
               {
                   // ... cac tac vu
                   return new object();
               }
            );
            task.Start();
            var kq = await task;
            return kq;
        }
        */

        static void Main(string[] args)
        {
            /*
            // synchronous
            DoSomeThing(6, "T1", ConsoleColor.Magenta);
            DoSomeThing(10, "T2", ConsoleColor.Green);
            DoSomeThing(6, "T3", ConsoleColor.Yellow);
            */
            /*
            Task t2 = new Task(
                () =>
                {
                    DoSomeThing(10, "T2", ConsoleColor.Green);
                }

            );

            Task t3 = new Task((object ojb) =>
            {
                string nameTask = (string)ojb;
                DoSomeThing(6, nameTask, ConsoleColor.Yellow);
            }, "T3");
            t2.Start();
            t3.Start();
            
            Task t2 = Task2();
            Task t3 = Task3();
            */
            //DoSomeThing(6, "T1", ConsoleColor.Magenta);
            //t2.Wait();
            //Task.WaitAll(t3, t2);

            //Task<string> t3 = new Task<string>(Func<string>); //() => {return string;} 
            //Task<string> t3 = new Task<string>(Func<object, string>, object); // (object obj) => {return string;}
            /*
            Task<string> t4 = new Task<string>(() =>
            {
                DoSomeThing(10, "T4", ConsoleColor.DarkGray);
                return "Return from T4";
            });

            Task<string> t5 = new Task<string>((object ob) =>
            {
                string s = (string)ob;
                DoSomeThing(8, "T5", ConsoleColor.DarkBlue);
                return $"Return from {s}";
            }, "T5");
            */
            Task<string> t4 = Task4();
            Task<string> t5 = Task5();
            //t4.Start();
            //t5.Start();

            DoSomeThing(6, "T1", ConsoleColor.Magenta);
            Task.WaitAll(t4, t5);
            string s4 = t4.Result;
            string s5 = t5.Result;
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine("Press Any Key");
            Console.ReadKey();
        }
    }
}