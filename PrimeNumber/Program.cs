using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean value = IsItPrimeNumber(11);

            if (value)
            {
                Console.WriteLine("It is a prime number");
            }
            else
            {
                Console.WriteLine("It is not a prime number");
            }
            Console.ReadLine();
        }


        static Boolean IsItPrimeNumber(int number)
        {
            Boolean check = true;
            for (int i = 2; i < number; i++)
            {


                if (number % i == 0)
                {

                    check = false;
                    break;

                }


            }
            return check;
        }
        
    }
}
