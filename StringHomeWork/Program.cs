using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------1-------------------
            string sometext="Nikolay have one good friend, he's name Nikolay";
            Console.WriteLine(sometext);
            string newtext=sometext.Replace("Nikolay", "Oleg");
            Console.WriteLine(newtext);
        }
    }
}
