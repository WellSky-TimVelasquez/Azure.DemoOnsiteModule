using Flux.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flux.Web;

namespace Flux.OnsiteModule.UI
{
    public class BleedData
    {
        public class BleedBuilder : Builder<BleedData, BleedBuilder> { }

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
        public BleedData()
        {
            var StringUtils = new StringUtils();
            var NumberUtils = new NumberUtils();
            var DateTimeUtils = new DateTimeUtils();

            ARMCODE = "L1";
            RBCLOSS = "400";
            PLASMALOSS = "50";
            CUE = "&!54123";
            VENIPUNCTURE = "01";
            REACTION = "MI";


        }

        public string ARMCODE { get; set; }
        public string RBCLOSS { get; set; }
        public string PLASMALOSS { get; set; }
        public string CUE { get; set; }
        public string VENIPUNCTURE { get; set; }
        public string REACTION { get; set; }

    }
}
