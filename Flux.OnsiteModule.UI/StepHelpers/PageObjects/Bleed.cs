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
    class Bleed : OnsiteModule_PageBase
    {

        #region PageObjects
        //Bleed
        private readonly By lnkbleed = By.Id("link-bleed-time--phlebotomy-data");
        private readonly By txtbleed = By.Id("BarcodeUnitId");
        private readonly By selectarmcode = By.Id("input-arm-code");
        private readonly string btnclearall = "signature-clear-{0}-button-clear";
        private readonly By txtstarttime = By.Id("input-start-time");
        private readonly By txtstartphlebotomist = By.Id("input-start-phlebotomist");
        private readonly By txtendtime = By.Id("input-end-time");
        private readonly By txtendphlebotomist = By.Id("input-end-phlebotomist");
        private readonly By txtprecount = By.Id("input-pre-count");
        private readonly By txtpostcount = By.Id("input-post-count");
        private readonly By txtrbcloss = By.Id("input-rbc-loss");
        private readonly By txtplasmaloss = By.Id("input-plasma-loss");
        private readonly By txtcue = By.Id("input-cue");
        private readonly By selectvenipuncture = By.Id("input-venipuncture");
        private readonly By selectreaction = By.Id("input-reaction");
        private readonly By txtreviewerid = By.Id("input-reviewer-id");
        private readonly By btnsubmit = By.Id("button-submit");
        private readonly By lblchapterdate = By.Id("label-chapter-date-time");
        private readonly By alertmessage = By.Id("alert-title");
        private readonly By btnok = By.Id("multi-button-ok");
        private readonly By btncancel = By.Id("multi-button-cancel");
        private readonly By tabbleed = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-bleed-time/div/app-bleed-main/mat-tab-group/mat-tab-header/div[2]/div/div/div[3]");
        private readonly By txtprocedure = By.Id("input-procedure");
        private readonly By btnyes = By.Id("multi-button-yes");
        private readonly By txtequipment = By.Id("input-equipment");

        
        //Onsite Status Query
        private readonly By lnkOnsiteStatusQuery = By.Id("link-onsite-status-query");
        private readonly string strstatus = "status-dn{0}";
        private readonly By btnnextpage = By.Id("btn-next-page");
        private readonly By statustitle = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-onsite-status-query/div/mat-card[1]/div/div/app-mat-table/div[1]/table/thead/mat-header-row/th[9]/div/button");
        private readonly By lnkonsitemodulemenu = By.Id("link-onsite-module-menu");

        //Equipment Screen
        private readonly By scanrefno = By.Id("input-scan");
        private readonly By inputrefno = By.Id("input-scan-refno");
        private readonly By btnsavequipment = By.Id("button-save-equipment");
        private readonly By btnverifyok = By.Id("multi-button-ok");


        //Supply Tab
        private readonly By supplytab = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-bleed-time/div/app-bleed-main/mat-tab-group/mat-tab-header/div[2]/div/div/div[2]/div");
        private readonly By inputcatalog = By.Id("input-scan-catalog");
        private readonly By scancatalog = By.Id("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-physical-findings/mat-tab-group/div/mat-tab-body[2]/div/app-equipment-supply-entry/mat-card/div/app-scan-entry[1]/div/div[1]/app-dynamic-input/form/mat-form-field/div/div[1]/div/input");
        private readonly By scanlot = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-physical-findings/mat-tab-group/div/mat-tab-body[2]/div/app-equipment-supply-entry/mat-card/div/app-scan-entry[2]/div/div[1]/app-dynamic-input/form/mat-form-field/div/div[1]/div/input");
        private readonly By inputlot = By.Id("input-scan-lot");
        private readonly By btnsavesupply = By.Id("button-save-supplies");
        private readonly By btnaddsupply = By.Id("button-add-supplies");
        private readonly By addbandaid = By.Id("input-band-aids-quantity");
        private readonly By addbags = By.Id("input-bags-quantity");
        private readonly By lnkaddsupplies = By.Id("link-add-supplies");

        public By GetDonorStatusLocator(string donorid)
        {
            By locator = By.Id(string.Format(strstatus, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        #endregion

        #region Getters/Setters

        public string ARMCODE
        {
            get => Actions.GetAttributeValue(selectarmcode, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(selectarmcode, value);
                    GlobalData.Set("ARMCODE", value);
                }
            }
        }

        public string RBCLOSS
        {
            get => Actions.GetAttributeValue(txtrbcloss, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtrbcloss, value);
                    GlobalData.Set("RBCLOSS", value);
                }
            }
        }

        public string PLASMALOSS
        {
            get => Actions.GetAttributeValue(txtplasmaloss, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtplasmaloss, value);
                    GlobalData.Set("PLASMALOSS", value);
                }
            }
        }

        public string CUE
        {
            get => Actions.GetAttributeValue(txtcue, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtcue, value);
                    GlobalData.Set("CUE", value);
                }
            }
        }

        public string VENIPUNCTURE
        {
            get => Actions.GetAttributeValue(selectvenipuncture, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(selectvenipuncture, value);
                    GlobalData.Set("VENIPUNCTURE", value);
                }
            }
        }

        public string REACTION
        {
            get => Actions.GetAttributeValue(selectreaction, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(selectreaction, value);
                    GlobalData.Set("REACTION", value);
                }
            }
        }
        #endregion

        public void OpenBleedScreen()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkbleed);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtbleed, "=" + gblunitdeferralid + "00");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(BLEED);


        }

        public void BleedEntry(BleedData BleedData)
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(11, 5)).AddHours(-2);
            String bleedtimeentry = txtcurrentchapterdate.ToString("HHmm");
            String bleedendentry = txtcurrentchapterdate.AddMinutes(10).ToString("HHmm");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(tabbleed);

            Actions.ScrollToElement(btnsubmit);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            ARMCODE = BleedData.ARMCODE;
            CommonActions.SetText(txtstarttime, bleedtimeentry);

            if (Actions.IsEnabled(alertmessage))
                Actions.Click(btnok);


            if (gblunitdeferralid.Substring(0, 5) == "W1234")
            {
                CommonActions.SetText(txtstartphlebotomist, WebEnvironment.AppSettings["AppUserName"]);
            }
            else
            {
                CommonActions.SetText(txtstartphlebotomist, WebEnvironment.AppSettings["AppUserName"]);
            }

            CommonActions.SetText(txtendtime, bleedendentry);
            if (Actions.IsEnabled(alertmessage))
                Actions.Click(btnok);


            if (gblunitdeferralid.Substring(1, 5) == "W1234")
            {
                CommonActions.SetText(txtendphlebotomist, WebEnvironment.AppSettings["AppUserName"]);
            }
            else
            {
                CommonActions.SetText(txtendphlebotomist, WebEnvironment.AppSettings["AppUserName"]);
            }
            RBCLOSS = BleedData.RBCLOSS;
            PLASMALOSS = BleedData.PLASMALOSS;
            //CUE = BleedData.CUE;
            VENIPUNCTURE = BleedData.VENIPUNCTURE;
            REACTION = BleedData.REACTION;

            if (gblunitdeferralid.Substring(1, 5) == "W1234")
            {
                CommonActions.SetText(txtreviewerid, WebEnvironment.AppSettings["AppUserName"]);
            }
            else
            {
                CommonActions.SetText(txtreviewerid, WebEnvironment.AppSettings["AppUserName"]);
            }

            CommonActions.SetText(txtbleed, "=" + gblunitdeferralid + "00");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Report.LogPassedTest("Bleed information entered");
            Report.TakeScreenshot();

            Actions.Click(btnsubmit);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void OnsiteStatusQueryBleed()
        {

            //txtDonorIDonly = "30122333";
            //txtDonorID = "DN30122333";
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkOnsiteStatusQuery);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(ONSITESTATUSQUERY);
            Actions.Click(statustitle);
            if (Actions.IsElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Complete"))
            {
                Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Complete");
            }
            else
            {
                Actions.Click(btnnextpage);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Complete");
            }

            Report.LogPassedTest("Donor " + txtDonorID + " has a status of Complete");
            Report.TakeScreenshot();
            Actions.Click(lnkonsitemodulemenu);

        }

        public void BleedEntryALPP(BleedData BleedData)
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(11, 5)).AddHours(-3);
            String bleedtimeentry = txtcurrentchapterdate.ToString("HHmm");
            String bleedendentry = txtcurrentchapterdate.AddMinutes(120).ToString("HHmm");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtbleed, "=" + gblunitdeferralid + "00");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(BLEED);
            Actions.Click(tabbleed);

            Actions.ScrollToElement(btnsubmit);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            ARMCODE = BleedData.ARMCODE;
            CommonActions.SetText(txtstarttime, bleedtimeentry);

            if (Actions.IsEnabled(alertmessage))
                Actions.Click(btnok);


            if (gblunitdeferralid.Substring(0, 5) == "W1234")
            {
                CommonActions.SetText(txtstartphlebotomist, WebEnvironment.AppSettings["AppUserName"]);
            }
            else
            {
                CommonActions.SetText(txtstartphlebotomist, WebEnvironment.AppSettings["AppUserName"]);
            }

            CommonActions.SetText(txtendtime, bleedendentry);
            if (Actions.IsEnabled(alertmessage))
                Actions.Click(btnok);


            if (gblunitdeferralid.Substring(1, 5) == "W1234")
            {
                CommonActions.SetText(txtendphlebotomist, WebEnvironment.AppSettings["AppUserName"]);
            }
            else
            {
                CommonActions.SetText(txtendphlebotomist, WebEnvironment.AppSettings["AppUserName"]);
            }
            RBCLOSS = BleedData.RBCLOSS;
            PLASMALOSS = BleedData.PLASMALOSS;
            //CUE = BleedData.CUE;
            VENIPUNCTURE = BleedData.VENIPUNCTURE;
            REACTION = BleedData.REACTION;

            if (gblunitdeferralid.Substring(1, 5) == "W1234")
            {
                CommonActions.SetText(txtreviewerid, WebEnvironment.AppSettings["AppUserName"]);
            }
            else
            {
                CommonActions.SetText(txtreviewerid, WebEnvironment.AppSettings["AppUserName"]);
            }

            CommonActions.SetText(txtbleed, "=" + gblunitdeferralid + "00");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Report.LogPassedTest("Bleed information entered");
            Report.TakeScreenshot();

            Actions.Click(btnsubmit);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void UpdateProceduretoPP()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtbleed, "=" + gblunitdeferralid + "00");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(BLEED);
            Actions.Click(tabbleed);

            Actions.Click(txtprocedure);
            Actions.SendKeys(txtprocedure, Keys.LeftShift + Keys.Home);
            Actions.SendKeys(txtprocedure, Keys.Delete);
            Actions.SendKeys(txtprocedure, "PP");
            Actions.SendKeys(txtprocedure, Keys.Tab);
            CommonActions.SetText(txtequipment, "AMIC");


            Verify.ElementContainsText(alertmessage, "The Physical Findings is " +
                "complete. " +
                "Are you sure you want to change the procedure? You will lose all information previously entered in Physical Findings " +
                 "and will need to fill out the Physical Findings form again.");
            Report.TakeScreenshot();

            Actions.Click(btnyes);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(PHYSICALFINDINGS);

        }

        public void UpdateProceduretoWB()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtbleed, "=" + gblunitdeferralid + "00");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(BLEED);
            Actions.Click(tabbleed);

            Actions.Click(txtprocedure);
            Actions.SendKeys(txtprocedure, Keys.LeftShift + Keys.Home);
            Actions.SendKeys(txtprocedure, Keys.Delete);
            Actions.SendKeys(txtprocedure, "WB");
            Actions.SendKeys(txtprocedure, Keys.Tab);

            Verify.ElementContainsText(alertmessage, "Msg: 21055: Donor is not eligible for the procedure. Unit will be on HOLD");
            Report.TakeScreenshot();

            Actions.Click(btnyes);
            Actions.SendKeys(txtequipment, Keys.Tab);

            Verify.ElementContainsText(alertmessage, "The Physical Findings is " +
                "complete. " +
                "Are you sure you want to change the procedure? You will lose all information previously entered in Physical Findings " +
                 "and will need to fill out the Physical Findings form again.");
            Report.TakeScreenshot();

            Actions.Click(btnyes);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(PHYSICALFINDINGS);

        }

        public void AddBleedEquipment()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.SendKeys(scanrefno, "M");
            CommonActions.SetText(inputrefno, gblScale);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.TakeScreenshot();
            Actions.Click(btnsavequipment);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Report.LogPassedTest("Equipment added");
            Report.TakeScreenshot();
            Actions.Click(btnverifyok);
        }

        public void AddBleedSupplies()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(supplytab);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btnaddsupply);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            CommonActions.SetText(addbags, "2");
            Actions.Click(lnkaddsupplies);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btnsavesupply);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.LogPassedTest("Supplies added");
            Report.TakeScreenshot();
            Actions.Click(btnverifyok);
        }

        public void Bleedtimeoutofrange(BleedData BleedData)
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            String bleedtimeentry = "01:00";
            String bleedendentry = "01:10";
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(tabbleed);

            Actions.ScrollToElement(btnsubmit);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            ARMCODE = BleedData.ARMCODE;
            CommonActions.SetText(txtstarttime, bleedtimeentry);

            if (Actions.IsEnabled(alertmessage))
            {
                Report.LogPassedTest("Bleed time is out of range for drive");
                Report.TakeScreenshot();
                Verify.ElementContainsText(alertmessage, "Msg: 21066: Bleed time is out of start/end time boundaries for the drive");
                Actions.Click(btnok);
            }

            CommonActions.SetText(txtstartphlebotomist, WebEnvironment.AppSettings["AppUserName"]);

            CommonActions.SetText(txtendtime, bleedendentry);
            if (Actions.IsEnabled(alertmessage))
            {
                Report.LogPassedTest("Bleed time is out of range for drive");
                Report.TakeScreenshot();
                Verify.ElementContainsText(alertmessage, "Msg: 21066: Bleed time is out of start/end time boundaries for the drive");
                Actions.Click(btnok);
            }

            CommonActions.SetText(txtendphlebotomist, WebEnvironment.AppSettings["AppUserName"]);
            RBCLOSS = BleedData.RBCLOSS;
            PLASMALOSS = BleedData.PLASMALOSS;
            //CUE = BleedData.CUE;
            VENIPUNCTURE = BleedData.VENIPUNCTURE;
            REACTION = BleedData.REACTION;

            CommonActions.SetText(txtreviewerid, WebEnvironment.AppSettings["AppUserName"]);

            CommonActions.SetText(txtbleed, "=" + gblunitdeferralid + "00");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Report.LogPassedTest("Bleed information entered");
            Report.TakeScreenshot();

            Actions.Click(btnsubmit);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }


    }


}

