using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flux.OnsiteModule.UI
{
    [SetUpFixture]
    public class OnsiteModule_OneTimeSetup : WebGlobalSetup
    {
        /// <summary>
        /// This setup runs automatically before the actual test suite starts running.
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetup()
        {

        }

        /// <summary>
        /// This Teardown runs automatically after the actual test suite has completed running.
        /// </summary>
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
        }
    }
}
