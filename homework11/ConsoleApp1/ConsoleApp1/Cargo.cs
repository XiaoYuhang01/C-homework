using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cargo
    {
        public string CargoName { get; set; }
        public double CargoPrice { get; set; }
        
        public Cargo(string CargoName, double CargoPrice) { this.CargoName = CargoName; this.CargoPrice = CargoPrice; }
        public Cargo() { }
        public override string ToString()
        {
            return CargoName;
        }
    }
}
