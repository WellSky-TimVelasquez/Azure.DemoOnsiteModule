using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class HealthHistorySteps : OnsiteModule_TestBase
    {
        [Given(@"I login the application as a Blood Centers User")]
        public void GivenILoginTheApplicationAsABloodCentersUser()
        {
            Application.NewPage<Login>().LoginAsAdmin(Web.WebEnvironment.AppSettings["AppUserName"], Web.WebEnvironment.AppSettings["AppPassword"]);

        }

        [Given(@"I open Active Drive screen")]
        public void GivenIOpenActiveDriveScreen()
        {
            Application.NewPage<Login>().LoginVerify();
        }

        [Given(@"I activate a drive")]
        public void GivenIActivateADrive()
        {
            Application.NewPage<Login>().OnsiteHelper.SelectDrive();
        }

        [Given(@"I have registered a new donor")]
        public void GivenIHaveRegisteredANewDonor()
        {
            Donor donor = Application.TestDataBuilder.Donor().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonor(donor);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonor(donor);
        }

        [Given(@"I press Health History button on the main menu")]
        public void GivenIPressHealthHistoryButtonOnTheMainMenu()
        {
            Application.NewPage<HealthHistory>().SelectHHPFLink();

        }

        [Then(@"I select the donor")]
        public void ThenISelectTheDonor()
        {
            Donor donor = Application.TestDataBuilder.Donor().Create();
            Application.NewPage<Login>().OnsiteHelper.SelectRegisteredDonor(donor);
        }

        [Then(@"I can open Health History")]
        public void ThenICanOpenHealthHistory()
        {

            Application.NewPage<HealthHistory>().OpenHealthHistoryScreen();

        }

        [Then(@"I complete AL Health History questions with no exceptions")]
        public void ThenICompleteALHealthHistoryQuestionsWithNoExceptions()
        {
            Application.NewPage<HealthHistory>().CompleteHHALNoExceptions();
        }

        [Then(@"I complete the Health History Summary page")]
        public void ThenICompleteTheHealthHistorySummaryPage()
        {
            Application.NewPage<HealthHistory>().CompleteSummary();
        }

        [Then(@"I signoff on the Health History page")]
        public void ThenISignoffOnTheHealthHistoryPage()
        {
            Application.NewPage<HealthHistory>().CompleteSignoff();
        }

        [Then(@"the Health History statistics block is updated as complete")]
        public void ThenTheHealthHistoryStatisticsBlockIsUpdatedAsComplete()
        {
            Application.NewPage<HealthHistory>().ConfirmHHStatisticsBlockPassed();
        }

        [Then(@"I complete AL Health History questions with an latex exception")]
        public void ThenICompleteALHealthHistoryQuestionsWithAnLatexException()
        {
            Application.NewPage<HealthHistory>().CompleteHHLatexException();

        }

        [Then(@"override the donor in Health History")]
        public void ThenOverrideTheDonorInHealthHistory()
        {
            Application.NewPage<RegisterDonor>().OverrideDonor();
        }

        [Then(@"the Health History statistics block is updated with override")]
        public void ThenTheHealthHistoryStatisticsBlockIsUpdatedWithOverride()
        {
            Application.NewPage<HealthHistory>().ConfirmHHStatisticsBlockOverride();
        }

        [Then(@"the Health History statistics block is updated with deferral")]
        public void ThenTheHealthHistoryStatisticsBlockIsUpdatedWithDeferral()
        {
            Application.NewPage<HealthHistory>().ConfirmHHStatisticsBlockDeferral();
        }

        [Then(@"I complete AL Health History questions with an healthy exception")]
        public void ThenICompleteALHealthHistoryQuestionsWithAnHealthyException()
        {
            Application.NewPage<HealthHistory>().CompleteHHHealthException();
        }

        [Then(@"the Health History statistics block is updated with temporary deferral")]
        public void ThenTheHealthHistoryStatisticsBlockIsUpdatedWithTemporaryDeferral()
        {
            Application.NewPage<HealthHistory>().ConfirmHHStatisticsBlockTemporaryDeferral();
        }

        [Then(@"I update Health History questions with no latex exception")]
        public void ThenIUpdateHealthHistoryQuestionsWithNoLatexException()
        {
            Application.NewPage<HealthHistory>().UpdateLatexAnswerinHHtoNoException();
        }

        [Then(@"I complete the Health History Summary page with changed status")]
        public void ThenICompleteTheHealthHistorySummaryPageWithChangedStatus()
        {
            Application.NewPage<HealthHistory>().CompleteSummary();
        }

        [Then(@"I complete AL Health History questions with no exceptions in Spanish")]
        public void ThenICompleteALHealthHistoryQuestionsWithNoExceptionsInSpanish()
        {
            Application.NewPage<HealthHistory>().CompleteHHALNoExceptionsinotherlanguage("Spanish");
        }

        [Then(@"I complete AU Health History questions with no exceptions")]
        public void ThenICompleteAUHealthHistoryQuestionsWithNoExceptions()
        {
            Application.NewPage<HealthHistory>().CompleteHHAUNoExceptions();
        }

        [Then(@"the donor is in the Onsite Status Query with HH")]
        public void ThenTheDonorIsInTheOnsiteStatusQueryWithHH()
        {
            Application.NewPage<HealthHistory>().OnsiteStatusQueryHH();
        }

        [Then(@"I complete Health History questions for skipped answer")]
        public void ThenICompleteHealthHistoryQuestionsForSkippedAnswer()
        {
            Application.NewPage<HealthHistory>().Updateskippedanswer();
        }

        [Then(@"I complete AL Health History questions with no exceptions in German")]
        public void ThenICompleteALHealthHistoryQuestionsWithNoExceptionsInGerman()
        {
            Application.NewPage<HealthHistory>().CompleteHHALNoExceptionsinotherlanguage("German");
        }

        [Then(@"I complete AL Health History questions with no exceptions in French")]
        public void ThenICompleteALHealthHistoryQuestionsWithNoExceptionsInFrench()
        {
            Application.NewPage<HealthHistory>().CompleteHHALNoExceptionsinotherlanguage("French");
        }

        [Then(@"I update Health History questions with skipped answer")]
        public void ThenIUpdateHealthHistoryQuestionsWithSkippedAnswer()
        {
            Application.NewPage<HealthHistory>().Updateskippedanswer();
        }

        [Then(@"I complete AL Health History questions with an fourwayfour exception")]
        public void ThenICompleteALHealthHistoryQuestionsWithAnFourwayfourException()
        {
            Application.NewPage<HealthHistory>().CompleteHHHealthException4Way4();
        }

    }
}
