using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            Meme meemi1 = new Meme();
            meemi1.Name = "Jokumeemi";
            meemi1.Funlevel = 1;
            meemi1.Creator = "Mankine";
            meemi1.Year = 2017;


            Console.WriteLine(meemi1.ToString());
            Console.WriteLine();

            Dankmeme dankki1 = new Dankmeme();
            dankki1.Name = "Ebinmeemi";
            dankki1.Funlevel = 10;
            dankki1.Creator = "Joni";
            dankki1.Year = 2016;
            dankki1.Danklevel = 100;
            dankki1.Nsfw = false;


            Console.WriteLine(dankki1.ToString());
            Console.WriteLine();
        }
    }
}
