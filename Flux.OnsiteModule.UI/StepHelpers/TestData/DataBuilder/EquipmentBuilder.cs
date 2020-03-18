using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flux.Core;

namespace Flux.OnsiteModule.UI
{
    public class EquipmentBuilder : Builder<EquipmentData, EquipmentBuilder>
    {
        public EquipmentBuilder BleedPP()
        {
            With(x => x.OBKBP = "EQ-000326");
            With(x => x.OBKSCALE = "EQ-000341");
            return this;
        }




    }
}
