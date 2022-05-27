using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class NumberConverter
    {

        private string convertedNumber = string.Empty;
        private int remainder;

        public string ConvertFromDecimalsystemToBinaersystem(int number)
        {
             convertedNumber = string.Empty;

            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;
        }

        public string ConvertFromDecimalsystemToTernaersystem(int number)
        {
             convertedNumber = string.Empty;

            while (number > 0)
            {
                remainder = number % 3;
                number /= 3;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;
        }
        public string ConvertFromDecimalsystemToQuatenaersystem(int number)
        {
             convertedNumber = string.Empty;

            while (number > 0)
            {
                remainder = number % 4;
                number /= 4;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;
        }
        public string ConvertFromDecimalsystemToQuinaersystem(int number)
        {
             convertedNumber = string.Empty;

            while (number > 0)
            {
                remainder = number % 5;
                number /= 5;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;
        }
        public string ConvertFromDecimalsystemToSenaersystem(int number)
        {
             convertedNumber = string.Empty;

            while (number > 0)
            {
                remainder = number % 6;
                number /= 6;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;
        }
        public string ConvertFromDecimalsystemToSeptenaersystem(int number)
        {
             convertedNumber = string.Empty;

            while (number > 0)
            {
                remainder = number % 7;
                number /= 7;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;
        }
        public string ConvertFromDecimalsystemToOktalsystem(int number)
        {
             convertedNumber = string.Empty;

            while (number > 0)
            {
                remainder = number % 8;
                number /= 8;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;
        }
        public string ConvertFromDecimalsystemToNonaersystem(int number)
        {

            return ConvertFromDecimalsystemtoAnother(number, 9);
        }

        private string ConvertFromDecimalsystemtoAnother(int numberToConvert, int system)
        {
            while (numberToConvert > 0)
            {
                remainder = numberToConvert % system;
                numberToConvert /= system;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;
        }

    }
}
