using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace language_basic
{
    public class AsyncProgram
    {
        static async Task Main()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks = new List<Task>
            {
                eggsTask, baconTask, toastTask
            };

            while (breakfastTasks.Count > 0)
            {
                Task doneTask = await Task.WhenAny(breakfastTasks);
                if (doneTask == eggsTask)
                {
                    Console.WriteLine("Eggs are ready");
                }
                else if (doneTask == baconTask)
                {
                    Console.WriteLine("Bacon is ready");
                }
                else
                {
                    Console.WriteLine("Toast is ready");
                }

                breakfastTasks.Remove(doneTask);
            }

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int num)
        {
            var toast = await ToastBreadAsync(num);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice.");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");


        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int i = 0; i < slices; i++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }

            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon into pan");
            Console.WriteLine("cooking first side of bacon");
            for (int i = 0; i < slices; i++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }

            Console.WriteLine("cooking the second side of bacon");
            await Task.Delay(3000);
            Console.WriteLine("put bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int nums)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {nums} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}