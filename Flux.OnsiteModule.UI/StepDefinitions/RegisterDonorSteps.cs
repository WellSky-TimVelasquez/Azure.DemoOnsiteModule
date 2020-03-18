using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class RegisterDonorSteps : OnsiteModule_TestBase
    {
        
        [Given(@"I register a new donor with AL WB")]
        public void GivenIRegisterANewDonorWithALWB()
        {
            Donor donor = Application.TestDataBuilder.Donor().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonor(donor);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonor(donor);
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();

        }

        [Given(@"I register a new donor with AL PP")]
        public void GivenIRegisterANewDonorWithALPP()
        {
            Donor donor = Application.TestDataBuilder.ALPP().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonor(donor);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonor(donor);
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();

        }

        [Given(@"I register a new donor with AU WB")]
        public void GivenIRegisterANewDonorWithAUWB()
        {
            Donor donor = Application.TestDataBuilder.AUWB().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonor(donor);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonor(donor);
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();

        }

        [Given(@"I register a new donor with DI WB")]
        public void GivenIRegisterANewDonorWithDIWB()
        {
            Donor donor = Application.TestDataBuilder.DIWB().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonor(donor);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonor(donor);
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();

        }

        [Then(@"Donor is registered")]
        public void ThenDonorIsRegistered()
        {
            //Application.NewPage<Login>().OnsiteHelper.ConfirmRegisteredDonor();
            Application.NewPage<HealthHistory>().ConfirmRegisteredDonor();

        }

        [Given(@"I register an existing (.*)(.*) (.*) (.*) (.*) and (.*) with AL WB")]
        public void GivenIRegisterAnExistingWithALWB(string ssn, string lastname, string firstname, string dob, string gender, string donorid)
        {
            //Application.NewPage<Login>().OnsiteHelper.FindExistingDonor(donorid);
            Application.NewPage<Login>().OnsiteHelper.EnterExistingDonorDonTypeProcCode(ssn, lastname, firstname, dob, gender, donorid, "AL", "WB");
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();


        }

        [Given(@"I have entered DN(.*) in find donor")]
        public void GivenIHaveEnteredDNInFindDonor(string donorid)
        {
            Application.NewPage<Login>().OnsiteHelper.FindExistingDonor(donorid);
        }

        [Given(@"I register a new donor with Mobile Preferred phone number")]
        public void GivenIRegisterANewDonorWithMobilePreferredPhoneNumber()
        {
            Donor donor = Application.TestDataBuilder.PrefMobile().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonor(donor);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonor(donor);
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();

        }

        [Then(@"Donor is registered with preferred phone number")]
        public void ThenDonorIsRegisteredWithPreferredPhoneNumber()
        {
            Application.NewPage<RegisterDonor>().ConfirmPrefMobilePhone();
        }

        [Given(@"I register a new donor Over Age Limit")]
        public void GivenIRegisterANewDonorOverAgeLimit()
        {
            Donor donor = Application.TestDataBuilder.OverAgeLimit().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonor(donor);

        }

        [Then(@"the donor can be registered")]
        public void ThenTheDonorCanBeRegistered()
        {
            Donor donor = Application.TestDataBuilder.OverAgeLimit().Create();
            Application.NewPage<Login>().OnsiteHelper.EnteroutofrangeageDonor(donor);
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();

        }

        [Given(@"I register a new donor Under Age Limit")]
        public void GivenIRegisterANewDonorUnderAgeLimit()
        {
            Donor donor = Application.TestDataBuilder.UnderAgeLimit().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonor(donor);
        }

        [Given(@"Over error message is displayed")]
        public void GivenOverErrorMessageIsDisplayed()
        {
            Application.NewPage<RegisterDonor>().RegisterDonorOverAge("over");

        }

        [Given(@"Under error message is displayed")]
        public void GivenUnderErrorMessageIsDisplayed()
        {
            Application.NewPage<RegisterDonor>().RegisterDonorOverAge("under");

        }

        [Then(@"Donor is registered with (.*) (.*) (.*) (.*) (.*) (.*) and (.*) information")]
        public void ThenDonorIsRegisteredWithAndInformation(string address, string city, string state, string zipcode, string abo, string cmv, string gallon)
        {
            Application.NewPage<HealthHistory>().ConfirmRegisteredDonor();
            Application.NewPage<RegisterDonor>().ConfirmReturningDonor(address, city, state, zipcode, abo, cmv, gallon);
        }

        [Then(@"the donor is displayed in Online Status Query")]
        public void ThenTheDonorIsDisplayedInOnlineStatusQuery()
        {
            Application.NewPage<RegisterDonor>().OnlineStatusQueryDisplay();
        }

        [Then(@"the donor is displayed in Link Query")]
        public void ThenTheDonorIsDisplayedInLinkQuery()
        {
            Application.NewPage<Link>().UnitinLinkQuery(OnsiteModule_PageBase.gblunitdeferralid);
        }


        [Given(@"enter donor inquiry")]
        public void GivenEnterDonorInquiry()
        {
            Application.NewPage<RegisterDonor>().OpenRegisterDonor();
            Application.NewPage<Login>().OnsiteHelper.FindExistingDonor(OnsiteModule_PageBase.txtDonorIDonly);
            Application.NewPage<RegisterDonor>().SelectDonorUpdate();
            Application.NewPage<RegisterDonor>().EnterReturningDonorforInquiry();
        }

        //[Given(@"defer the donor with (.*)")]
        //public void GivenDeferTheDonorWith(string deferralid)
        //{
        //    Application.NewPage<RegisterDonor>().EnterDeferralID();
        //    Application.NewPage<RegisterDonor>().SaveandCloseDeferral();

        //}

        [Given(@"defer the donor")]
        public void GivenDeferTheDonor()
        {
            Application.NewPage<RegisterDonor>().EnterDeferralID();
            Application.NewPage<RegisterDonor>().SaveandCloseDeferral();
        }


        [Given(@"override the donor")]
        public void GivenOverrideTheDonor()
        {
            Application.NewPage<RegisterDonor>().OverrideDonor();
            Application.NewPage<RegisterDonor>().SaveandCloseOverride();

        }

        [Given(@"I enter an existing (.*) (.*) (.*) (.*) (.*) and (.*) with AL WB")]
        public void GivenIEnterAnExistingAndWithALWB(string ssn, string lastname, string firstname, string dob, string gender, string donorid)
        {
                Application.NewPage<Login>().OnsiteHelper.ReturnRegistrationNoSave(ssn, lastname, firstname, dob, gender, donorid);
        }

        [Then(@"the eligibility is temporarily deferred")]
        public void ThenTheEligibilityIsTemporarilyDeferred()
        {
            Application.NewPage<RegisterDonor>().EligibilityConfirmation("Temporary");

        }

        [Then(@"the eligibility is permanently deferred")]
        public void ThenTheEligibilityIsPermanentlyDeferred()
        {
            Application.NewPage<RegisterDonor>().EligibilityConfirmation("Permanent");
        }

        [Then(@"I update the registration information")]
        public void ThenIUpdateTheRegistrationInformation()
        {
            Application.NewPage<RegisterDonor>().SelectDonorUpdate();
            Application.NewPage<Login>().OnsiteHelper.UpdateDonorAddress();
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();
            
        }

        [Then(@"Donor information is udpated")]
        public void ThenDonorInformationIsUdpated()
        {
            Application.NewPage<RegisterDonor>().SelectDonorUpdate();
            Application.NewPage<RegisterDonor>().VerifyUpdateDonorInformation();

        }

        [Given(@"I register a new donor with AL WB and (.*) (.*) (.*) (.*)")]
        public void GivenIRegisterANewDonorWithALWBAnd(string firstname, string lastname, string dob, string gender)
        {
            Donor donor = Application.TestDataBuilder.Donor().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonorNameGiven(donor, firstname, lastname, dob, gender);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonorNameGiven(donor, firstname, lastname, dob, gender);
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();
            
        }

        [Given(@"I register a new donor with AL PP and (.*) (.*) (.*) (.*)")]
        public void GivenIRegisterANewDonorWithALPPAnd(string firstname, string lastname, string dob, string gender)
        {
            Donor donor = Application.TestDataBuilder.ALPP().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonorNameGiven(donor, firstname, lastname, dob, gender);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonorNameGiven(donor, firstname, lastname, dob, gender);
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();
        }

        [Given(@"enter donor inquiry with oxygen therapy")]
        public void GivenEnterDonorInquiryWithOxygenTherapy()
        {
            Application.NewPage<RegisterDonor>().OpenRegisterDonor();
            Application.NewPage<Login>().OnsiteHelper.FindExistingDonor(OnsiteModule_PageBase.txtDonorIDonly);
            Application.NewPage<RegisterDonor>().SelectDonorUpdate();
            Application.NewPage<RegisterDonor>().EnterReturningDonorforInquiryDI();
        }

        [Given(@"I register a new donor with DI WB and (.*) (.*) (.*) (.*)")]
        public void GivenIRegisterANewDonorWithDIWBAnd(string firstname, string lastname, string dob, string gender)
        {
            Donor donor = Application.TestDataBuilder.DIWB().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonorNameGiven(donor, firstname, lastname, dob, gender);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonorNameGiven(donor, firstname, lastname, dob, gender);
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();
        }

        [Given(@"I register a new donor with AL PP AMIC and (.*) (.*) (.*) (.*)")]
        public void GivenIRegisterANewDonorWithALPPAMICAnd(string firstname, string lastname, string dob, string gender)
        {
            Donor donor = Application.TestDataBuilder.ALPPAMIC().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonorNameGiven(donor, firstname, lastname, dob, gender);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonorNameGiven(donor, firstname, lastname, dob, gender);
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();
        }

        [Given(@"I register an existing (.*) (.*) (.*) (.*) (.*) and (.*) with AL PP")]
        public void GivenIRegisterAnExistingAndWithALPP(string ssn, string lastname, string firstname, string dob, string gender, string donorid)
        {
            Application.NewPage<Login>().OnsiteHelper.EnterExistingDonorDonTypeProcCode(ssn, lastname, firstname, dob, gender, donorid, "AL", "PP");
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();
        }

        [Given(@"I register an existing (.*) (.*) (.*) (.*) (.*) and (.*) with AU PP")]
        public void GivenIRegisterAnExistingAndWithAUPP(string ssn, string lastname, string firstname, string dob, string gender, string donorid)
        {
            Application.NewPage<Login>().OnsiteHelper.EnterExistingDonorDonTypeProcCode(ssn, lastname, firstname, dob, gender, donorid, "AU", "PP");
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();
        }

        [Then(@"the donor is in the Onsite Status Query")]
        public void ThenTheDonorIsInTheOnsiteStatusQuery()
        {
            Application.NewPage<RegisterDonor>().OnsiteStatusQueryRegister();
        }

        [Given(@"I register a new donor with DI DR and (.*) (.*) (.*) (.*)")]
        public void GivenIRegisterANewDonorWithDIDRAnd(string firstname, string lastname, string dob, string gender)
        {
            Donor donor = Application.TestDataBuilder.DIDR().Create();
            Application.NewPage<Login>().OnsiteHelper.FindDonorNameGiven(donor, firstname, lastname, dob, gender);
            Application.NewPage<Login>().OnsiteHelper.EnterNewDonorNameGiven(donor, firstname, lastname, dob, gender);
            Application.NewPage<RegisterDonor>().SaveandCloseRegistration();
        }

    }
}
