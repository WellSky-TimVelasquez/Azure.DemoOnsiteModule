using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flux.OnsiteModule.UI//.StepHelpers.PageObjects
{
    class Consent : OnsiteModule_PageBase
    {

        #region PageObjects
        //Consent
        private readonly By lnkconsent = By.Id("donor-consents-start-form");
        private readonly By btnopen = By.Id("consents-button-open-form");
        private readonly By btnok = By.Id("button-ok");
        private readonly string btnclearall = "signature-clear-{0}-button-clear";
        private readonly By btnclear = By.Id("signature-clear-0-button-clear");
        private readonly By btnclear1 = By.Id("signature-clear-1-button-clear");
        private readonly string btnmanualsign = "consents-manual-sign-{0}-button-manual-sign";
        private readonly By btnmanualsign1 = By.Id("consents-manual-sign-1-button-manual-sign");
        private readonly By btnmanualsign0 = By.Id("consents-manual-sign-0-button-manual-sign");


        private readonly By manualsignaturepage = By.Id("confirm-title");
        private readonly By txtusername = By.Id("input-username");
        private readonly By txtdate = By.Id("input-date");
        private readonly By lblchapterdate = By.Id("label-chapter-date-time");
        private readonly By btnsign = By.Id("button-sign");
        private readonly By btnnext = By.Id("consents-signbutton-next-");
        private readonly By completemessage = By.Id("alert-title");
        private readonly By btnmultiok = By.Id("multi-button-ok");
        private readonly string sigblock = "label-signature-legend-{0}";

        private readonly By signatureblock = By.Id("label-signature-legend-0");
        private readonly By signatureblock1 = By.Id("label-signature-legend-1");
        private readonly By btnsaveandclose = By.Id("consents-signbutton-save--close");
        private readonly By statusconsent1 = By.Id("chip-status-0");
        private readonly By statusconsent2 = By.Id("chip-status-1");
        private readonly string statusconsent = "chip-status-{0}";

        private readonly By witnessblock = By.Id("Witness Signature-undefined");
        private readonly By btndeclineconsent2 = By.Id("consents-decline-1-button-decline");
        private readonly By btndeclineconsent1 = By.Id("consents-decline-0-button-decline");
        private readonly By btnclearwitnesssig = By.Id("signature-clear-undefined-button-clear");
        private readonly By lblnexteligibledate = By.Id("label-next-eligible-date");

        //Statistics block
        private readonly By consentstatus = By.Id("donor-consents-status");
        private readonly By consentsignature = By.Id("donor-consents-signature"); 
        private readonly By lasteditedby = By.Id("donor-consents-edited-by");
        private readonly By eligibility = By.Id("label-eligibility");
        private readonly By eligiblereason = By.Id("label-reason");

        public By GetConsentLocator(int count)
        {
            By locator = By.Id(string.Format(btnmanualsign, count));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetConsentStatusLocator(int count)
        {
            By locator = By.Id(string.Format(statusconsent, count));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }
        

        public By GetConsentClearLocator(int count)
        {
            By locator = By.Id(string.Format(btnclearall, count));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }
        

        public By GetConsentSignatureLocator(int count)
        {
            By locator = By.Id(string.Format(sigblock, count));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }
        #endregion

        public void OpenConsentForm()
        {
            Actions.Click(lnkconsent);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(CONSENT);

        }

        public void ManualSignConsent()
        {
            String txtcurrentchapterdate = Actions.GetText(lblchapterdate).Substring(0, 10); ;
            int icounter = 0;
            int iconsent;
            bool isitdisabled;

            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnopen);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            isitdisabled = (Actions.IsDisplayed(completemessage));
             while (!Actions.IsDisplayed(completemessage))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Verify.ElementIsPresent(GetConsentClearLocator(icounter));
                Actions.Click(GetConsentClearLocator(icounter));
                for (int i = 0; i < 15; i++)
                {
                    Actions.PressKey(Keys.ArrowDown);
                }

                Actions.Click(GetConsentLocator(icounter));
                //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Verify.ElementContainsText(manualsignaturepage, "Manual Sign");
                CommonActions.SetText(txtusername, WebEnvironment.AppSettings["AppUserName"]);
                //CommonActions.SetText(txtusername, "EILTOY");
                CommonActions.SetText(txtdate, txtcurrentchapterdate);
                Actions.Click(btnsign);
                //Verify MANUAL is displayed in signature
                Verify.ElementContainsText(GetConsentSignatureLocator(icounter), "MANUAL");

                Report.LogPassedTest("Consent " + icounter + " is completed manually");
                Report.TakeScreenshot();
                //Consent 2 (General Consent for Donation)
                Actions.Click(btnnext);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                icounter++;
                //Verify.ElementIsPresent(btnmanualsign1);
            }
            //Actions.Click(btnmanualsign1);
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Verify.ElementContainsText(manualsignaturepage, "Manual Sign");
            //CommonActions.SetText(txtusername, WebEnvironment.AppSettings["AppUserName"]);
            //CommonActions.SetText(txtdate, txtcurrentchapterdate);
            //Actions.Click(btnsign);
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            ////Verify MANUAL is displayed in signature
            //Verify.ElementContainsText(signatureblock1, "MANUAL");

            //Report.LogPassedTest("Consent 2 is completed manually");
            //Report.TakeScreenshot();

            //Actions.Click(btnnext);
            Verify.ElementContainsText(completemessage, "Please hand the device back to the staff personnel.");
            Report.LogPassedTest("Consent is completed");
            Report.TakeScreenshot();
            Actions.Click(btnmultiok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //VERIFY SIGNED on two consents  
            for (iconsent = 0; iconsent == icounter; iconsent++)
                Verify.ElementContainsText(GetConsentStatusLocator(iconsent), "SIGNED");
            //Verify.ElementContainsText(GetConsentStatusLocator(icounter), "SIGNED");
            Report.LogPassedTest("Consents have a status of signed");
            Report.TakeScreenshot();

            Actions.Click(btnsaveandclose);

        }

        public void ConfirmConsentStatisticsBlockPassed()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //var consentrequired = Actions.ExecuteJavascript<string>("document.getElementById('donor-consents-status').value");
            var consentrequired = Actions.GetText(consentstatus);

            if (consentrequired == "COMPLETE")
                Verify.ElementContainsText(consentstatus, "COMPLETE");
            else
                Verify.ElementContainsText(consentstatus, "N/A");
            Verify.ElementContainsText(consentsignature, "SIGNED");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "YES");
            Verify.ElementContainsText(eligiblereason, "Donor Eligible");

            Report.LogPassedTest("Consent statistics block is complete");
            Report.TakeScreenshot();

        }

        public void ManualSignConsentOne()
        {
            String txtcurrentchapterdate = Actions.GetText(lblchapterdate).Substring(0, 10); ;

            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnopen);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnclear);
            Actions.Click(btnclear);
            for (int i = 0; i < 15; i++)
            {
                Actions.PressKey(Keys.ArrowDown);
            }


            Actions.Click(btnmanualsign0);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(manualsignaturepage, "Manual Sign");
            CommonActions.SetText(txtusername, WebEnvironment.AppSettings["AppUserName"]);
            CommonActions.SetText(txtdate, txtcurrentchapterdate);
            Actions.Click(btnsign);
            //Verify MANUAL is displayed in signature
            Verify.ElementContainsText(signatureblock, "MANUAL");
            Report.LogPassedTest("Consent 1 is completed manually");
            Report.TakeScreenshot();

            //VERIFY SIGNED on consent one
            Verify.ElementContainsText(statusconsent1, "SIGNED");
            Report.LogPassedTest("Consents have a status of signed");
            Report.TakeScreenshot();

        }

        public void DeclineConsentTwo()
        {
            //Consent 2 (General Consent for Donation)
            Actions.Click(btnnext);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Verify.ElementIsPresent(btndeclineconsent2);

            Actions.Click(btndeclineconsent2);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(completemessage, "Are you sure you want to decline this consent?");
            Report.LogPassedTest("Decline message is displayed");
            Report.TakeScreenshot();

            Actions.Click(btnmultiok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Verify MANUAL is displayed in signature
            Verify.ElementContainsText(signatureblock1, "DECLINED");
            Report.LogPassedTest("Consent 2 is declined");
            Report.TakeScreenshot();

            Actions.Click(btnnext);
            Verify.ElementContainsText(completemessage, "Please hand the device back to the staff personnel.");
            Actions.Click(btnmultiok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Witness signature
            Actions.DragAndDrop(witnessblock, btnclearwitnesssig);
            Report.LogPassedTest("Witness signature");
            Report.TakeScreenshot();

            //VERIFY SIGNED on two consents
            //Verify.ElementContainsText(statusconsent1, "SIGNED");
            Verify.ElementContainsText(statusconsent2, "DECLINED");
            Report.LogPassedTest("Consents are completed");
            Report.TakeScreenshot();

            Actions.Click(btnsaveandclose);

        }

        public void ConfirmConsentStatisticsBlockDeclined()
        {
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(1); 

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(consentstatus, "COMPLETE");
            Verify.ElementContainsText(consentsignature, "DECLINED");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "NO");
            Verify.ElementContainsText(eligiblereason, "Donor is temporarily deferred.");

            Verify.ElementContainsText(lblnexteligibledate, "Next Eligible Date: " + txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));

            Report.LogPassedTest("Consent statistics block is complete");
            Report.TakeScreenshot();

        }

        public void DeclineConsentOne()
        {

            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnopen);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnclear);
            Actions.Click(btnclear);
            for (int i = 0; i < 15; i++)
            {
                Actions.PressKey(Keys.ArrowDown);
            }

            Actions.Click(btndeclineconsent1);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(completemessage, "Are you sure you want to decline this consent?");
            Report.LogPassedTest("Decline message is displayed");
            Report.TakeScreenshot();

            Actions.Click(btnmultiok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Verify MANUAL is displayed in signature
            Verify.ElementContainsText(signatureblock, "DECLINED");
            Report.LogPassedTest("Consent 1 is declined");
            Report.TakeScreenshot();


        }



    }


}

