using System;
using System.Threading.Tasks;

namespace language_basic
{
    class Program
    {
        // static void Main()
        // {
        //     Coffee cup = PourCoffee();
        //     Console.WriteLine("coffee is ready");
        //
        //     Egg eggs = FryEggs(2);
        //     Console.WriteLine("eggs are ready");
        //
        //     Bacon bacon = FryBacon(3);
        //     Console.WriteLine("bacon is ready");
        //
        //     Toast toast = ToastBread(2);
        //     ApplyButter(toast);
        //     ApplyJam(toast);
        //     Console.WriteLine("toast is ready");
        //
        //     Juice oj = PourOJ();
        //     Console.WriteLine("oj is ready");
        //     Console.WriteLine("Breakfast isd ready!");
        // }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice.");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");


        private static Toast ToastBread(int slices)
        {
            for (int i = 0; i < slices; i++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }

            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon into pan");
            Console.WriteLine("cooking first side of bacon");
            for (int i = 0; i < slices; i++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }

            Console.WriteLine("cooking the second side of bacon");
            Task.Delay(3000).Wait();
            Console.WriteLine("put bacon on plate");

            return new Bacon();
        }

        private static Egg FryEggs(int nums)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {nums} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }

    class Juice
    {
    }

    class Egg
    {
    }

    class Coffee
    {
    }

    class Bacon
    {
    }

    class Toast
    {
    }
}