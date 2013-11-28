using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagGenerator
{
    public class SerialNumber
    {
        /// <summary>
        /// Produces a unique serian number for the given number
        /// </summary>
        /// <param name="qr_code"></param>
        /// <returns></returns>
        public static string Generate(int qr_code)
        {
            string rawSerial = DecimalToArbitrarySystem(qr_code, 27);

            int checksum = 0;
            foreach (var c in rawSerial)
            {
                checksum += (int) ArbitraryToDecimalSystem(c.ToString(), 27);
            }

            string checksumEncoded = DecimalToArbitrarySystem(checksum, 27);

            string serial = rawSerial + "-" + checksumEncoded;

            // and now add a checksum
            // it's just a sum of all "digits", again encoded with the same function
            // 

            return serial;
        }

        private const string Digits = "123456789ABCDEFHKLMNPRSTWXYZ";

        /// <summary>
        /// Converts the given decimal number to the numeral system with the
        /// specified radix (in the range [2, 36]).
        /// http://www.pvladov.com/2012/05/decimal-to-arbitrary-numeral-system.html
        /// </summary>
        /// <param name="decimalNumber">The number to convert.</param>
        /// <param name="radix">The radix of the destination numeral system
        /// (in the range [2, 27]).</param>
        /// <returns></returns>
        private static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " +
                    Digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }


        /// <summary>
        /// Converts the given number from the numeral system with the specified
        /// radix (in the range [2, 36]) to decimal numeral system.
        /// </summary>
        /// <param name="number">The arbitrary numeral system number to convert.</param>
        /// <param name="radix">The radix of the numeral system the given number
        /// is in (in the range [2, 36]).</param>
        /// <returns></returns>
        public static long ArbitraryToDecimalSystem(string number, int radix)
        {


            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " +
                    Digits.Length.ToString());

            if (String.IsNullOrEmpty(number))
                return 0;

            // Make sure the arbitrary numeral system number is in upper case
            number = number.ToUpperInvariant();

            long result = 0;
            long multiplier = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                char c = number[i];
                if (i == 0 && c == '-')
                {
                    // This is the negative sign symbol
                    result = -result;
                    break;
                }

                int digit = Digits.IndexOf(c);
                if (digit == -1)
                    throw new ArgumentException(
                        "Invalid character in the arbitrary numeral system number",
                        "number");

                result += digit * multiplier;
                multiplier *= radix;
            }

            return result;
        }


    }
}
