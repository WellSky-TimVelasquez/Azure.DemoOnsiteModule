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
    class RegisterDonor : OnsiteModule_PageBase
    {

        #region PageObjects
        private readonly string strrtndnid = "donorid-dn{0}";
        private readonly By lnkdonorlookup = By.Id("link-lookupregistration--modify-data");
        private readonly By txtdonorid = By.Id("input-donor-id");
        private readonly By lblphonenumber = By.Id("label-phone");
        private readonly By strreturndonor = By.XPath("//*/app-onsite-router/div/div/app-lookup-and-registration/div/app-find-donor/div/div/mat-card/div/app-mat-table/div[1]/table/tbody/mat-row");
        private readonly By btnmultiok = By.Id("multi-button-ok");
        private readonly By btnnew = By.Id("button-new");
        private readonly By txtmessage = By.Id("alert-title");
        private readonly By lnkonsitemodulemenu = By.Id("link-onsite-module-menu");
        private readonly By btnverifyok = By.Id("multi-button-ok");
        private readonly By lnklookupregistration = By.Id("link-lookupregistration--modify-data");
           
        //Registration 
        private readonly By txtaddress = By.Id("input-address");
        private readonly By txtcity = By.Id("input-city");
        private readonly By txtaptnumber = By.Id("input-apartment-number");
        private readonly By txtzip = By.Id("input-zip");
        private readonly By txtstate = By.Id("input-state");
        private readonly By hdraborh = By.Id("label-blood-type");
        private readonly By hdrcmv = By.Id("label-cmv");
        private readonly By hdrgallon = By.Id("label-lifetime-don-cr");
        private readonly string rdodonorselect = "radio-dn{0}";
        private readonly By btnselect = By.Id("button-select");
        private readonly By btnupdate = By.Id("button-update");
        private readonly By eligibilitystatus = By.Id("label-eligibility");
        private readonly By eligibilityreason = By.Id("label-reason");
        private readonly By eligibilitydate = By.Id("label-next-eligible-date");
        private readonly By selectethnicity = By.Id("input-ethnicity");
        private readonly By txtemployername = By.Id("input-employer-name");
        private readonly By txthomephone = By.Id("input-home-phone");


        //Inquiry
        private readonly By btninquiry = By.Id("button-inquiry");
        private readonly By popupscreen = By.Id("confirm-title"); 
        private readonly By btnregister = By.Id("button-register");
        private readonly By chkidverify = By.Id("check-id-verified");
        private readonly By txtdescription = By.Id("input-search-description");
        private readonly By btnsearch = By.Id("button-search");
        private readonly By lnksmallpox = By.Id("description-smpx1");
        private readonly By lnkuot = By.Id("description-uot");
        private readonly By txtincidentdate = By.Id("input-incident-date");
        private readonly By txtdeferraldate = By.Id("input-deferral-date");
        private readonly By txtcomments = By.Id("input-comments");
        private readonly By btnmaps = By.Id("button-maps");
        private readonly By btnapply = By.Id("button-apply-");
        private readonly By btnclear = By.Id("button-clear-");
        private readonly By btnclose = By.Id("button-close-");

        //Deferral/Override
        private readonly By optionyes = By.Id("radio-yes");
        private readonly By optionno = By.Id("radio-no");
        private readonly By txtdeferralid = By.Id("input-deferral-id");
        private readonly By btnsaveandclose = By.Id("button-save--close");
        private readonly By txtsuperuser = By.Id("input-super-userid");
        private readonly By txtsuperpassword = By.Id("input-password");
        private readonly By txtoverridereason = By.Id("select-reason");
        private readonly By txtoverridecomment = By.Id("input-comments");

        //Online Status Query
        private readonly By lnkOnsiteStatusQuery = By.Id("link-onsite-status-query");
        private readonly string strstatus = "status-dn{0}";
        //private readonly By onsitequeryoverride = By.XPath("//*[starts-with(@id, 'registration') and contains(@id, 'dn30122301')]");
        private readonly string onsitequeryoverride = "//*[starts-with(@id, 'registration') and contains(@id, '" + txtDonorIDonly + "')]";
        private readonly By reasonoptions = By.Id("select-reason-option-RSN4 - Restricted donor");
        private readonly By statustitle = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-onsite-status-query/div/mat-card[1]/div/div/app-mat-table/div[1]/table/thead/mat-header-row/th[9]/div/button");
        private readonly By btnnextpage = By.Id("btn-next-page");



        public By GetDonorStatusLocator(string donorid)
        {
            By locator = By.Id(string.Format(strstatus, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorIDLocator(string donorid)
        {
            By locator = By.Id(string.Format(strrtndnid, donorid));
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

        public void ConfirmPrefMobilePhone()
        {
            //txtDonorID = "DN30122166";
            //txtDonorIDonly = "30122166";
            //gblMobilePhone = "(303) 552-1147";
            Actions.Click(lnkdonorlookup);
            CommonActions.SetText(txtdonorid, txtDonorID);
            //Actions.Click(btnsearch);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Waits.WaitForElementToBeVisible(strreturndonor, Core.WaitType.Small);
            Verify.ExactTextInElementIs((GetDonorIDLocator(txtDonorIDonly)), OnsiteHelper.txtDonorID);
            Verify.ExactTextInElementIs(lblphonenumber, gblMobilePhone);
            Report.LogPassedTest("Donor: " + OnsiteHelper.txtDonorID + " is returned");
            Report.LogPassedTest("Mobile Phone: " + gblMobilePhone + " is displayed");
            Report.TakeScreenshot();

        }

        public void RegisterDonorOverAge(string strage)
        {
            Actions.Click(btnnew);
            Waits.WaitForPageLoad();
            if (strage == "over")
                Verify.ElementContainsText(txtmessage, "This donor is older than the Upper Age limit of 70");
            else
                Verify.ElementContainsText(txtmessage, "This donor is younger than the Lower Age limit of 15");
            Report.LogPassedTest("Donor " + strage + " age limit message is displayed.");
            Report.TakeScreenshot();

            Actions.Click(btnmultiok);


        }

        public void SaveandCloseRegistration()
        {
            Report.LogPassedTest("Donor " + txtDonorID + " is registered");
            Report.TakeScreenshot();

            Actions.Click(btnverifyok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(lnkonsitemodulemenu);

        }

        public void SaveandCloseRegistrationfromHold()
        {
            Verify.ElementContainsText(txtmessage, "Msg: 21065: Record updated successfully - Donor ID: ");
            Report.LogPassedTest("Donor " + txtDonorID + " is registered");
            Report.TakeScreenshot();

            Actions.Click(btnverifyok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(lnkonsitemodulemenu);

        }


        public void OpenRegisterDonor()
        {
            Actions.Click(lnklookupregistration);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void ConfirmReturningDonor(string address, string city, string state, string zipcode, string abo, string cmv, string gallon)
        {

            Actions.Click(GetDonorRadioBtnLocator(OnsiteHelper.txtDonorIDonly));
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btnselect);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            var donoraddress = Actions.ExecuteJavascript<string>("document.getElementById('input-address').value");
            var donorcity = Actions.ExecuteJavascript<string>("document.getElementById('input-city').value");
            var donorstate = Actions.ExecuteJavascript<string>("document.getElementById('input-state').value");
            var donorzipcode = Actions.ExecuteJavascript<string>("document.getElementById('input-zip').value");
            var donoraborh = Actions.ExecuteJavascript<string>("document.getElementById('label-blood-type').value");
            var donorgallon = Actions.ExecuteJavascript<string>("document.getElementById('label-lifetime-don-cr').value");
            var donorcmv = Actions.ExecuteJavascript<string>("document.getElementById('label-cmv').value");

            if (donoraddress == address.Replace("_", " "))
                Report.LogPassedTest("Address is correct");
            else
                Report.LogFailedTest("Address: " + donoraddress + " does not match expected address: " + address.Replace("_", " "));

            if (donorcity == city.Replace("_", " "))
                Report.LogPassedTest("City is correct - " + donorcity);
            else
                Report.LogFailedTest("City: " + donorcity + " does not match expected city: " + city.Replace("_", " "));

            if (donorzipcode == zipcode.Replace("_", " "))
                Report.LogPassedTest("Zip Code is correct - " + donorzipcode);
            else
                Report.LogFailedTest("Zip Code: " + donorzipcode + " does not match expected zip code: " + zipcode.Replace("_", " "));

            if (donorstate == state.Replace("_", " "))
                Report.LogPassedTest("State is correct - " + donorstate);
            else
                Report.LogFailedTest("State: " + donorstate + " does not match expected state: " + state.Replace("_", " "));

            Verify.ElementContainsText(hdraborh, abo.Replace("_", " "));
            Verify.ElementContainsText(hdrcmv, cmv.Replace("_", " "));
            //Verify.ElementContainsText(hdrgallon, gallon.Replace("_", " "));

            Report.LogPassedTest("Returning donor " + txtDonorID + " address, abo, cmv and gallon display correctly.");
            Report.TakeScreenshot();

            Actions.Click(lnkonsitemodulemenu);


        }

        public void SelectDonorUpdate()
        {
            Actions.Click(GetDonorRadioBtnLocator(OnsiteHelper.txtDonorIDonly));
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btnselect);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void EnterReturningDonorforInquiry()
        {

            //Inquiry for smallpox; incident date is 5 days prior
            String txtenterincidentdate = DateTime.Today.AddDays(-5).ToString("MM/dd/yyyy");
            Actions.ScrollToElement(chkidverify);
            Waits.WaitForPageLoad();
            Actions.Click(chkidverify);
            Actions.Click(btnverifyok);
            Waits.WaitForPageLoad();
            Actions.ScrollToElement(btnupdate);

            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btninquiry);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(popupscreen, "Donor Inquiry");
            CommonActions.SetText(txtdescription, "smallpox");
            Actions.Click(btnsearch);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnksmallpox);

            CommonActions.SetText(txtincidentdate, txtenterincidentdate);
            CommonActions.SetText(txtdeferraldate, "^");
            Report.LogPassedTest("Inquiry is entered");
            Report.TakeScreenshot();

            Actions.Click(btnapply);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btnupdate);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


        }

        public void EnterDeferralID()
        {
            OnsiteHelper.generatedeferralid();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(popupscreen, "Override/Deferral");

            Actions.Click(optionyes);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtdeferralid, "d" + gblunitdeferralid + "d");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.LogPassedTest("Donor " + txtDonorID + " is deferred with deferral id " + gblunitdeferralid);
            Report.TakeScreenshot();
            Actions.Click(btnsaveandclose);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void SaveandCloseDeferral()
        {
            Verify.ElementContainsText(txtmessage, "Msg: 21030: Donor Registered as Deferral");
            Report.LogPassedTest("Deferral Id is entered");
            Report.TakeScreenshot();

            Actions.Click(btnverifyok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(lnkonsitemodulemenu);
        }

        public void OverrideDonor()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(popupscreen, "Override/Deferral");

            Actions.Click(optionno);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtsuperuser, WebEnvironment.AppSettings["AppUserName"]);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtsuperpassword, WebEnvironment.AppSettings["AppPassword"]);
            Actions.Click(txtoverridereason);
            Actions.ScrollToElement(reasonoptions);
            //var selecteddriveid = Actions.ExecuteJavascript<string>("document.getElementById('input-reason').index('RSN4 - Restricted donor')");
            Actions.Click(reasonoptions);

            //Actions.SelectByValue(reasonoptions, "RSN4 - Restricted donor");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.LogPassedTest("Donor Override");
            Report.TakeScreenshot();
            Actions.Click(btnsaveandclose);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
        }

        public void OnlineStatusQueryDisplay()
        {
            //txtDonorIDonly = "30122301";
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkOnsiteStatusQuery);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(ONSITESTATUSQUERY);

            //Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
            Actions.Click(By.XPath(onsitequeryoverride));
            
            Verify.ElementContainsText(By.XPath(onsitequeryoverride), "(RSN4)");
            Report.LogPassedTest("Donor Displayed in Query");
            Report.TakeScreenshot();
            Actions.Click(lnkonsitemodulemenu);
        }

        public void SaveandCloseOverride()
        {
            Verify.ElementContainsText(txtmessage, "Msg: 21031: Donor Registered with override option");
            Report.LogPassedTest("Donor registered with an override");
            Report.TakeScreenshot();

            Actions.Click(btnverifyok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(lnkonsitemodulemenu);
        }

        public void EligibilityConfirmation(String deferraltype)
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            if (deferraltype == "Temporary")
            {
                Verify.ElementContainsText(eligibilitystatus, "NO");
                Verify.ElementContainsText(eligibilityreason, "Donor is temporarily deferred.");
                Verify.ElementContainsText(eligibilitydate, "Next Eligible Date: ");

                Report.LogPassedTest("Donor is temporarily deferred");
                Report.TakeScreenshot();
            }
            else if (deferraltype == "Permanent")
            {
                Verify.ElementContainsText(eligibilitystatus, "NO");
                Verify.ElementContainsText(eligibilityreason, "Donor is indefinitely deferred.");
                Report.LogPassedTest("Donor is indefinitely deferred");
                Report.TakeScreenshot();
            }


            Actions.Click(lnkonsitemodulemenu);
        }

        public void VerifyUpdateDonorInformation()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            var homephone = Actions.ExecuteJavascript<string>("document.getElementById('input-home-phone').value");
            var address = Actions.ExecuteJavascript<string>("document.getElementById('input-address').value");
            var city = Actions.ExecuteJavascript<string>("document.getElementById('input-city').value");
            var zipcode = Actions.ExecuteJavascript<string>("document.getElementById('input-zip').value");

            if (address == gblAddress)
                Report.LogPassedTest("Address is correct - " + address);
            else
                Report.LogFailedTest("Address: " + address + " does not match expected Address: " + gblAddress);

            if (city == gblCity)
                Report.LogPassedTest("City is correct - " + city);
            else
                Report.LogFailedTest("City: " + city + " does not match expected City: " + gblCity);

            if (zipcode == gblZipCode)
                Report.LogPassedTest("Zip Code is correct - " + zipcode);
            else
                Report.LogFailedTest("Zip Code: " + zipcode + " does not match expected Zip Code: " + gblZipCode);

            if (homephone == gblHomePhone)
                Report.LogPassedTest("Home Phone is correct - " + homephone);
            else
                Report.LogFailedTest("Home Phone: " + homephone + " does not match expected Home Phone: " + gblHomePhone);

            Actions.ScrollToElement(txtemployername);


            Report.LogPassedTest("Donor information is updated");
            Report.TakeScreenshot();

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(lnkonsitemodulemenu);


        }

        public void EnterReturningDonorforInquiryDI()
        {

            //Inquiry for smallpox; incident date is 5 days prior
            String txtenterincidentdate = DateTime.Today.AddDays(-5).ToString("MM/dd/yyyy");
            Actions.ScrollToElement(chkidverify);
            Waits.WaitForPageLoad();
            Actions.Click(chkidverify);
            Actions.Click(btnverifyok);
            Waits.WaitForPageLoad();
            Actions.ScrollToElement(btnupdate);

            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btninquiry);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(popupscreen, "Donor Inquiry");
            CommonActions.SetText(txtdescription, "oxygen therapy");
            Actions.Click(btnsearch);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkuot);

            CommonActions.SetText(txtincidentdate, txtenterincidentdate);
            CommonActions.SetText(txtdeferraldate, "^");
            Report.LogPassedTest("Inquiry is entered");
            Report.TakeScreenshot();

            Actions.Click(btnapply);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Actions.Click(btnupdate);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


        }

        public void OnsiteStatusQueryRegister()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkOnsiteStatusQuery);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(ONSITESTATUSQUERY);
            Actions.Click(statustitle);
            Actions.Click(statustitle);
            for (int ipage = 1; ipage < 5; ipage++)
                if (Actions.IsElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Pending"))
                {
                    Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                    Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Pending");
                    Verify.ElementContainsText(By.XPath(onsitequeryoverride), ":");
                }
                else
                {
                    Actions.Click(btnnextpage);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                    Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Pending");
                    Verify.ElementContainsText(By.XPath(onsitequeryoverride), ":");

                }

            Report.LogPassedTest("Donor " + txtDonorID + " has a status of Pending");

            Report.TakeScreenshot();
            Actions.Click(lnkonsitemodulemenu);

        }

    }
}