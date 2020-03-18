using Flux.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flux.OnsiteModule.UI
{
    public static class EquipmentExtensions
    {
        public static EquipmentBuilder Equipment(this TestDataBuilder testData)
        {
            return new EquipmentBuilder();
        }

        //public static EquipmentBuilder BleedPP(this TestDataBuilder testData)
        //{
        //    return new EquipmentBuilder().BleedPP();
        //}




    }
}
