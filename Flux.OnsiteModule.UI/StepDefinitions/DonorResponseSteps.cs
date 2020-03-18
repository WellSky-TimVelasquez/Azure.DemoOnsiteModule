using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class DonorResponseSteps : OnsiteModule_TestBase
    {
        [Then(@"I can open Donor Response")]
        public void ThenICanOpenDonorResponse()
        {
            Application.NewPage<DonorResponse>().OpenDonorResponseScreen();
        }

        [Then(@"I can complete Donor Response with expected answers")]
        public void ThenICanCompleteDonorResponseWithExpectedAnswers()
        {
            Application.NewPage<DonorResponse>().CompleteDRExpectedAnswers();
        }

        [Then(@"the Donor Response statistics block is updated as complete")]
        public void ThenTheDonorResponseStatisticsBlockIsUpdatedAsComplete()
        {
            Application.NewPage<DonorResponse>().ConfirmDonorResponseStatisticsBlockPassed();
        }

        [Then(@"I can complete Donor Response with expected answers in Spanish")]
        public void ThenICanCompleteDonorResponseWithExpectedAnswersInSpanish()
        {
            Application.NewPage<DonorResponse>().CompleteDRExpectedAnswersForeignLanguage("Spanish");
        }

        [Then(@"I can complete Donor Response with an exception")]
        public void ThenICanCompleteDonorResponseWithAnException()
        {
            Application.NewPage<DonorResponse>().CompleteDRwithException();
        }

        [Then(@"I can complete Donor Response with an updated answer")]
        public void ThenICanCompleteDonorResponseWithAnUpdatedAnswer()
        {
            Application.NewPage<DonorResponse>().UpdateDRAnswer();
        }

        [Then(@"I complete updated Health History questions with no exceptions")]
        public void ThenICompleteUpdatedHealthHistoryQuestionsWithNoExceptions()
        {
            Application.NewPage<HealthHistory>().Addcommenttochangedanswer();
        }

        [Then(@"I complete the Health History Summary page with Change")]
        public void ThenICompleteTheHealthHistorySummaryPageWithChange()
        {
            Application.NewPage<HealthHistory>().CompleteSummarywithchange();
        }

        [Then(@"I can complete Donor Response with a skipped answer")]
        public void ThenICanCompleteDonorResponseWithASkippedAnswer()
        {
            Application.NewPage<DonorResponse>().SkippedDRAnswer();
        }

        [Then(@"I can complete Donor Response with expected answers in German")]
        public void ThenICanCompleteDonorResponseWithExpectedAnswersInGerman()
        {
            Application.NewPage<DonorResponse>().CompleteDRExpectedAnswersForeignLanguage("German");
        }

        [Then(@"I can complete Donor Response with expected answers in French")]
        public void ThenICanCompleteDonorResponseWithExpectedAnswersInFrench()
        {
            Application.NewPage<DonorResponse>().CompleteDRExpectedAnswersForeignLanguage("French");
        }

    }
}
