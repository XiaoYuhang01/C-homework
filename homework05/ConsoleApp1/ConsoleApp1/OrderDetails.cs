using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OrderDetails
    {
        public Cargo CargoExample { get; }
        public int CargoNumber { get; }
        public double DetailPrice { get => CargoNumber * CargoExample.CargoPrice; }

        public OrderDetails(Cargo cargo, int number)
        {
            this.CargoExample = cargo;
            this.CargoNumber = number;
        }
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
