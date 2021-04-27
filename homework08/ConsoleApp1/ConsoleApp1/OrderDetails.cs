using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderDetails
    {
        public Cargo CargoExample { get; }
        public double CargoExamplePrice { get => CargoExample.CargoPrice; }
        public int CargoNumber { get; }
        public double DetailPrice { get => CargoNumber * CargoExamplePrice; }

        public OrderDetails(Cargo cargo, int number)
        {
            this.CargoExample = cargo;
            this.CargoNumber = number;
        }
        public OrderDetails() { }
        public override bool Equals(object obj)
        {
            OrderDetails detail = obj as OrderDetails;
            return detail.CargoExample.CargoName == CargoExample.CargoName && detail.CargoNumber == CargoNumber;
        }

        public override int GetHashCode()
        {
            return CargoNumber;
        }
    }
}
