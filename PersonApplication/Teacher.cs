using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Teacher : Person
    {
        public string Room { get; set; }

        // default constructor
        public Teacher()
        {
        }

        // parametric constructor calls base class constructor with parameters
        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname)
        {
            Room = room;
        }

        // just one method what Teacher can do
        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        // override base class ToString()-method
        public override string ToString()
        {
            // Person - luokan ToString + Room
            // Firstname + Lastname... + Room
            // base viittaa yliluokkaan eli tässä tapauksessa Person - luokkaan 
            return base.ToString() + " " + Room;
        }

    }
}
