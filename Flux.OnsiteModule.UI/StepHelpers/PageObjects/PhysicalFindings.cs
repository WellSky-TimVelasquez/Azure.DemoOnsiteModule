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
    class PhysicalFindings : OnsiteModule_PageBase
    {

        #region PageObjects
        //HH Parent/Login
        private readonly By linkphysicalfindings = By.Id("physical-findings-start-form");
        private readonly By txtusername = By.Id("input-username");
        private readonly By txtpassword = By.Id("input-password");
        private readonly By btnsign = By.Id("button-sign");
        private readonly By btncancel = By.Id("button-cancel");
        private readonly By txttransactionid = By.Id("label-transaction-id");

        //Physical Findings Screen
        private readonly By armckinitial = By.Id("ARMCK-input-initial-value");
        private readonly By armckrepeat = By.Id("ARMCK-input-repeat-value");
        private readonly By bpdiinitial = By.Id("BPDI-input-initial-value");
        private readonly By bpdirepeat = By.Id("BPDI-input-repeat-value");
        private readonly By bpsyinitial = By.Id("BPSY-input-initial-value");
        private readonly By bpsyrepeat = By.Id("BPSY-input-repeat-value");
        private readonly By hctinitial = By.Id("HCT-input-initial-value");
        private readonly By hctrepeat = By.Id("HCT-input-repeat-value");
        private readonly By hgbinitial = By.Id("HGB-input-initial-value");
        private readonly By hgbrepeat = By.Id("HGB-input-repeat-value");
        private readonly By pltctinitial = By.Id("PLTCT-input-initial-value");
        private readonly By pltctrepeat = By.Id("PLTCT-input-repeat-value");
        private readonly By pulseinitial = By.Id("PULSE-input-initial-value");
        private readonly By pulserepeat = By.Id("PULSE-input-repeat-value");
        private readonly By rbcrtinitial = By.Id("RBCRT-input-initial-value");
        private readonly By rbcrtrepeat = By.Id("RBCRT-input-repeat-value");
        private readonly By tbvinitial = By.Id("TBV-input-initial-value");
        private readonly By tbvrepeat = By.Id("TBV-input-repeat-value");
        private readonly By temprinitial = By.Id("TEMPR-input-initial-value");
        private readonly By temprrepeat = By.Id("TEMPR-input-repeat-value");
        private readonly By wbcinitial = By.Id("WBC-input-initial-value");
        private readonly By wbcrepeat = By.Id("WBC-input-repeat-value");
        private readonly By weghtinitial = By.Id("WEGHT-input-initial-value");
        private readonly By weghtrepeat = By.Id("WEGHT-input-repeat-value");
        private readonly By btncompleteform = By.Id("button-complete-form");
        private readonly By btnpending = By.Id("button-pending");
        private readonly By btnclose = By.Id("button-close");
        private readonly By btnverifyok = By.Id("multi-button-ok");
        private readonly By txttempcomment = By.Id("TEMPR-input-comment");
        private readonly By physicalfindingstab = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-physical-findings/mat-tab-group/mat-tab-header/div[2]/div/div/div[3]/div");

        //Equipment Screen
        private readonly By scanrefno = By.Id("input-scan");
        private readonly By inputrefno = By.Id("input-scan-refno");
        private readonly By btnsavequipment = By.Id("button-save-equipment");

        
        //Supply Tab
        private readonly By supplytab = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-physical-findings/mat-tab-group/mat-tab-header/div[2]/div/div/div[2]");
        private readonly By inputcatalog = By.Id("input-scan-catalog");
        private readonly By scancatalog = By.Id("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-physical-findings/mat-tab-group/div/mat-tab-body[2]/div/app-equipment-supply-entry/mat-card/div/app-scan-entry[1]/div/div[1]/app-dynamic-input/form/mat-form-field/div/div[1]/div/input");
        private readonly By scanlot = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-physical-findings/mat-tab-group/div/mat-tab-body[2]/div/app-equipment-supply-entry/mat-card/div/app-scan-entry[2]/div/div[1]/app-dynamic-input/form/mat-form-field/div/div[1]/div/input");
        private readonly By inputlot = By.Id("input-scan-lot");
        private readonly By btnsavesupply = By.Id("button-save-supplies");
        private readonly By btnaddsupply = By.Id("button-add-supplies");
        private readonly By addbandaid = By.Id("input-band-aids-quantity");
        private readonly By lnkaddsupplies = By.Id("link-add-supplies");
        private readonly By addlance = By.Id("input-lancets-quantity");

        //Health History Statistics
        private readonly By healthhistorystatus = By.Id("health-history-status");
        private readonly By hhdeferralstat = By.Id("health-history-deferral");
        private readonly By hhoverridestat = By.Id("health-history-override");
        private readonly By hhlasteditedtime = By.Id("health-history-last-edited");
        private readonly By hhlasteditedby = By.Id("health-history-edited-by");

        //Physical Findings Statistics
        private readonly By physicalfindingsstatus = By.Id("physical-findings-status");
        private readonly By deferralstat = By.Id("physical-findings-deferral");
        private readonly By overridestat = By.Id("physical-findings-override");
        private readonly By lasteditedtime = By.Id("physical-findings-last-edited");
        private readonly By lasteditedby = By.Id("physical-findings-edited-by");

        //Eligibility
        private readonly By eligibility = By.Id("label-eligibility");
        private readonly By eligiblereason = By.Id("label-reason");
        private readonly By lblnexteligibledate = By.Id("label-next-eligible-date");
        private readonly By lblchapterdate = By.Id("label-chapter-date-time");

        //Online Status Query
        private readonly By lnkOnsiteStatusQuery = By.Id("link-onsite-status-query");
        private readonly string strstatus = "status-dn{0}";
        private readonly string onsitequeryoverride = "//*[starts-with(@id, 'registration') and contains(@id, '" + txtDonorIDonly + "')]";
        private readonly By reasonoptions = By.Id("select-reason-option-RSN4 - Restricted donor");
        private readonly By statustitle = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-onsite-status-query/div/mat-card[1]/div/div/app-mat-table/div[1]/table/thead/mat-header-row/th[9]/div/button");
        private readonly By btnnextpage = By.Id("btn-next-page");
        private readonly By lnkonsitemodulemenu = By.Id("link-onsite-module-menu");

        public By GetDonorStatusLocator(string donorid)
        {
            By locator = By.Id(string.Format(strstatus, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }


        #endregion

        #region Getters/Setters
        public string ARMCK
        {
            get => Actions.GetAttributeValue(armckinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(armckinitial, value);
                    GlobalData.Set("ARMCK", value);
                }
            }
        }

        public string BPDI
        {
            get => Actions.GetAttributeValue(bpdiinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(bpdiinitial, value);
                    GlobalData.Set("BPDI", value);
                }
            }
        }

        public string BPSY
        {
            get => Actions.GetAttributeValue(bpsyinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(bpsyinitial, value);
                    GlobalData.Set("BPSY", value);
                }
            }
        }

        public string HCT
        {
            get => Actions.GetAttributeValue(hctinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(hctinitial, value);
                    GlobalData.Set("HCT", value);
                }
            }
        }

        public string HGB
        {
            get => Actions.GetAttributeValue(hgbinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(hgbinitial, value);
                    GlobalData.Set("HGB", value);
                }
            }
        }

        public string PLTCT
        {
            get => Actions.GetAttributeValue(pltctinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(pltctinitial, value);
                    GlobalData.Set("PLTCT", value);
                }
            }
        }

        public string PULSE
        {
            get => Actions.GetAttributeValue(pulseinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(pulseinitial, value);
                    GlobalData.Set("PULSE", value);
                }
            }
        }

        public string RBCRT
        {
            get => Actions.GetAttributeValue(rbcrtinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(rbcrtinitial, value);
                    GlobalData.Set("RBCRT", value);
                }
            }
        }

        public string TBV
        {
            get => Actions.GetAttributeValue(tbvinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(tbvinitial, value);
                    GlobalData.Set("TBV", value);
                }
            }
        }

        public string TEMPR
        {
            get => Actions.GetAttributeValue(temprinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(temprinitial, value);
                    GlobalData.Set("TEMPR", value);
                }
            }
        }

        public string WBC
        {
            get => Actions.GetAttributeValue(wbcinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(wbcinitial, value);
                    GlobalData.Set("WBC", value);
                }
            }
        }

        public string WEGHT
        {
            get => Actions.GetAttributeValue(weghtinitial, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(weghtinitial, value);
                    GlobalData.Set("WEGHT", value);
                }
            }
        }

        #endregion


        public void OpenPhysicalFindingsScreen()
        {

            Waits.WaitForPageLoad();
            Actions.Click(linkphysicalfindings);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(txtusername);
            CommonActions.SetText(txtusername, WebEnvironment.AppSettings["AppUserName"]);
            CommonActions.SetText(txtpassword, WebEnvironment.AppSettings["AppPassword"]);
            Actions.Click(btnsign);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(PHYSICALFINDINGS);
            Report.LogPassedTest("Physical Findings Screen is displayed");
            Report.TakeScreenshot();

        }

        public void ValidALWBPhysicalFindings(PhysicalFindingsData physicalfindingsdata)
        {
            //This is coded for PHYTEMP AL/WB - TMPL000511
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(physicalfindingstab);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            ARMCK = physicalfindingsdata.ARMCK;
            BPSY = physicalfindingsdata.BPSY;
            //ScanID = donor.ScanID;
            BPDI = physicalfindingsdata.BPDI;
            HGB = physicalfindingsdata.HGB;
            Actions.ScrollToElement(weghtinitial);
            PULSE = physicalfindingsdata.PULSE;
            TEMPR = physicalfindingsdata.TEMPR;
            Report.LogPassedTest("AL/WB Physical Findings data entered");
            Report.TakeScreenshot();

        }

        public void PFComplete()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btncompleteform);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.LogPassedTest("Physical Findings complete");
            Report.TakeScreenshot();
            Actions.Click(btnverifyok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


        }

        public void ConfirmStatisticsBlockPassed()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(physicalfindingsstatus, "COMPLETE");
            Verify.ElementContainsText(deferralstat, "NO");
            Verify.ElementContainsText(overridestat, "NO");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "YES");
            Verify.ElementContainsText(eligiblereason, "Donor Eligible");

            Report.LogPassedTest("Physical Findings statistics block is complete");
            Report.TakeScreenshot();


        }

        public void ValidALPPPhysicalFindings(PhysicalFindingsData physicalfindingsdata)
        {
            //This is coded for PHYTEMP AL/PP - TMPL000550

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(physicalfindingstab);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            ARMCK = physicalfindingsdata.ARMCK;
            BPDI = physicalfindingsdata.BPDI;
            BPSY = physicalfindingsdata.BPSY;
            HCT = physicalfindingsdata.HCT;
            Actions.ScrollToElement(hgbinitial);
            HGB = physicalfindingsdata.HGB;
            PLTCT = physicalfindingsdata.PLTCT;
            PULSE = physicalfindingsdata.PULSE;
            Actions.ScrollToElement(weghtinitial);
            RBCRT = physicalfindingsdata.RBCRT;
            TEMPR = physicalfindingsdata.TEMPR;
            WBC = physicalfindingsdata.WBC;
            Report.LogPassedTest("AL/PP Physical Findings data entered");
            Report.TakeScreenshot();

        }

        public void ALWBPhysicalFindingsInitialOutofRangeRepeatinrange(PhysicalFindingsData physicalfindingsdata)
        {

            //This is coded for PHYTEMP AL/WB - TMPL000511
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(physicalfindingstab);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            ARMCK = physicalfindingsdata.ARMCK;
            BPSY = physicalfindingsdata.BPSY;
            //ScanID = donor.ScanID;
            BPDI = physicalfindingsdata.BPDI;
            HGB = physicalfindingsdata.HGB;
            Actions.ScrollToElement(weghtinitial);
            PULSE = physicalfindingsdata.PULSE;
            CommonActions.SetText(pulserepeat, "60");
            TEMPR = physicalfindingsdata.TEMPR;
            Report.LogPassedTest("AL/WB Physical Findings data entered");
            Report.TakeScreenshot();

        }

        public void ALWBPhysicalFindingsInitialOutofRangeRepeatoutofrange(PhysicalFindingsData physicalfindingsdata)
        {

            //This is coded for PHYTEMP AL/WB - TMPL000511
            Actions.Click(physicalfindingstab);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            ARMCK = physicalfindingsdata.ARMCK;
            BPSY = physicalfindingsdata.BPSY;
            //ScanID = donor.ScanID;
            BPDI = physicalfindingsdata.BPDI;
            HGB = physicalfindingsdata.HGB;
            CommonActions.SetText(hgbrepeat, "20.5");
            Actions.ScrollToElement(weghtinitial);
            PULSE = physicalfindingsdata.PULSE;
            TEMPR = physicalfindingsdata.TEMPR;
            Report.LogPassedTest("AL/WB Physical Findings data entered");
            Report.TakeScreenshot();

            Actions.Click(btncompleteform);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


        }

        public void PFDeferredStatistics()
        {
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(2);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(physicalfindingsstatus, "COMPLETE");
            Verify.ElementContainsText(deferralstat, "YES");
            Verify.ElementContainsText(overridestat, "NO");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "NO");
            Verify.ElementContainsText(eligiblereason, "Donor is temporarily deferred.");

            Verify.ElementContainsText(lblnexteligibledate, "Next Eligible Date: " + txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));

            Report.LogPassedTest("Physical Findings statistics block is complete");
            Report.TakeScreenshot();

        }

        public void InvalidPhysicalFindingswithcomment(PhysicalFindingsData physicalfindingsdata)
        {

            //This is coded for PHYTEMP AL/WB - TMPL000511
            Actions.Click(physicalfindingstab);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            ARMCK = physicalfindingsdata.ARMCK;
            BPSY = physicalfindingsdata.BPSY;
            //ScanID = donor.ScanID;
            BPDI = physicalfindingsdata.BPDI;
            HGB = physicalfindingsdata.HGB;
            Actions.ScrollToElement(weghtinitial);
            PULSE = physicalfindingsdata.PULSE;
            TEMPR = physicalfindingsdata.TEMPR;
            CommonActions.SetText(temprrepeat, "99.9");
            CommonActions.SetText(txttempcomment, "Repeat out of range");
            Report.LogPassedTest("AL/WB Physical Findings data entered");
            Report.TakeScreenshot();

            Actions.Click(btncompleteform);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


        }

        public void ConfirmPFStatisticsBlockOverride()
        {
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(2);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(physicalfindingsstatus, "COMPLETE");
            Verify.ElementContainsText(deferralstat, "NO");
            Verify.ElementContainsText(overridestat, "YES");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "NO");
            Verify.ElementContainsText(eligiblereason, "Donor is temporarily deferred.");

            Verify.ElementContainsText(lblnexteligibledate, "Next Eligible Date: " + txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));
            Report.LogPassedTest("Physical Findings statistics block is complete");
            Report.TakeScreenshot();
        }

        public void ValidAUPPPhysicalFindings(PhysicalFindingsData physicalfindingsdata)
        {
            //This is coded for PHYTEMP AU/PP - TMPL000550

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(physicalfindingstab);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            ARMCK = physicalfindingsdata.ARMCK;
            PULSE = physicalfindingsdata.PULSE;
            Report.LogPassedTest("AU/PP Physical Findings data entered");
            Report.TakeScreenshot();

        }

        public void ConfirmPFStatisticsBlockOverrideHold()
        {
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(2);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(physicalfindingsstatus, "COMPLETE");
            Verify.ElementContainsText(deferralstat, "NO");
            Verify.ElementContainsText(overridestat, "YES");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "NO");
            Verify.ElementContainsText(eligiblereason, "Donor is on Hold.");

            Report.LogPassedTest("Physical Findings statistics block is complete");
            Report.TakeScreenshot();
        }

        public void OnsiteStatusQueryDeferred()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkOnsiteStatusQuery);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(ONSITESTATUSQUERY);
            Actions.Click(statustitle);
            Actions.Click(statustitle);
            for (int ipage = 1; ipage < 5; ipage++)
                if (Actions.IsElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Deferred"))
                {
                    Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                    Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Deferred");
                    Verify.ElementContainsText(By.XPath(onsitequeryoverride), ":");
                }
                else
                {
                    Actions.Click(btnnextpage);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                    Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Deferred");
                    Verify.ElementContainsText(By.XPath(onsitequeryoverride), ":");

                }

            Report.LogPassedTest("Donor " + txtDonorID + " has a status of Deferred");

            Report.TakeScreenshot();
            Actions.Click(lnkonsitemodulemenu);

        }

        public void AddEquipment()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.SendKeys(scanrefno, "M");
            CommonActions.SetText(inputrefno, gblbp);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btnsavequipment);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Report.LogPassedTest("Equipment added");
            Report.TakeScreenshot();
            Actions.Click(btnverifyok);
        }

        public void AddSupplies()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(supplytab);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btnaddsupply);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            CommonActions.SetText(addlance, "2");
            Actions.Click(lnkaddsupplies);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btnsavesupply);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.LogPassedTest("Supplies added");
            Report.TakeScreenshot();
            Actions.Click(btnverifyok);
        }

        public void HHPFStatusafterHold()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(physicalfindingsstatus, "IN PROGRESS");
            Verify.ElementContainsText(deferralstat, "NO");
            Verify.ElementContainsText(overridestat, "NO");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "YES");
            Verify.ElementContainsText(eligiblereason, "Donor Eligible");


            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(healthhistorystatus, "IN PROGRESS");
            Verify.ElementContainsText(hhdeferralstat, "NO");
            Verify.ElementContainsText(hhoverridestat, "NO");
            Verify.ElementContainsText(hhlasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());

            Report.LogPassedTest("Physical Findings and Health History statistics block is In Progress");
            Report.TakeScreenshot();

        }

        public void ValidALWBPhysicalFindingsafterHold()
        {
            //This is coded for PHYTEMP AL/WB - TMPL000511
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(physicalfindingstab);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.LogPassedTest("Physical Findings from original donation are displayed");
            Report.TakeScreenshot();
            Actions.ScrollToElement(weghtinitial);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btncompleteform);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.LogPassedTest("Physical Findings complete");
            Report.TakeScreenshot();
            Actions.Click(btnverifyok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            if (gblTransactionID == Actions.GetText(txttransactionid))
            {
                Report.LogPassedTest("Transaction ID: " + gblTransactionID + " matches original entry");
            }
            else
            {
                Report.LogError("Transaction ID: " + Actions.GetText(txttransactionid) + " does not match original entry: " + gblTransactionID);
            }


        }


    }
}