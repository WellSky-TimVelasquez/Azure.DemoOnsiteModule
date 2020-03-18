using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class HealthHistoryParentFormSteps : OnsiteModule_TestBase
    {
        [Given(@"I navigate to the Health History/Physical screen")]
        public void GivenINavigateToTheHealthHistoryPhysicalScreen()
        {
            Application.NewPage<HealthHistory>().SelectHHPFLink();
        }


        [Then(@"the donor information is displayed")]
        public void ThenTheDonorInformationIsDisplayed()
        {
            Application.NewPage<HealthHistoryParentForm>().HHPFDonorInformation();
        }

        [Given(@"I select the donor in Health History/Physical screen")]
        public void GivenISelectTheDonorInHealthHistoryPhysicalScreen()
        {
            Application.NewPage<HealthHistoryParentForm>().SelectDonor();
        }

        [Then(@"the donor information is displayed in the donor header")]
        public void ThenTheDonorInformationIsDisplayedInTheDonorHeader()
        {
            Application.NewPage<HealthHistoryParentForm>().VerifyDonorHeader();
        }

        [Given(@"I add a comment")]
        public void GivenIAddAComment()
        {
            Application.NewPage<HealthHistoryParentForm>().AddComment();
        }

        [Then(@"the comment is saved")]
        public void ThenTheCommentIsSaved()
        {
            Application.NewPage<HealthHistoryParentForm>().ConfirmComment();
        }

        [Given(@"I press the HH button on registration")]
        public void GivenIPressTheHHButtonOnRegistration()
        {
            Application.NewPage<HealthHistoryParentForm>().HHButton();
        }

        [Then(@"Health History Parent form is displayed")]
        public void ThenHealthHistoryParentFormIsDisplayed()
        {
            Application.NewPage<HealthHistoryParentForm>().HHPFDisplayed();
        }

        [Given(@"I register a new donor with AL WB and don't close registration")]
        public void GivenIRegisterANewDonorWithALWBAndDonTCloseRegistration()
        {
            Donor donor = Application.TestDataBuilder.Donor().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonor(donor);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonor(donor);
        }

        [Then(@"I update Health History for the donor")]
        public void ThenIUpdateHealthHistoryForTheDonor()
        {
            Application.NewPage<HealthHistoryParentForm>().UpdateFeelingWellQuestionHH();
        }

        [Then(@"I can open Health History in supervisor override")]
        public void ThenICanOpenHealthHistoryInSupervisorOverride()
        {
            Application.NewPage<HealthHistoryParentForm>().OpenHealthHistorySupervisormode();
        }

        [Then(@"I can open Physical Findings in supervisor override")]
        public void ThenICanOpenPhysicalFindingsInSupervisorOverride()
        {
            Application.NewPage<HealthHistoryParentForm>().OpenPhysicalFindingsSupervisormode();
            
        }

        [Then(@"I update Physical Findings for the donor")]
        public void ThenIUpdatePhysicalFindingsForTheDonor()
        {
            Application.NewPage<HealthHistoryParentForm>().UpdateHGB();
            
        }

        [Then(@"the donor is in the Onsite Status Query with HHPFConsent")]
        public void ThenTheDonorIsInTheOnsiteStatusQueryWithHHPFConsent()
        {
            Application.NewPage<HealthHistoryParentForm>().OnsiteStatusQueryHHPFConsent();
        }





    }
}
