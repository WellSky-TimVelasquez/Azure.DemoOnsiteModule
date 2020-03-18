using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flux.Core;

namespace Flux.OnsiteModule.UI
{
    public class BleedBuilder : Builder<BleedData, BleedBuilder>
    {
        public BleedBuilder BleedPP()
        {
            With(x => x.RBCLOSS = "50");
            With(x => x.PLASMALOSS = "400");
            return this;
        }

        public BleedBuilder BleedDP()
        {
            With(x => x.RBCLOSS = "50");
            With(x => x.PLASMALOSS = "400");
            return this;
        }

        public BleedBuilder BleedPL()
        {
            With(x => x.RBCLOSS = "50");
            With(x => x.PLASMALOSS = "400");
            return this;
        }



    }
}
