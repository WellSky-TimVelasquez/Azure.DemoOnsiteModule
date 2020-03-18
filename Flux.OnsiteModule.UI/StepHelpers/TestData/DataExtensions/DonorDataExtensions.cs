using Flux.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flux.OnsiteModule.UI
{
    public static class DonorDataExtensions
    {
        public static DonorBuilder Donor(this TestDataBuilder testData)
        {
            return new DonorBuilder();
        }

        public static DonorBuilder ALPP(this TestDataBuilder testData)
        {
            return new DonorBuilder().ALPP();
        }

        public static DonorBuilder ALPPAMIC(this TestDataBuilder testData)
        {
            return new DonorBuilder().ALPPAMIC();
        }

        public static DonorBuilder AUWB(this TestDataBuilder testData)
        {
            return new DonorBuilder().AUWB();
        }

        public static DonorBuilder DIWB(this TestDataBuilder testData)
        {
            return new DonorBuilder().DIWB();
        }

        public static DonorBuilder PrefMobile(this TestDataBuilder testData)
        {
            return new DonorBuilder().PrefMobile();
        }

        public static DonorBuilder UnderAgeLimit(this TestDataBuilder testData)
        {
            return new DonorBuilder().UnderAgeLimit();
        }

        public static DonorBuilder OverAgeLimit(this TestDataBuilder testData)
        {
            return new DonorBuilder().OverAgeLimit();
        }

        public static DonorBuilder DIDR(this TestDataBuilder testData)
        {
            return new DonorBuilder().DIDR();
        }

    }
}
