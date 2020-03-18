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
    class LinkQuery : OnsiteModule_PageBase
    {

        #region PageObjects
        //Link Query
        private readonly By lnkLinkStatusQuery = By.Id("link-unitdeferral-link-status-query");
        private readonly By txtDriveID = By.Id("input-drive-id");
        private readonly string strstatus = "status-dn{0}";
        private readonly By txtStatus = By.Id("select-status");
        private readonly string txtSelectDriveId = "select-drive-id-option-{0}";

        public By GetDonorStatusLocator(string donorid)
        {
            By locator = By.Id(string.Format(strstatus, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDriveIdList(string driveid)
        {
            By locator = By.Id(string.Format(txtSelectDriveId, driveid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }


        #endregion

        public void SelectLinkQueryLink()
        {
            Actions.Click(lnkLinkStatusQuery);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(LINKQUERY);
            Report.LogPassedTest("Link Unit/Deferral Query screen is displayed");
            Report.TakeScreenshot();

        }

        public void VerifyDriveID()
        {
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(txtDriveID);
            Verify.ElementContainsText(txtStatus, "All");

            var selecteddriveid = Actions.ExecuteJavascript<string>("document.getElementById('input-drive-id').value");
            if (selecteddriveid == "DRV" + gblintdrive)
                Report.LogPassedTest("Default Drive ID: DRV" + gblintdrive);
            else
                Report.LogFailedTest("Drive ID: " + selecteddriveid + " does not match logged in drive id: DRV" + gblintdrive);
            Report.TakeScreenshot();


        }

        public void UpdateLinkQueryDriveID()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(txtDriveID);
            Verify.ElementContainsText(txtStatus, "All");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            updateid = DriveidList[(totaldrives-2)];
            Actions.Click(GetDriveIdList(updateid));

            
        }

        public void VerifyUpdatedDriveID()
        {
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(txtDriveID);
            Verify.ElementContainsText(txtStatus, "All");

            var selecteddriveid = Actions.ExecuteJavascript<string>("document.getElementById('input-drive-id').value");
            if (selecteddriveid == updateid)
                Report.LogPassedTest("Default Drive ID: " + updateid);
            else
                Report.LogFailedTest("Drive ID: " + selecteddriveid + " does not match logged in drive id: " + updateid);
            Report.TakeScreenshot();

        }


    }


}

