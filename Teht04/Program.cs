using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike fillari1 = new Bike();
            fillari1.Name = "Jopo";
            fillari1.Model = "Mummopyörä";
            fillari1.Colour = "Red";
            fillari1.YearModel = 1979;
            fillari1.Gear = false;
            Console.WriteLine("Bike info: ");
            Console.WriteLine(fillari1.ToString());
            Console.WriteLine();

            Bike fillari2 = new Bike();
            fillari2.Name = "Tunturi";
            fillari2.Model = "Maastopyärä";
            fillari2.Colour = "Black";
            fillari2.YearModel = 2017;
            fillari2.Gear = true;
            fillari2.GearName = "Nihao";
            Console.WriteLine("Bike info: ");
            Console.WriteLine(fillari2.ToString());
            Console.WriteLine();

            Boat paatti1 = new Boat();
            paatti1.Name = "Purkki";
            paatti1.Model = "Vauhti";
            paatti1.Colour = "Blue";
            paatti1.YearModel = 2001;
            paatti1.Seats = 5;
            paatti1.BoatType = "Amme";
            Console.WriteLine("Boat info: ");
            Console.WriteLine(paatti1.ToString());
            Console.WriteLine();


            Boat paatti2 = new Boat();
            paatti2.Name = "Mersu";
            paatti2.Model = "Turbo";
            paatti2.Colour = "Red";
            paatti2.YearModel = 2016;
            paatti2.Seats = 2;
            paatti2.BoatType = "Kilpavene";
            Console.WriteLine("Boat info: ");
            Console.WriteLine(paatti2.ToString());
            Console.WriteLine();
        }
    }
}
