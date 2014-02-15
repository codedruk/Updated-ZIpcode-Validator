using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zippy
{
    class ReadingFile
    {
        public List<string> readFromTextFile(string fileName)
        {
            List<string> temp = new List<string>();
            
            try
            {
                // Read the file line-wise into List
                using (var streamReader = new StreamReader(fileName))
                {
                    while (!streamReader.EndOfStream)
                    {
                        temp.Add(streamReader.ReadLine());
                    }
                    return temp;
                }
            }
            catch
            {
                Console.WriteLine("*** FILE NOT FOUND! ****");
                return null;
            }
        }
    }
}
