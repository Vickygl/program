using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class Sumofevandandodds
    {
        static void Main()
        {
            sumofevenandodd();
        }
        static void sumofevenandodd()
        {
            int everesult = 0;
            int oddresult = 0;
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the number{i + 1}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int j in arr)
            {
                if (j % 2 == 0)
                {
                    everesult = j + everesult;
                }
                else
                {
                    oddresult = j + oddresult;
                }
            }
            Console.WriteLine($"Even result is {everesult} and {oddresult}");
        }
    }
}