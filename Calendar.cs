using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class calenderprogram
    {
        static int Y = new int();
        static int M = new int();
        static int[,] calender = new int[6, 7];


        static void Calenderview()
        {
            Console.Write("\n\n");
            Console.WriteLine("Mo Tu We Th Fr Sa Su ");
        }

        static void Calender()
        {
            int days = DateTime.DaysInMonth(Y, M);
            int currentDay = 1;
            for (int i = 0; i < calender.GetLength(0); i++)
            {
                for (int j = 0; j < calender.GetLength(1) && currentDay <= days; j++)
                {
                    if (i == 0 && M > j)
                    {
                        calender[i, j] = 0;
                    }
                    else
                    {
                        calender[i, j] = currentDay;
                        currentDay++;
                    }
                }
            }
        }

        static void Calendersketch()
        {
            for (int i = 0; i < calender.GetLength(0); i++)
            {
                for (int j = 0; j < calender.GetLength(1); j++)
                {
                    if (calender[i, j] > 0)
                    {
                        if (calender[i, j] < 10)
                        {
                            Console.Write(" " + calender[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(calender[i, j] + " ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the month : (january = 1) ");
            M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the year:  ");
            Y = Convert.ToInt32(Console.ReadLine());

            Calenderview();
            Calender();
            Calendersketch();
            Console.ReadLine();
        }

    }
}
