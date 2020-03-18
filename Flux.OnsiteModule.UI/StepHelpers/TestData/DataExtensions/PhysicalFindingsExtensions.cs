using Flux.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flux.OnsiteModule.UI
{
    public static class PhysicalFindingsExtensions
    {
        public static PhysicalFindingsBuilder PhysicalFindings(this TestDataBuilder testData)
        {
            return new PhysicalFindingsBuilder();
        }

        public static PhysicalFindingsBuilder ALPPHH(this TestDataBuilder testData)
        {
            return new PhysicalFindingsBuilder().ALPPHH();
        }

        public static PhysicalFindingsBuilder TEMPOutofRange(this TestDataBuilder testData)
        {
            return new PhysicalFindingsBuilder().TEMPOutofRange();
        }

        public static PhysicalFindingsBuilder PulseOutofRange(this TestDataBuilder testData)
        {
            return new PhysicalFindingsBuilder().PulseOutofRange();
        }

        public static PhysicalFindingsBuilder HGBOutofRange(this TestDataBuilder testData)
        {
            return new PhysicalFindingsBuilder().HGBOutofRange();
        }


    }
}
