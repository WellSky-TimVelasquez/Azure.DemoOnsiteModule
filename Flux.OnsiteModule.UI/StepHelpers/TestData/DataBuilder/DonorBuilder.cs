using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flux.Core;

namespace Flux.OnsiteModule.UI
{
    public class DonorBuilder : Builder<Donor, DonorBuilder>
    {
        public DonorBuilder ALPP()
        {
            With(x => x.DonationType = "AL");
            With(x => x.ProcedureCode = "PP");
            return this;
        }
        public DonorBuilder AUWB()
        {
            With(x => x.DonationType = "AU");
            With(x => x.ProcedureCode = "WB");
            return this;
        }

        public DonorBuilder DIWB()
        {
            With(x => x.DonationType = "DI");
            With(x => x.ProcedureCode = "WB");
            return this;
        }

        public DonorBuilder ALPPAMIC()
        {
            With(x => x.DonationType = "AL");
            With(x => x.ProcedureCode = "PP");
            With(x => x.Equipment = "AMIC");
            return this;
        }

        public DonorBuilder PrefMobile()
        {
            With(x => x.PrefMobilePhone = "Y");
            With(x => x.MobilePhone = "3035521147");
            return this;
        }

        public DonorBuilder UnderAgeLimit()
        {
            With(x => x.DateOfBirth = "03152010");
            return this;
        }

        public DonorBuilder OverAgeLimit()
        {
            With(x => x.DateOfBirth = "03201930");
            return this;
        }

        public DonorBuilder DIDR()
        {
            With(x => x.DonationType = "DI");
            With(x => x.ProcedureCode = "DR");
            return this;
        }

    }
}
