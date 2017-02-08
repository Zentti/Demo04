using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Meme
    {
        public string Name { get; set; }
        public int Funlevel { get; set; }
        public int Year { get; set; }
        public string Creator { get; set; }

        public override string ToString()
        {
            return "Meme name; " + Name + ", Funlevel: " + Funlevel + ", Year: " + Year + ", Created By: " + Creator;
        }
    }
}
