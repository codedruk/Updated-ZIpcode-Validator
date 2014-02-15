using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace zippy
{
    public abstract class ZipCodeValidator
    {
        protected string pattern = null;
        public abstract void init();

        public virtual void IsZipCode(List<string> UserZipList)
        { 
            if (UserZipList != null)
            {
                Console.WriteLine("INVALID ZIP CODES:\n");

                foreach (string zipCode in UserZipList.Where(zipCode => !Regex.IsMatch(zipCode, pattern)))
                {
                    Console.WriteLine("> " + zipCode);
                }
            }
        }
    }
}
