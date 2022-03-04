using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_1
{
    abstract class Phone : IPhone
    {
        public string Name { get; set; }
        public double Memory { get; set; }
        public double ProcessorFrequency { get; set; }
        public double Camera { get; set; }

        public IPhone CreatePhone(string name = "", double memory = 0, double proccesorFrequency = 0, double camera = 0)
        {
            Name = name;
            Memory = memory;
            ProcessorFrequency = proccesorFrequency;
            Camera = camera;
            return this;
        }
        public override string ToString()
        {
            return "Name : " + Name + "\nMemory : " + Memory +
                "\n ProccesorFrequency : " + ProcessorFrequency + "\n Camera : " + Camera;
        }
    }
}
