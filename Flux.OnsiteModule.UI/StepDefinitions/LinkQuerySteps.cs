using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class LinkQuerySteps : OnsiteModule_TestBase
    {

        [Given(@"I open the Link Query screen")]
        public void GivenIOpenTheLinkQueryScreen()
        {
            Application.NewPage<LinkQuery>().SelectLinkQueryLink();
        }

        [Then(@"the activated drive is displayed")]
        public void ThenTheActivatedDriveIsDisplayed()
        {
            Application.NewPage<LinkQuery>().VerifyDriveID();
        }

        [Then(@"I update the Drive Id")]
        public void ThenIUpdateTheDriveId()
        {
            Application.NewPage<LinkQuery>().UpdateLinkQueryDriveID();
        }

        [Then(@"the updated Drive Id is displayed")]
        public void ThenTheUpdatedDriveIdIsDisplayed()
        {
            Application.NewPage<LinkQuery>().VerifyUpdatedDriveID();
        }

    }
}
