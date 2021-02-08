using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    class DVD : Storage
    {
        public string Type { get; set; }
        public double SpeedOfRW { get; set; }
        public override void CopyTo(int memory)
        {
            if (Memory * 1024 > memory)
            {
                double time = (memory * 8) / SpeedOfRW;
                Console.WriteLine($"DVD needs {time} seconds to copy this file");
            }
            else
            {
                throw new NoSpaceInMemoryException();
            }
        }

        public override double FreeMemory(double memory)
        {
            return Memory - memory / 1024;
        }

        public override int GetSpace()
        {
            return Memory;
        }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Memory : {Memory}GB");
            Console.WriteLine($"Type : {Type}");
            Console.WriteLine($"Speed(Read/Write) : {SpeedOfRW}Mbit/s");
            Console.WriteLine($"Free Memory : {FreeMemory(0)}GB");
            Console.WriteLine();
        }
    }
}
