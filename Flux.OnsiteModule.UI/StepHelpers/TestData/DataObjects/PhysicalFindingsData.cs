using Flux.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flux.Web;

namespace Flux.OnsiteModule.UI
{
    public class PhysicalFindingsData
    {
        public class PhysicalFindingsBuilder : Builder<PhysicalFindingsData, PhysicalFindingsBuilder> { }

        /// <summary>
        /// Method to create a standard donor with mandatory details filled.
        /// </summary>
        public static string RandomString(int length)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        public static string RandomNum(int length)
        {
            Random rnd = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
        public PhysicalFindingsData()
        {
            var StringUtils = new StringUtils();
            var NumberUtils = new NumberUtils();
            var DateTimeUtils = new DateTimeUtils();

            ARMCK = "ACC";
            BPSY = "120";
            BPDI = "60";
            HGB = "13.2";
            PULSE = "60";
            TEMPR = "98.5";
            WEGHT = "150";
            HCT = "39";
            PLTCT = "200";
            RBCRT = "UNANS";
            WBC = "5";

        }
        
        public string ARMCK { get; set; }
        public string BPSY { get; set; }
        public string BPDI { get; set; }
        public string HGB { get; set; }
        public string PULSE { get; set; }
        public string TEMPR { get; set; }
        public string WEGHT { get; set; }
        public string HCT { get; set; }
        public string PLTCT { get; set; }
        public string RBCRT { get; set; }
        public string WBC { get; set; }
    }
}
