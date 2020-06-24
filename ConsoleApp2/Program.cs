using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using ClassLibrary1;

namespace MyDemoAppNSpace
{


    class Program
    {
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("Choose an option in square brackets");
            Console.WriteLine("[1] Hello World App");
            Console.WriteLine("[2] option2");
            Console.WriteLine("[3] Math class");
            Console.WriteLine("[0] exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    DoWork1();
                    return true;
                case "2":
                    DoWork2();
                    return true;
                case "3":
                    //Math Class
                    DoWork3();
                    return true;
                case "0":
                    //exit
                    return false;
                default:
                    return true;
            }

        }
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }




            ClassLibrary1.Class1 cl1 = new Class1();
            int a = cl1.Atimtis(5, 2);
            Console.WriteLine(a);

        }

        static void DoWork1()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public static void DoWork2()
        {
            Console.WriteLine("Just creates an instance of demo class and call it's method");
            Worker1 w1 = new Worker1();
            w1.printMsg();
            Console.WriteLine(w1.addNumbers(5, 2));
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        static void DoWork3()
        {
            Console.WriteLine("Math Class and it's methods");
            ClassDoWorkMath m1 = new ClassDoWorkMath();
            m1.PrintInfoMsg1();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }


    }
}
