using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class NumberConverter
    {

        public string DecToBin(int number)
        {
            string binNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                binNumber = remainder.ToString() + binNumber;
            }
            return binNumber;
        }

        public string DecToTern(int number)
        {
            string binNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 3;
                number /= 3;
                binNumber = remainder.ToString() + binNumber;
            }
            return binNumber;
        }
        public string DecToQuatern(int number)
        {
            string binNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 4;
                number /= 4;
                binNumber = remainder.ToString() + binNumber;
            }
            return binNumber;
        }
        public string DecToQuin(int number)
        {
            string binNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 5;
                number /= 5;
                binNumber = remainder.ToString() + binNumber;
            }
            return binNumber;
        }
        public string DecToSen(int number)
        {
            string binNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 6;
                number /= 6;
                binNumber = remainder.ToString() + binNumber;
            }
            return binNumber;
        }
        public string DecToSepten(int number)
        {
            string binNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 7;
                number /= 7;
                binNumber = remainder.ToString() + binNumber;
            }
            return binNumber;
        }
        public string DecToOktal(int number)
        {
            string binNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 8;
                number /= 8;
                binNumber = remainder.ToString() + binNumber;
            }
            return binNumber;
        }
        public string DecToNon(int number)
        {
            string binNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 9;
                number /= 9;
                binNumber = remainder.ToString() + binNumber;
            }
            return binNumber;
        }

    }
}
