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
            return qr_code.ToString();
        }
    }
}
