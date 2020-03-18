using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;



namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class DrivesSteps : OnsiteModule_TestBase
    {
        [Given(@"I enter a drive date")]
        public void GivenIEnterADriveDate()
        {
            Application.NewPage<Drives>().OpenActivateDriveScreen();
            Application.NewPage<Drives>().EnterDriveDate();
        }

        [Given(@"I select an available drive")]
        public void GivenISelectAnAvailableDrive()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Select Drive")]
        public void WhenIPressSelectDrive()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I confirm the drive")]
        public void WhenIConfirmTheDrive()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Complete Drive")]
        public void WhenIPressCompleteDrive()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the drive is activated")]
        public void ThenTheDriveIsActivated()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the drive is completed")]
        public void ThenTheDriveIsCompleted()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
