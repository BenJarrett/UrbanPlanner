using System;
using System.Collections.Generic;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            
                FiveOneTwoEigth.Width = 50.9;
                FiveOneTwoEigth.Height = 35.1;
                FiveOneTwoEigth.Stories = 1;
                FiveOneTwoEigth.Construct();
                FiveOneTwoEigth.Purchase("Richard");
                FiveOneTwoEigth.Display();


            Building One = new Building("123 Wake Drive");
                One.Width = 60.3;
                One.Height = 40.2;
                One.Stories = 6;
                One.Construct();
                One.Purchase("Becky");
                One.Display();


            Building Three = new Building("123 Wake Drive");
                One.Width = 90.5;
                One.Height = 57.2;
                One.Stories = 5;
                One.Construct();
                One.Purchase("Bob");
                One.Display();


        }
    }
}
