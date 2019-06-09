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
            Console.WriteLine("----------1----------");
            string sometext="Nikolay have one good friend, he's name Nikolay";
            Console.WriteLine(sometext);
            string newtext=sometext.Replace("Nikolay", "Oleg");
            Console.WriteLine(newtext);
            Console.WriteLine();

            //---------------------2----------------------
            Console.WriteLine("----------2----------");
            string str = "((8+2)*30)";
            int left = 0,right=0;
            Console.WriteLine(str);
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    left++;
                }
                if (str[i] == ')')
                {
                    right++;
                }
            }
            if (left != right)
            {
                Console.WriteLine("Not equal");
            }
            else
            {
                Console.WriteLine("Equal");
            }
            Console.WriteLine();

            //-----------------------3-----------------
            Console.WriteLine("----------3----------");
            string str1 = "Hello my dear friend";
            string str2 = "my cat is a  good litle boy";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            
        }
    }
}
