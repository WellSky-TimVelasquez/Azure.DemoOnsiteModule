using Flux.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flux.Web;

namespace Flux.OnsiteModule.UI
{
    public class EquipmentData
    {
        public class EquipmentBuilder : Builder<EquipmentData, EquipmentBuilder> { }

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
        public EquipmentData()
        {
            var StringUtils = new StringUtils();
            var NumberUtils = new NumberUtils();
            var DateTimeUtils = new DateTimeUtils();

            OBKALYX = "EQ-000343";
            OBKBP = "EQ-000326";
            OBKAMIC = "EQ-000286";
            OBKHCUE = "EQ-000339";
            OBKSCALE = "EQ-000330";
            OBKTHER = "EQ-000328";
            OBKTRIM = "EQ-000277";
            OBKVIST = "EQ-000338";
            OBK500 = "EQ-000345";
            OBK1000 = "EQ-000346";

            DALALYX = "EQ-000241";
            DALBP = "EQ-000314";
            DALAMIC = "EQ-000308";
            DALHCUE = "EQ-000312";
            DALSCALE = "EQ-000297";
            DALTHER = "EQ-000303";
            DALTRIM = "EQ-000270";
            DALVIST = "EQ-000245";
            DAL500 = "EQ-000324";
            DAL1000 = "EQ-000321";

        }

        public string OBKALYX { get; set; }
        public string OBKBP { get; set; }
        public string OBKAMIC { get; set; }
        public string OBKHCUE { get; set; }
        public string OBKSCALE { get; set; }
        public string OBKTHER { get; set; }
        public string OBKTRIM { get; set; }
        public string OBKVIST { get; set; }
        public string OBK500 { get; set; }
        public string OBK1000 { get; set; }
        public string DALALYX { get; set; }
        public string DALBP { get; set; }
        public string DALAMIC { get; set; }
        public string DALHCUE { get; set; }
        public string DALSCALE { get; set; }
        public string DALTHER { get; set; }
        public string DALTRIM { get; set; }
        public string DALVIST { get; set; }
        public string DAL500 { get; set; }
        public string DAL1000 { get; set; }

    }
}
