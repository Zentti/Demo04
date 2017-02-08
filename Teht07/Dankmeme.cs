using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Dankmeme : Meme
    {
        public int Danklevel { get; set; }
        public bool Nsfw { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", Danklevel: " + Danklevel + ", Nsfw? " + Nsfw;
        }
    }
}
