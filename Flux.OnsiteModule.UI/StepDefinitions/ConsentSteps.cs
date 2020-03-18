using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class ConsentSteps : OnsiteModule_TestBase
    {

        [Then(@"I can open Consent")]
        public void ThenICanOpenConsent()
        {
            Application.NewPage<Consent>().OpenConsentForm();
        }

        [Then(@"I manually sign consent one and two")]
        public void ThenIManuallySignConsentOneAndTwo()
        {
            Application.NewPage<Consent>().ManualSignConsent();
        }

        [Then(@"the Consent statistics block is updated as complete")]
        public void ThenTheConsentStatisticsBlockIsUpdatedAsComplete()
        {
            Application.NewPage<Consent>().ConfirmConsentStatisticsBlockPassed();
        }

        [Then(@"I manually sign consent one")]
        public void ThenIManuallySignConsentOne()
        {
            Application.NewPage<Consent>().ManualSignConsentOne();
        }

        [Then(@"I decline consent two")]
        public void ThenIDeclineConsentTwo()
        {
            Application.NewPage<Consent>().DeclineConsentTwo();
        }

        [Then(@"the Consent statistics block status is declined")]
        public void ThenTheConsentStatisticsBlockStatusIsDeclined()
        {
            Application.NewPage<Consent>().ConfirmConsentStatisticsBlockDeclined();
        }

        [Then(@"I decline consent one")]
        public void ThenIDeclineConsentOne()
        {
            Application.NewPage<Consent>().DeclineConsentOne();
        }

    }
}
