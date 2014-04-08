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
        /// Produces a unique serial number for the given number
        /// </summary>
        /// <param name="qr_code"></param>
        /// <returns></returns>
        public static string Generate(UInt32 qr_code, UInt32 algorithmVersion)
        {
            string rawSerial = DecimalToArbitrarySystem(qr_code, 27);
            int luhnChecksum = luhn_getControlDigit(qr_code);

            string serial = "v" + algorithmVersion.ToString() + "-" + rawSerial + luhnChecksum.ToString();

            return serial;
        }


        // Implementation followint Wikipedia's description
        // We use it for UInt32, but because we add a digit we multiply by 10, so the argument is UInt64
        public static int luhn_checksum(UInt64 number)
        {
            int[] luhnEvenValues = new int[] { 0, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
            char[] digitChars = number.ToString().ToCharArray();
            int[] digits = new int[digitChars.Length];
            for (int i = 0; i < digitChars.Length; ++i)
                digits[i] = (int) Char.GetNumericValue(digitChars[i]);

            int checksum = 0;
            for (int posFromEnd=1; posFromEnd <= digits.Length; ++posFromEnd)
            {
                if ((posFromEnd % 2) == 0)
                    checksum += luhnEvenValues[digits[digits.Length - posFromEnd]];
                else
                    checksum += digits[digits.Length - posFromEnd];
            }

            return checksum % 10;
        }

        public static int luhn_getControlDigit(UInt32 number)
        {
            int check_digit = luhn_checksum(10 * (UInt64) number);
            return (check_digit == 0) ? 0 : 10 - check_digit;
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
