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
            /*string  convertedNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;*/
            return ConvertFromDecimalsystemtoAnother(number, 2);

        }

        public string ConvertFromDecimalsystemToTernaersystem(int number)
        {
            /*string convertedNumber = string.Empty;
            int remainder;

            while (number > 0)
            {
                remainder = number % 3;
                number /= 3;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;*/
            return ConvertFromDecimalsystemtoAnother(number, 3);

        }
        public string ConvertFromDecimalsystemToQuatenaersystem(int number)
        {
            /*string convertedNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 4;
                number /= 4;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;*/
            return ConvertFromDecimalsystemtoAnother(number, 4);

        }
        public string ConvertFromDecimalsystemToQuinaersystem(int number)
        {
            /*string convertedNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 5;
                number /= 5;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;*/
            return ConvertFromDecimalsystemtoAnother(number, 5);

        }
        public string ConvertFromDecimalsystemToSenaersystem(int number)
        {
            /*string convertedNumber = string.Empty;
            int remainder;
            while (number > 0)
            {
                remainder = number % 6;
                number /= 6;
                convertedNumber = remainder.ToString() + convertedNumber;
            }
            return convertedNumber;*/
            return ConvertFromDecimalsystemtoAnother(number, 6);

        }
        public string ConvertFromDecimalsystemToSeptenaersystem(int number)
        {
            /* string convertedNumber = string.Empty;
             int remainder;
             while (number > 0)
             {
                 remainder = number % 7;
                 number /= 7;
                 convertedNumber = remainder.ToString() + convertedNumber;
             }
             return convertedNumber;*/
            return ConvertFromDecimalsystemtoAnother(number, 7);

        }
        public string ConvertFromDecimalsystemToOktalsystem(int number)
        {
            /* string convertedNumber = string.Empty;
             int remainder;
             while (number > 0)
             {
                 remainder = number % 8;
                 number /= 8;
                 convertedNumber = remainder.ToString() + convertedNumber;
             }
             return convertedNumber;*/
            return ConvertFromDecimalsystemtoAnother(number, 8);

        }
        public string ConvertFromDecimalsystemToNonaersystem(int number)
        {

            return ConvertFromDecimalsystemtoAnother(number, 9);
        }

        private string ConvertFromDecimalsystemtoAnother(int numberToConvert, int system)
        {
            string convertedNumber = string.Empty;
            int remainder;
           
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
