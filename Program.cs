using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppleIPhone phone = new AppleIPhone();
            Console.WriteLine(phone);
            SamsungGalaxy galaxy = new SamsungGalaxy();
            Console.WriteLine(galaxy);
        }
    }
}
