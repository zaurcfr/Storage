using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    class Program
    {
        public static void Copy(Storage storage, int memory)
        {
            try
            {
                storage.CopyTo(memory);
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            Storage flash = new Flash
            {
                Name = "Flash",
                Model = "Sandisk",
                Memory = 8,
                SpeedOfUSB3 = 100
            };
            Storage DVD = new DVD
            {
                Name = "DVD",
                Model = "SMTH",
                Type = "Double sided",
                Memory = 9,
                SpeedOfRW = 1
            };
            Storage HDD = new HDD
            {
                Name = "HDD",
                Model = "Seagate",
                Memory = 2048,
                SpeedOfUSB2 = 2
            };
            Storage SSD = new SSD
            {
                Name = "SSD",
                Model = "Samsung",
                Type = "M2",
                Memory = 1024,
                SpeedOfSSD = 600
            };

            Console.Clear();
            Console.WriteLine("Info about all storage devices:\n");
            flash.PrintDeviceInfo();
            DVD.PrintDeviceInfo();
            HDD.PrintDeviceInfo();
            SSD.PrintDeviceInfo();

            Console.WriteLine("Which one do you prefer to transfer through? (1/2/3/4)");
            string op = Console.ReadLine();
            int memory;
            switch (op)
            {
                case "1":
                    Console.WriteLine("What is the memory capacity of the file you want to transfer?(MB)");
                    memory = Convert.ToInt32(Console.ReadLine());
                    Copy(flash, memory);
                    Console.WriteLine($"Free Memory: {flash.FreeMemory(memory)}GB");
                    break;
                case "2":
                    Console.WriteLine("What is the memory capacity of the file you want to transfer?(MB)");
                    memory = Convert.ToInt32(Console.ReadLine());
                    Copy(DVD, memory);
                    Console.WriteLine($"Free Memory: {DVD.FreeMemory(memory)}GB");
                    break;
                case "3":
                    Console.WriteLine("What is the memory capacity of the file you want to transfer?(MB)");
                    memory = Convert.ToInt32(Console.ReadLine());
                    Copy(HDD, memory);
                    Console.WriteLine($"Free Memory: {HDD.FreeMemory(memory)}GB");
                    break;
                case "4":
                    Console.WriteLine("What is the memory capacity of the file you want to transfer?(MB)");
                    memory = Convert.ToInt32(Console.ReadLine());
                    Copy(SSD, memory);
                    Console.WriteLine($"Free Memory: {SSD.FreeMemory(memory)}GB");
                    break;
                default:
                    break;
            }
        }
    }
}
