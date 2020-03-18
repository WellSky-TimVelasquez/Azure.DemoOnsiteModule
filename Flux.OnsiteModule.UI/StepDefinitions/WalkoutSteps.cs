using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class WalkoutSteps : OnsiteModule_TestBase
    {

        [Given(@"I walkout the donor")]
        public void GivenIWalkoutTheDonor()
        {
            Application.NewPage<Walkout>().DonorWalkout();
        }

        [Then(@"the donor status is Walk in Onsite Status Query")]
        public void ThenTheDonorStatusIsWalkInOnsiteStatusQuery()
        {
            Application.NewPage<Walkout>().OnsiteStatusQueryWalk();
        }

        [Given(@"I put the donor on hold")]
        public void GivenIPutTheDonorOnHold()
        {
            Application.NewPage<Walkout>().DonorHold();
        }

        [Then(@"the donor status is Hold in Onsite Status Query")]
        public void ThenTheDonorStatusIsHoldInOnsiteStatusQuery()
        {
            Application.NewPage<Walkout>().OnsiteStatusQueryHold();
        }

        [Given(@"I navigate to the Walkout screen")]
        public void GivenINavigateToTheWalkoutScreen()
        {
            Application.NewPage <Walkout>().SelectWalkoutLink();
        }

        [Given(@"I select the donor in Walkout screen")]
        public void GivenISelectTheDonorInWalkoutScreen()
        {
            Application.NewPage<HealthHistoryParentForm>().SelectDonor();
        }

        [Then(@"I return the donor to Registration")]
        public void ThenIReturnTheDonorToRegistration()
        {
            Application.NewPage<RegisterDonor>().OpenRegisterDonor();
            Application.NewPage<Login>().OnsiteHelper.FindExistingDonor(OnsiteModule_PageBase.txtDonorIDonly);
            Application.NewPage<Walkout>().SelectDonorRegistration();
            Application.NewPage<Login>().OnsiteHelper.ReturnRegistration();
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();

        }

        [Then(@"I return the donor to Registration after hold")]
        public void ThenIReturnTheDonorToRegistrationAfterHold()
        {
            Application.NewPage<RegisterDonor>().OpenRegisterDonor();
            Application.NewPage<Login>().OnsiteHelper.FindExistingDonor(OnsiteModule_PageBase.txtDonorIDonly);
            Application.NewPage<Walkout>().SelectDonorRegistration();
            Application.NewPage<Login>().OnsiteHelper.ReturnRegistrationfromHold();
            Application.NewPage<RegisterDonor>().SaveandCloseRegistrationfromHold();
        }

        [Then(@"the HH and PF status is updated")]
        public void ThenTheHHAndPFStatusIsUpdated()
        {
            Application.NewPage<PhysicalFindings>().HHPFStatusafterHold();
            
        }

        [Then(@"I complete AL Health History questions with no exceptions after hold")]
        public void ThenICompleteALHealthHistoryQuestionsWithNoExceptionsAfterHold()
        {
            Application.NewPage<HealthHistory>().CompleteHHALNoExceptionsHoldReturn();
            
        }

        [Then(@"Physical Findings is completed after Hold")]
        public void ThenPhysicalFindingsIsCompletedAfterHold()
        {
            Application.NewPage<PhysicalFindings>().ValidALWBPhysicalFindingsafterHold();
            
        }


    }
}
