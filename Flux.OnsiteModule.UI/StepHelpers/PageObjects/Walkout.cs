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
    class Walkout : OnsiteModule_PageBase
    {

        #region PageObjects
        //Walkout
        private readonly By lnkDonorWalkout = By.Id("link-donor-walkout");
        private readonly By txtReason = By.Id("input-reason");
        private readonly By btnWalkout = By.Id("button-donor-walkout-");
        private readonly By btnHold = By.Id("button-donor-hold-");
        private readonly By btnOk = By.Id("multi-button-ok");
        private readonly By txtmessage = By.Id("alert-title");
        private readonly By lnkonsitemodulemenu = By.Id("link-onsite-module-menu");
        private readonly string rdodonorselect = "radio-dn{0}";
        private readonly By btnselect = By.Id("button-select");
        private readonly By btnverifyok = By.Id("multi-button-ok");
        private readonly By txttransactionid = By.Id("label-transaction-id");

        //Onsite Status Query
        private readonly By lnkOnsiteStatusQuery = By.Id("link-onsite-status-query");
        private readonly string strstatus = "status-dn{0}";
        private readonly By btnnextpage = By.Id("btn-next-page");
        private readonly By statustitle = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-onsite-status-query/div/mat-card[1]/div/div/app-mat-table/div[1]/table/thead/mat-header-row/th[9]/div/button");


        public By GetDonorStatusLocator(string donorid)
        {
            By locator = By.Id(string.Format(strstatus, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorRadioBtnLocator(string donorid)
        {
            By locator = By.Id(string.Format(rdodonorselect, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        #endregion

        public void SelectWalkoutLink()
        {
            Actions.Click(lnkDonorWalkout);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(WALKOUT);
        }

        public void DonorWalkout()
        {

            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            CommonActions.SetText(txtReason, "DRNWT - Donor does not want to wait");
            Report.TakeScreenshot();

            Actions.Click(btnWalkout);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Waits.WaitForPageLoad();
            Verify.ElementContainsText(txtmessage, "Msg: 8010: TRANSACTION COMMITTED");
            Report.LogPassedTest("Donor " + txtDonorID + " is walked out");
            Report.TakeScreenshot();
            Actions.Click(btnOk);

        }

        public void DonorHold()
        {
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            gblTransactionID = Actions.GetText(txttransactionid);
            CommonActions.SetText(txtReason, "DRNWT - Donor does not want to wait");
            Report.TakeScreenshot();

            Actions.Click(btnHold);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(txtmessage, "Msg: 21090: Donor is put on hold. If the donor comes back repeat mini screening");
            Report.LogPassedTest("Donor " + txtDonorID + " is put on hold");
            Report.TakeScreenshot();
            Actions.Click(btnOk);

        }

        public void OnsiteStatusQueryWalk()
        {
            //txtDonorIDonly = "30122181";
            //txtDonorID = "DN30122182";

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkOnsiteStatusQuery);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(ONSITESTATUSQUERY);
            Actions.Click(statustitle);
            Actions.Click(statustitle);
            if (Actions.IsElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Walk"))
            {
                Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Walk");
            }
            else
            {
                Actions.Click(btnnextpage);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Walk");
            }

            Report.LogPassedTest("Donor " + txtDonorID + " has a status of WALK");

            Report.TakeScreenshot();
            Actions.Click(lnkonsitemodulemenu);

        }

        public void OnsiteStatusQueryHold()
        {

            //txtDonorIDonly = "30122333";
            //txtDonorID = "DN30122333";
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkOnsiteStatusQuery);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(ONSITESTATUSQUERY);
            Actions.Click(statustitle);
            Actions.Click(statustitle);
            if (Actions.IsElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Hold"))
            {
                Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Hold");
            }
            else
            {
                Actions.Click(btnnextpage);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Hold");
            }

            Report.LogPassedTest("Donor " + txtDonorID + " has a status of HOLD");
            Report.TakeScreenshot();
            Actions.Click(lnkonsitemodulemenu);

        }

        public void SelectDonorRegistration()
        {
            //Actions.Click(GetDonorRadioBtnLocator(OnsiteHelper.txtDonorIDonly));
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btnselect);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            if (Actions.IsAlertPresent())
            {
                Verify.ElementContainsText(txtmessage, "Msg: 21076: For your information: This donor walked out and coming back");
                Report.LogPassedTest("Donor " + txtDonorID + " is returning from walkout");
                Report.TakeScreenshot();
                Actions.Click(btnverifyok);
            }

        }


    }
}