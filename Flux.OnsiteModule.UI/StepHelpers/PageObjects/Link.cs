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
    class Link : OnsiteModule_PageBase
    {

        #region PageObjects
        //Link
        private readonly By lnkonsitemodulemenu = By.Id("link-link--unlink-unit-or-deferral");
        private readonly By txteligibility = By.Id("label-eligibility");
        private readonly By lnklink = By.Id("button-link-unit");
        private readonly By scanunitid = By.Id("BarcodeUnitId");
        private readonly By btnlink = By.Id("button-link");
        private readonly By btnunlink = By.Id("button-unlink");
        private readonly By txtmessage = By.Id("alert-title");
        private readonly By btnyes = By.Id("multi-button-yes");
        private readonly By btnok = By.Id("multi-button-ok");
        private readonly By selectreason = By.Id("input-choose-reason");
        private readonly By txtcomments = By.Id("input-comments");
        private readonly By selectbadbarcode = By.Id("select-choose-reason-option-BADBC - BAD BARCODE");
        private readonly By linkunlinkdeferraltab = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-link-unit-deferral/div/mat-tab-group/mat-tab-header/div[2]/div/div/div[2]");  
        private readonly By txtdeferralid = By.Id("input-deferral-id");
        private readonly By txtdeferthrudate = By.Id("input-deferral-thru");
        private readonly By lblchapterdate = By.Id("label-chapter-date-time");
        
        //Link Query
        private readonly By lnkLinkStatusQuery = By.Id("link-unitdeferral-link-status-query");
        private readonly string donorselect = "donor-id-dn{0}";
        private readonly string donorunitid = "unit/deferral-dn{0}";

        public By GetDonorLocator(string donorid)
        {
            By locator = By.Id(string.Format(donorselect, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetUnitIdLocator(string donorid)
        {
            By locator = By.Id(string.Format(donorunitid, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        #endregion

        public void OpenLinkFromHHPF()
        {
            Actions.Click(txteligibility);
            for (int i = 0; i < 10; i++)
            {
                Actions.PressKey(Keys.ArrowDown);
            }
            Actions.Click(lnklink);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(LINK);

        }

        public void LinkUnit()
        {
            OnsiteHelper.generateunitid();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(scanunitid);
            CommonActions.SetText(scanunitid, "=" + gblunitdeferralid + "00");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnlink);
            Verify.ElementContainsText(txtmessage, "Are you sure this is the right Unit ID to link ?");
            Report.LogPassedTest("Unit ID entered");
            Report.TakeScreenshot();

            Actions.Click(btnyes);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Verify.ElementContainsText(txtmessage, "Msg: 21004: Unit has been linked successfully with the donor");
            Report.LogPassedTest("Unit ID is saved");
            Report.TakeScreenshot();
            Actions.Click(btnok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


        }

        public void UnitinLinkQuery(String unitdeferralid)
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkLinkStatusQuery);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(GetDonorLocator(OnsiteHelper.txtDonorIDonly));
            if (unitdeferralid != "")
            {
                Verify.ElementContainsText(GetUnitIdLocator(OnsiteHelper.txtDonorIDonly), unitdeferralid);
                Report.LogPassedTest("Unit ID: " + unitdeferralid + " is linked");
                Report.TakeScreenshot();
            }
            else
                
            Actions.Click(lnkonsitemodulemenu);

        }

        public void UnlinkUnit()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(scanunitid);
            if (gblunitdeferralid.Length == 13)
                CommonActions.SetText(scanunitid, "=" + gblunitdeferralid + "00");
            else
                CommonActions.SetText(scanunitid, "c" + gblunitdeferralid + "c");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnunlink);
            Verify.ElementContainsText(txtmessage, "Do you want to continue?");
            Report.LogPassedTest("Unlinking Unit ID");
            Report.TakeScreenshot();

            Actions.Click(btnyes);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Verify.ElementContainsText(txtmessage, "Msg: 21023: Unit Unlinked Successfully");
            Report.LogPassedTest("Unit ID is unlinked");
            Report.TakeScreenshot();
            Actions.Click(btnok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


        }

        public void NoUnitinLinkQuery(String unitdeferralid)
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkLinkStatusQuery);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(GetDonorLocator(OnsiteHelper.txtDonorIDonly));
            Verify.ElementDoesNotContainsText(GetUnitIdLocator(OnsiteHelper.txtDonorIDonly), unitdeferralid);
            Report.LogPassedTest("No Unit ID");
            Report.TakeScreenshot();

            Actions.Click(lnkonsitemodulemenu);

        }

        public void OpenLinkFromMenu()
        {
            Actions.Click(lnkonsitemodulemenu);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void LinkNewUnit()
        {
            string oldunitid = gblunitdeferralid;
            OnsiteHelper.generateunitid();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(scanunitid);
            CommonActions.SetText(scanunitid, "=" + gblunitdeferralid + "00");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnlink);
            Verify.ElementContainsText(txtmessage, "The current Unit ID " + oldunitid + " will be voided.The new Unit ID " + gblunitdeferralid + " will be linked.");
             
            Report.LogPassedTest("Unit ID voided");
            Report.TakeScreenshot();

            Actions.Click(btnyes);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void Voidinformation()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(selectreason);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(selectbadbarcode);
            Actions.PressKey(Keys.Tab, selectbadbarcode);
            CommonActions.SetText(txtcomments, "New Unit ID");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Verify.ElementContainsText(txtmessage, "Msg: 21005: Unit is now voided");
            Report.LogPassedTest("Unit ID voided");
            Report.TakeScreenshot();

            Actions.Click(btnok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void LinkTemporaryDeferral()
        {
            OnsiteHelper.generatedeferralid();
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(30);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtdeferralid, "c" + gblunitdeferralid + "c");
            CommonActions.SetText(txtdeferthrudate, Convert.ToString(txtcurrentchapterdate.ToString("MM/dd/yyyy")));
            CommonActions.SetText(selectreason, "LINK");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnlink);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(txtmessage, "This deferral will be linked to the donation. Do you want to proceed?");
            Report.LogPassedTest("Deferral ID is going to be linked");
            Report.TakeScreenshot();

            Actions.Click(btnyes);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(txtmessage, "Msg: 21030: Donor Registered as Deferral");
            Report.LogPassedTest("Deferral ID linked");
            Report.TakeScreenshot();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnok);

        }

        public void OpenLinkUnlinkDeferralTab()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(linkunlinkdeferraltab);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void LinkPermanentDeferral()
        {

            OnsiteHelper.generatedeferralid();

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtdeferralid, "c" + gblunitdeferralid + "c");
            CommonActions.SetText(selectreason, "LINK");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnlink);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(txtmessage, "This deferral will be linked to the donation. Do you want to proceed?");
            Report.LogPassedTest("Deferral ID is going to be linked");
            Report.TakeScreenshot();

            Actions.Click(btnyes);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(txtmessage, "Msg: 21030: Donor Registered as Deferral");
            Report.LogPassedTest("Deferral ID linked");
            Report.TakeScreenshot();
            Actions.Click(btnok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void UnlinkDeferral()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(selectreason, "QA");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnunlink);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(txtmessage, "Err: 21134: Interdictions will not be released when unlinking a deferral");
            Report.LogPassedTest("Deferral ID is going to be unlinked");
            Report.TakeScreenshot();

            Actions.Click(btnyes);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(txtmessage, "Msg: 21114: Deferral Unlinked successfully");
            Report.LogPassedTest("Deferral ID unlinked");
            Report.TakeScreenshot();
            Actions.Click(btnok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }


    }


}

