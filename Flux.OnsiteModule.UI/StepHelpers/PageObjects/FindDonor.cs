using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;

namespace Flux.OnsiteModule.UI
{
    class FindDonor : OnsiteModule_PageBase
    {
        #region PageObjects
        //Find Donor
        private readonly By txtlastname = By.Id("input-last-name");
        private readonly By txtfirstname = By.Id("input-first-name");
        private readonly By txtdob = By.Id("input-dob");
        private readonly By selectsex = By.Id("input-sex");
        private readonly By txtdonorid = By.Id("input-donor-id");
        private readonly By txtssn = By.Id("input-ssn");
        private readonly By txtalternatetype = By.Id("input-alternate-type");
        private readonly By txtalternateid = By.Id("input-alternate-id");
        private readonly By btnsearch = By.Id("button-search");
        private readonly string txtdonorreturn = "radio-dgm{0}";
        private readonly By lnklookupregistration = By.Id("link-lookup--registration");
        private readonly By strrtngrade = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/div/div/app-onsite-router/div/div/app-lookup-and-registration/div/app-find-donor/div/div/mat-card/div/app-mat-table/table/tbody/mat-row/td[2]/app-highlighted-text/div");
        private readonly By strrtndnid = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/div/div/app-onsite-router/div/div/app-lookup-and-registration/div/app-find-donor/div/div/mat-card/div/app-mat-table/table/tbody/mat-row/td[3]/app-highlighted-text/div");
        private readonly By btnclear = By.Id("button-clear");
        private readonly By btnnew = By.Id("button-new");
        private readonly By rtndata = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/div/div/app-lookup-and-registration/app-find-donor/div/div/mat-card");


        public By GetDNRRadioBtnLocator(String dnrnum)
        {
            By locator = By.Id(string.Format(txtdonorreturn, dnrnum));
            Report.LogInfo("locator: " + locator);
            return locator;
        }
        #endregion

        //#region Getters/Setters
        //public string LastName
        //{
        //    get => Actions.GetAttributeValue(txtlastname, "value");
        //    set
        //    {
        //        if (!string.IsNullOrEmpty(value.Trim()))
        //        {
        //            CommonActions.SetText(txtlastname, value);
        //            GlobalData.Set("LastName", value);
        //        }
        //    }
        //}

        //public string FirstName
        //{
        //    get => Actions.GetAttributeValue(txtfirstname, "value");
        //    set
        //    {
        //        if (!string.IsNullOrEmpty(value.Trim()))
        //        {
        //            CommonActions.SetText(txtfirstname, value);
        //            GlobalData.Set("FirstName", value);
        //        }
        //    }
        //}

        //public string DateOfBirth
        //{
        //    get => Actions.GetAttributeValue(txtdob, "value");
        //    set
        //    {
        //        if (!string.IsNullOrEmpty(value.Trim()))
        //        {
        //            CommonActions.SetText(txtdob, value);
        //            GlobalData.Set("DateOfBirth", value);
        //        }
        //    }
        //}
        //public string Gender
        //{
        //    get => Actions.GetAttributeValue(selectsex, "value");
        //    set
        //    {
        //        if (!string.IsNullOrEmpty(value.Trim()))
        //        {
        //            CommonActions.SetText(selectsex, value);
        //            GlobalData.Set("Gender", value);
        //        }
        //    }
        //}
        //public string SSN
        //{
        //    get => Actions.GetAttributeValue(txtssn, "value");
        //    set
        //    {
        //        if (!string.IsNullOrEmpty(value.Trim()))
        //        {
        //            CommonActions.SetText(txtssn, value);
        //            GlobalData.Set("SSN", value);
        //        }
        //    }
        //}

        //#endregion

        public void FindDonorSuite(string ssn, string lastname, string firstname, string dob, string gender)
        {
        if (Actions.IsEnabled(txtlastname))
        { 
            CommonActions.SetText(txtlastname, lastname);
            if (Actions.IsTextboxEmpty(txtlastname))
                CommonActions.SetText(txtlastname, lastname);
        }
        if (Actions.IsEnabled(txtfirstname))
        { 
            CommonActions.SetText(txtfirstname, firstname);
            if (Actions.IsTextboxEmpty(txtfirstname))
                CommonActions.SetText(txtfirstname, firstname);
        }
        if (Actions.IsEnabled(txtdob))
        { 
            CommonActions.SetText(txtdob, dob);
            if (Actions.IsTextboxEmpty(txtdob))
                CommonActions.SetText(txtdob, dob);
        }
        if (Actions.IsEnabled(txtdob))
        { 
            Actions.Click(selectsex);
            CommonActions.SetText(selectsex, gender);
            if (Actions.IsTextboxEmpty(selectsex))
                CommonActions.SetText(selectsex, gender);
        }
        if (Actions.IsEnabled(txtssn))
        { 
            CommonActions.SetText(txtssn, ssn);
            if (Actions.IsTextboxEmpty(txtssn))
                CommonActions.SetText(txtssn, ssn);
        }
        Report.LogInfo("Enter Donor: " + firstname + " " + lastname);
        Report.LogInfo("SSN: " + ssn);

        Actions.Click(btnsearch);
        CommonActions.WaitForPageLoad();
        }

        public void VerifyDonorSuite(string donorid, string grade)
        {
            if (donorid != "NONE")
                Waits.WaitForElementToBeVisible(GetDNRRadioBtnLocator(donorid), Core.WaitType.Small);
            else
                Waits.WaitForElementToBeVisible(btnnew, Core.WaitType.Small);
            CommonActions.WaitForPageLoad();
            Report.LogInfo("Donor: DGM" + donorid + " is returned with grade " + grade);
            Report.TakeScreenshot();
            if (donorid != "NONE")
            {
                Verify.ExactTextInElementIs(strrtndnid, "DGM" + donorid);
                Verify.ExactTextInElementIs(strrtngrade, grade);
            }
            else
                Verify.ElementIsNotPresent(rtndata);
            //clear the screen
            Actions.Click(btnclear);
            CommonActions.WaitForPageLoad();
        }

    }
}
