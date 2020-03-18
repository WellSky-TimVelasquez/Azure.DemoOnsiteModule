using Flux.Core;
using Flux.Web;
using System;
using TechTalk.SpecFlow;

namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class DebugFeatureSteps : OnsiteModule_TestBase
    {
        [Given(@"I login to the application")]
        public void GivenILoginToTheApplication()
        {
            String formatgblSSN;
            String testgblSSN;
            testgblSSN = "658552141";
            formatgblSSN = testgblSSN.Substring(0, 3) + "-" + testgblSSN.Substring(3, 2) + "-" + testgblSSN.Substring(5, 4);

            Login login = Application.NewPage<Login>();
            login.LoginAsAdmin(WebEnvironment.AppSettings["AppUserName"], WebEnvironment.AppSettings["AppPassword"]);
        }
        
        [Given(@"I select an Active drive")]
        public void GivenISelectAnActiveDrive()
        {
            Drives drives = Application.NewPage<Drives>();
            drives.OpenActivateDriveScreen();
            drives.EnterDriveDate();
            
        }

        [Given(@"TESTscript")]
        public void GivenTESTscript()
        {
            Application.NewPage<Link>().LinkUnit();
        }



    }
}
