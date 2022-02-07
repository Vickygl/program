using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class Tables
    {
        static void Main(string[] args)
        {
            multiplier();
        }
            public static void multiplier()
            {
                int b = 1;
                Console.WriteLine("Enter the Number");
                int n = Convert.ToInt32(Console.ReadLine());
                while (b <= 10)
                {
                    //Console.WriteLine(n+"*"+a+"="+(n*a));
                    Console.WriteLine($"{n} * {b} ={n * b }");
                    b++;
                }
            }
            
        }
    }
}
