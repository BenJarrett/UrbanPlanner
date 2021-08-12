using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner
{
    class Building
    {

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get => Width * Depth * (3 * Stories);
        }

        string _designer = "Ben";
        string _Address;
        public Building(string address)
        {
            Address = address;
        }

    }
}
