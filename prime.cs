﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class PrimeMethod
    {
        static bool isPrimeNumber(int n)
        {
            bool isprime = true;

            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    isprime = false;
                }
            }
            if (isprime)
            {
                Console.WriteLine("number is prime ");
            }
            else
            {
                Console.WriteLine("number is not prime");
            }
            return true;
        }
        static void Main(string[] args)
        {

            isPrimeNumber(10);
        }
    }
}
