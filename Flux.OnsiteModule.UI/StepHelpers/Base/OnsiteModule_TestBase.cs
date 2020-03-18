using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Flux.OnsiteModule.UI
{
    [Binding]
    public class OnsiteModule_TestBase : BddTestBase
    {

        /// <summary>
        /// This setup runs automatically before each test in the suite.
        /// </summary>
        [BeforeScenario]
        public static void SetupPerTest()
        {

            string browserName = string.Empty;
            try
            {
                browserName = WebEnvironment.AppSettings["BrowserType"].ToLower();
                BddTestBase.Environment.InitializeDriver(browserName);
            }
            catch (Exception e)
            {
                CustomExceptionHandler.CustomException(e, "Error occurred while trying to launch '" + browserName + "'.");
            }
        }
        //[SetUp]
        //public void SetupPerTest()
        //{
        //    string browserName = string.Empty;
        //    string directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //    try
        //    {
        //        browserName = WebEnvironment.AppSettings["BrowserType"].ToLower();
        //        WebEnvironment.InitializeDriver(browserName, directoryPath);
        //    }
        //    catch (Exception e)
        //    {
        //        CustomExceptionHandler.CustomException(e, "Error occurred while trying to launch '" + browserName + "'.");
        //    }
        //}


    }
}
