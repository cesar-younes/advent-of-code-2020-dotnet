using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class AOCUtils
    {
        public static List<string> ReadFile(string path)
        {
            List<string> data = new List<string>();
            StreamReader file = new StreamReader(path);
            string line;

            while ((line = file.ReadLine()) != null)
            {
                data.Add(line);
            }

            file.Close();

            return data;
        }
    }
}
