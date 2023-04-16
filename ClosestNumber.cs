using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class ClosestNumber
    {
        public ClosestNumber()
        {
            Console.WriteLine("Default Constructor Invoke");
        }
        public static void FindNumber()
        {
            int c1 =0;
            int c2 = 0;

            Console.WriteLine("Enter the Number");
            int N = Convert.ToInt32(Console.ReadLine());

            int closenumber = N;

            if (N < 0)
            {
                closenumber = -closenumber;
            }
            while (true)
            {
                closenumber--;

                if (FindEvenDigitNumber(closenumber))
                {
                     c1 = closenumber;
                    Console.WriteLine("Below Closest Even Digit Number of the given input is " + c1);
                     break;
                }
            }
            while (true)
            {
                closenumber++;

                if (FindEvenDigitNumber(closenumber))
                {
                     c2 = closenumber;

                    Console.WriteLine("Above Closest Even Digit Number of the given input is " + c2);
                   
                    break;
                }
            }
            var val1 = Math.Abs(c1 - N);
            var val2 = Math.Abs(c2 - N);
            Console.WriteLine("The closest Even digit Number of given input is" + (val1 < val2 ? c1 : c2));
        }

        private static bool FindEvenDigitNumber(int number)
        {
            foreach (char digit in number.ToString())
            {
                int Value = (int)char.GetNumericValue(digit);
                if (Value % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}