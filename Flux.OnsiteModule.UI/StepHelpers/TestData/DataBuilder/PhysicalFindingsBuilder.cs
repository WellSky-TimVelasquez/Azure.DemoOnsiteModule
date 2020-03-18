using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flux.Core;

namespace Flux.OnsiteModule.UI
{
    public class PhysicalFindingsBuilder : Builder<PhysicalFindingsData, PhysicalFindingsBuilder>
    {
        public PhysicalFindingsBuilder TEMPOutofRange()
        {
            With(x => x.TEMPR = "99.9");
            return this;
        }

        public PhysicalFindingsBuilder PulseOutofRange()
        {
            With(x => x.PULSE = "120");
            return this;
        }

        public PhysicalFindingsBuilder HGBOutofRange()
        {
            With(x => x.HGB = "20.5");
            return this;
        }

        public PhysicalFindingsBuilder ALPPHH()
        {
            With(x => x.TEMPR = "99");
            With(x => x.HGB = "15");
            return this;
        }

    }
}
