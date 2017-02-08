using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ukko1 = new Employee();
            ukko1.Name = "Kauppisen Pete";
            ukko1.Profession = "Tyä ukko";
            ukko1.Salary = 3700;
            Console.WriteLine("Employee: ");
            Console.WriteLine(ukko1.ToString());
            Console.WriteLine();

            Boss pomo1 = new Boss();
            pomo1.Name = "Joni Korpihalkola";
            pomo1.Profession = "Hui Hai Hiisi";
            pomo1.Salary = 15666;
            pomo1.Car = "Mersu";
            pomo1.Bonus = 6666;
            Console.WriteLine("Boss: ");
            Console.WriteLine(pomo1.ToString());
            Console.WriteLine();

            ukko1.Salary = 2500;
            ukko1.Profession = "Varasto ukko";
            Console.WriteLine("Employee: ");
            Console.WriteLine(ukko1.ToString());
            Console.WriteLine();
        }
    }
}
