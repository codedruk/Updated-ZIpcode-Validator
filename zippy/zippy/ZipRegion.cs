using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zippy
{
    class ZipRegion : ZipCodeValidator
    {
        public void checker(ZipCodeValidator zip, string region, List<string> uList)
        {
            switch (region)
            {
                case "United States":
                    zip = new USZip();
                    zip.init();
                    zip.IsZipCode(uList);
                    break;

                case "United Kingdom":
                    zip = new UKZip();
                    zip.init();
                    zip.IsZipCode(uList);
                    break;

                case "Canada":
                    zip = new CAZip();
                    zip.init();
                    zip.IsZipCode(uList);
                    break;
                default:
                    Console.WriteLine("Country Not Found!");
                    break;
            }
        }

        public override void init()
        {
            throw new NotImplementedException();
        }
    }
}
