using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Person;

namespace Project1
{   
   
        class Program
    {
        static void Main(string[] args)
        {
            Class1 a= new Class1();
            a.Name = "Supuni";
            a.Age = 23;
            a.Haspet = true;

            a.greeting();
        }
    }
}
