using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Memory { get; set; }

        public abstract int GetSpace();
        public abstract void CopyTo(int memory);
        public abstract double FreeMemory(double memory);
        public abstract void PrintDeviceInfo();
    }
}
