using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_1
{
    public interface IPhone
    {
        string Name { get; set; }
        double Memory { get; set; }
        double ProcessorFrequency { get; set; }
        double Camera { get; set; }
        IPhone CreatePhone(string name = "Iphone 11", double memory = 64, double proccesorFrequency = 2400, double camera = 12);
    }
}
