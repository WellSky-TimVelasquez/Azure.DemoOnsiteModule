using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flux.Web;
using TechTalk.SpecFlow;

namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class FindDonorSteps : OnsiteModule_TestBase
    {

        [Given(@"I have entered (.*) (.*) (.*) (.*) and (.*)")]
        public void GivenIHaveEnteredAnd(string ssn, string lastname, string firstname, string dob, string gender)
        {

            Application.NewPage<FindDonor>().FindDonorSuite(ssn, lastname, firstname, dob, gender);
        }

        [Then(@"a (.*) should display at (.*)")]
        public void ThenAShouldDisplayAt(string donorid, string grade)
        {
            Application.NewPage<FindDonor>().VerifyDonorSuite(donorid, grade);
        }


    }
}
