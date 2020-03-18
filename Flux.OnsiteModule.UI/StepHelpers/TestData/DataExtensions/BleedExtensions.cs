using Flux.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flux.OnsiteModule.UI
{
    public static class BleedExtensions
    {
        public static BleedBuilder Bleed(this TestDataBuilder testData)
        {
            return new BleedBuilder();
        }

        public static BleedBuilder BleedPP(this TestDataBuilder testData)
        {
            return new BleedBuilder().BleedPP();
        }

        public static BleedBuilder BleedDP(this TestDataBuilder testData)
        {
            return new BleedBuilder().BleedDP();
        }

        public static BleedBuilder BleedPL(this TestDataBuilder testData)
        {
            return new BleedBuilder().BleedPL();
        }



    }
}
