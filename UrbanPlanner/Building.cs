using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner
{
    class Building
    {

        public int Stories { get; set; } = 4;  // REMINDER: A get property accessor is used to return the property value, and a set property accessor is used to assign a new value.
        public double Width { get; set; } = 20.4;
        public double Height { get; set; } = 40.5;
        public double Volume
        {
            get => Width * Height * (3 * Stories);
        }

        //Private Fields
        // Fields typically store the data that must be accessible to more than one class method and must be stored for longer than the lifetime of any single method.
        // an underscore denotes private fields.
        private string _designer = "Ben Jarrett";
        private DateTime _constructionDate = DateTime.Now;
        private string _address;
        private string _owner;

        public Building(string address) // REMINDER: Constructors set default values & limit instantiation
        {
            _address = address;
        }

        public void Construct()
        {
            _constructionDate = DateTime.Now;
        }

        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }

        public void Display()
        {   
            Console.WriteLine($"{ _address} --------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_constructionDate}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

    }
}
