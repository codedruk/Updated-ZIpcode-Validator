/* Name: Zigmyal Wangchuk
 * Class: CSI 335
 * Assignment: Zip Validator
 * Due Date: 02/13/2014
 * Purpose: Allows the user load a file to check and validate Zipcode based on region [US/CANADA/UK]
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zippy
{
    class Program
    {
        static void Main(string[] args)
        { 
            ZipCodeValidator Validation = null;
            ZipRegion checkRegion = new ZipRegion();
            List<string> holdZip = new List<string>();
            
            string txtZIP = "zipCode.txt";
            string region = System.Globalization.RegionInfo.CurrentRegion.EnglishName;

            ReadingFile toRead = new ReadingFile();
            holdZip = toRead.readFromTextFile(txtZIP);

            checkRegion.checker(Validation, region, holdZip);
          
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
