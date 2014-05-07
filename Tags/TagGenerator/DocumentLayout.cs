using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagGenerator
{
    class DocumentLayout
    {
        Dictionary<string, string> dict;

        public DocumentLayout()
        {
            dict = new Dictionary<string, string>();
        }

        public void readFromFile(string fname)
        {
            IEnumerable<string> fileReader = null;
            try
            {
                fileReader = File.ReadLines(fname);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    String.Format("File '{0}' can't be open.", fname) +
                    System.Environment.NewLine +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            foreach (string line in fileReader)
            {
                if (line.StartsWith("//"))
                    continue;

                string[] parts = line.Split('=');

                if (parts.Length != 2)
                    continue;

                dict[parts[0]] = parts[1];
            }
        }

        public int getInt(string key)
        {
            return Convert.ToInt32(dict[key], CultureInfo.InvariantCulture);
        }

        public float getFloat(string key)
        {
            return Convert.ToSingle(dict[key], CultureInfo.InvariantCulture);
        }
    }
}
