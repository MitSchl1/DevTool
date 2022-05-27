using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class NumberConverter
    {

        public string ConvertFromDecimalsystemToBinaersystem(int number)
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

        public string ConvertFromDecimalsystemToTernaersystem(int number)
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
        public string ConvertFromDecimalsystemToQuatenaersystem(int number)
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
        public string ConvertFromDecimalsystemToQuinaersystem(int number)
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
        public string ConvertFromDecimalsystemToSenaersystem(int number)
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
        public string ConvertFromDecimalsystemToSeptenaersystem(int number)
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
        public string ConvertFromDecimalsystemToOktalsystem(int number)
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
        public string ConvertFromDecimalsystemToNonaersystem(int number)
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
