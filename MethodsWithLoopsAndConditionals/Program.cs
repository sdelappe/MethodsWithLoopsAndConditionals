using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number1();

            //Number2();

            //Number3();

            //Number4();

            //Number5();

            //Number6();

            //HeatUp1();

            //HeatUp2();
            
        }

        public static void Number1()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Number2()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        public static void Number3(int a, int b)
        {
            if (a == 3)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public static void Number4(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

        public static void Number5(int a)
        {
            if (a > 0)
            {
                Console.WriteLine("Positive");
            } else if (a < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Value is 0");
            }
        }

        public static void Number6()
        {
            Console.WriteLine("How old are you?");
            int age;
            bool response = int.TryParse(Console.ReadLine(), out age);

            if (response)
            {
                if (age > 18)
                {
                    Console.WriteLine("You can vote");
                }
                else
                {
                    Console.WriteLine("You ain't old enough to vote");
                }
            } 
            else
            {
                Console.WriteLine("That's not a number");
            }
        }

        public static void HeatUp1()
        {
            int num;

            Console.Write("Pick a number: ");
            bool response = int.TryParse(Console.ReadLine(), out num);

            if (response)
            {
                if (num > 10 || num < -10)
                {
                    Console.WriteLine("Number out of range");
                } 
                else
                {
                    Console.WriteLine("Number in range");
                }
            }
            else
            {
                Console.WriteLine("That's not a number");
            }

        }

        public static void HeatUp2()
        {
            Console.Write("Pick a number: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                int b = a * i;
                Console.WriteLine($"{a} x {i} = {b}");
            }
        }
    }
}
