using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // yliluokan olio
            //Person person = new Person();
            //person.FirstName = "Pete";
            //person.LastName = "Kauppine";
            //person.Address = "kiuru vesi";
            //person.Age = 53;
            //person.PhoneNumber = "123-4567890";
            //Console.WriteLine(person.ToString());

            // create one Student object
            Student student = new Student();
            student.FirstName = "Joonas";
            student.LastName = "Mankinen";
            student.Address = "Essokatu 3";
            student.Age = 22;
            student.PhoneNumber = "123-4567890";
            student.StudentID = "K1554";
            Console.WriteLine(student.ToString());

            // create one Teacher method
            Teacher teacher = new Teacher("Joni","Johtaja","D666");
            teacher.Address = "Hiisikuja 4";
            teacher.Age = 22;
            teacher.PhoneNumber = "666-6666666";
            Console.WriteLine(teacher.ToString());

            // do something methods
            teacher.TeacherMethod();
            student.StudentMethod();

            student.PersonMethod();


        }
    }
}
