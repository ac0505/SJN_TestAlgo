using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJN_TestAlgo
{
    public class CarService
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public CarService(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }   
    }
}
