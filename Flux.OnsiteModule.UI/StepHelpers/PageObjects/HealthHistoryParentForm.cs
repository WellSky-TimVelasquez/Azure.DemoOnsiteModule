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
    class HealthHistoryParentForm : OnsiteModule_PageBase
    {

        #region PageObjects
        //Select Donor
        private readonly string rdodonorselect = "donor-id-dn{0}"; 
        private readonly string seldonorid = "dononr-id-dn{0}";
        private readonly string seldonorname = "name-dn{0}";
        private readonly string seldob = "date-of-birth-dn{0}";
        private readonly string selssn = "ssn-dn{0}";
        private readonly string seltimeinqueue = "time-in-queue-dn{0}";
        private readonly By btnselectdonor = By.Id("button-select-donor");
        private readonly By btnnextpage = By.Id("btn-next-page");
        private readonly By linkphysicalfindings = By.Id("physical-findings-start-form");
        private readonly By lnkonsitemodulemenu = By.Id("link-onsite-module-menu");


        //Header
        private readonly By hdrdonorname = By.Id("label-donor-name");
        private readonly By hdrdonorid = By.Id("label-donor-id");
        private readonly By hdrdob = By.Id("label-date-of-birth");
        private readonly By hdrage = By.Id("label-age");
        private readonly By hdrgender = By.Id("label-gender");
        private readonly By hdraborh = By.Id("label-blood-type");
        private readonly By hdrdonationtype = By.Id("label-donation-type");
        private readonly By hdraddress = By.Id("label-address");
        private readonly By hdrcurrentdate = By.Id("label-chapter-date-time");


        //Confirm
        private readonly By txtconfirmdiff = By.Id("confirm-title");
        private readonly By txtlastname = By.Id("input-last-name");
        private readonly By txtfirstname = By.Id("input-first-name");
        private readonly By txtssn = By.Id("input-ssn");
        private readonly By txtconfirmdob = By.Id("input-date-of-birth");
        private readonly By txtconfirmgender = By.Id("input-gender");
        private readonly By btnok = By.Id("button-ok");

        //Comment
        private readonly By lnkcomment = By.Id("button-comments");
        private readonly By txtcommententry = By.Id("input-enter-donor-note");
        private readonly By btnsave = By.Id("button-save");
        private readonly By pagenumber = By.XPath("//app-donor-comments/mat-dialog-content/div/div[3]/div/app-mat-table/div/div[2]/mat-paginator/div/div/div[2]/div");
        private readonly string txtentereddate = "entered-date-{0}";
        private readonly string txtnote = "note-{0}";

        //Registration
        private readonly By btnhhphy = By.Id("button-hhphy");
        private readonly By btnverifyok = By.Id("multi-button-ok");
        private readonly By btnyes = By.Id("multi-button-yes");


        //Health History
        private readonly By lnkhealthhistory = By.Id("health-history-start-form");
        private readonly By txtusername = By.Id("input-username");
        private readonly By txtpassword = By.Id("input-password");
        private readonly By btnsign = By.Id("button-sign");
        private readonly By txtsuperusername = By.Id("input-super-userid");
        private readonly By btnsubmit = By.Id("button-submit");
        private readonly By alertmsg = By.Id("alert-title");
        private readonly By btnallquestions = By.Id("multi-button-view-all-questions");
        private readonly By txtcodeioana = By.Id("code--ioana");
        private readonly By lnkselectanswer = By.Id("link-select-answer");
        private readonly By txtincidentdate = By.Id("input-ioana-incident-date");
        private readonly By txtcomments = By.Id("input-ioana-comments");
        private readonly By optionyes = By.Id("radio-yes");
        private readonly By optionno = By.Id("radio-no");
        private readonly By btnnext = By.Id("button-next");
        private readonly By btnprevious = By.Id("button-prev");
        private readonly By btnclose = By.Id("button-close");
        private readonly By lnkgotoquestion = By.Id("health-history-start-form");
        private readonly By chkexceptiononly = By.Id("check-exceptions-only");
        private readonly By lblquestion = By.Id("label-question-number");
        private readonly By btnsummary = By.Id("button-summary");
        private readonly By labelsummarypage = By.XPath("//*/app-onsite-router/div/div/app-health-history/div/div/mat-card/app-health-history-summary/div[1]/span/h5/b");
        private readonly By totalquestions = By.Id("label-total-questions");
        private readonly By btnNextQuestion = By.Id("button-next-question");
        private readonly By currentreviewquestion = By.Id("label-current-review-question-number");
        private readonly By btncompleteform = By.Id("button-complete-form");
        private readonly By lnkaddanswer = By.Id("link-add-answer");
        private readonly By lblchapterdate = By.Id("label-chapter-date-time");
        private readonly By btndelete = By.Id("close-no");

        //Physical Findings
        private readonly By hgbinitial = By.Id("HGB-input-initial-value");
        private readonly By hgbrepeat = By.Id("HGB-input-repeat-value");

        //Online Status Query
        private readonly By lnkOnsiteStatusQuery = By.Id("link-onsite-status-query");
        private readonly string strstatus = "status-dn{0}";
        private readonly string onsitehh = "//*[starts-with(@id, 'healthhistory') and contains(@id, '" + txtDonorIDonly + "')]";
        private readonly string onsitepf = "//*[starts-with(@id, 'physicalfindings') and contains(@id, '" + txtDonorIDonly + "')]";
        private readonly string onsiteregistration = "//*[starts-with(@id, 'registration') and contains(@id, '" + txtDonorIDonly + "')]";
        private readonly By statustitle = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-onsite-status-query/div/mat-card[1]/div/div/app-mat-table/div[1]/table/thead/mat-header-row/th[9]/div/button");
        private readonly By btnnextpageonsite = By.Id("btn-next-page");

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

        public By GetDonorIdLocator(string donorid)
        {
            By locator = By.Id(string.Format(seldonorid, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorSsnLocator(string donorid)
        {
            By locator = By.Id(string.Format(selssn, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorDobLocator(string donorid)
        {
            By locator = By.Id(string.Format(seldob, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorNameLocator(string donorid)
        {
            By locator = By.Id(string.Format(seldonorname, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorTimeinQueueLocator(string donorid)
        {
            By locator = By.Id(string.Format(seltimeinqueue, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }
        #endregion

        public By GetCommentEnteredDate(string commentnumber)
        {
            By locator = By.Id(string.Format(txtentereddate, commentnumber));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetCommentNote(string commentnumber)
        {
            By locator = By.Id(string.Format(txtnote, commentnumber));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public void HHPFDonorInformation()
        {

            Waits.WaitForPageLoad();
            Verify.ElementIsDisabled(btnselectdonor);
            Report.LogInfo("1.01.2 Select Donor button is disabled.");
            Report.TakeScreenshot();
            if (Actions.IsElementPresent(GetDonorRadioBtnLocator(OnsiteHelper.txtDonorIDonly)) == false)
                Actions.Click(btnnextpage);

            Verify.ElementContainsText(GetDonorNameLocator(OnsiteHelper.txtDonorIDonly), gblLastName + ", " + gblFirstName);
            Verify.ElementContainsText(GetDonorIdLocator(OnsiteHelper.txtDonorIDonly), txtDonorID);
            if (gblSSN is null)
                Verify.TextboxIsEmpty(GetDonorSsnLocator(OnsiteHelper.txtDonorIDonly));
            else
                gblSSN = gblSSN.Substring(0, 3) + "-" + gblSSN.Substring(3, 2) + "-" + gblSSN.Substring(5, 4);
            Verify.ElementContainsText(GetDonorSsnLocator(OnsiteHelper.txtDonorIDonly), gblSSN);
            gblDateOfBirth = gblDateOfBirth.Substring(0, 2) + "/" + gblDateOfBirth.Substring(3, 2) + "/" + gblDateOfBirth.Substring(6, 4);
            Verify.ElementContainsText(GetDonorDobLocator(OnsiteHelper.txtDonorIDonly), gblDateOfBirth);
            Report.LogInfo("1.01.1 Regisered donor information is displayed in the list.");
            Report.TakeScreenshot();

            Actions.Click(GetDonorRadioBtnLocator(OnsiteHelper.txtDonorIDonly));
            Verify.ElementIsEnabled(btnselectdonor);
            Report.LogInfo("1.01.5 Select Donor button is enabled after donor is selected.");
            Report.TakeScreenshot();

        }

        public void SelectDonor()
        {

            //txtDonorIDonly = "30122257";
            //txtDonorID = "DN30122257";
            //gblFirstName = "YQDEXUJRFQ";
            string testvalue;
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //if (Actions.IsElementPresent(GetDonorRadioBtnLocator(OnsiteHelper.txtDonorIDonly)))
            //    Actions.Click(GetDonorRadioBtnLocator(OnsiteHelper.txtDonorIDonly));
            //else
            //    Actions.Click(btnnextpage);
            Actions.Click(GetDonorRadioBtnLocator(OnsiteHelper.txtDonorIDonly));

            //code to verify a radio button is selected
            //Verify.ElementIsSelected(GetDonorRadioBtnLocator(OnsiteHelper.txtDonorID));

            Actions.Click(btnselectdonor);

            if (Actions.IsElementPresent(txtconfirmdiff))
            {
                if (Actions.IsElementPresent(txtconfirmdob))
                {
                    CommonActions.SetText(txtconfirmdob, gblDateOfBirth);
                    if (Actions.IsElementContainsText(txtconfirmdob, gblDateOfBirth))
                    { CommonActions.SetText(txtconfirmdob, gblDateOfBirth); }
                }
                if (Actions.IsElementPresent(txtfirstname))
                {
                    CommonActions.SetText(txtfirstname, gblFirstName);
                    testvalue = Actions.GetText(txtfirstname);
                    //if (Actions.IsElementContainsText(txtfirstname, gblFirstName))
                    if (Actions.IsElementDoesNotContainsText(txtfirstname, gblFirstName))

                        { CommonActions.SetText(txtfirstname, gblFirstName); }
                }
                if (Actions.IsElementPresent(txtlastname))
                {
                    CommonActions.SetText(txtlastname, gblLastName);
                    if (Actions.IsElementContainsText(txtlastname, gblLastName))
                    {
                        CommonActions.SetText(txtlastname, gblLastName);
                    }
                }
                if (Actions.IsElementPresent(txtconfirmgender))
                {
                    CommonActions.SetText(txtconfirmgender, gblGender);
                    if (Actions.IsElementContainsText(txtconfirmgender, gblGender))
                    {
                        CommonActions.SetText(txtconfirmgender, gblGender);
                    }
                }
                if (Actions.IsElementPresent(txtssn))
                {
                    CommonActions.SetText(txtssn, gblSSN);
                    if (Actions.IsElementContainsText(txtssn, gblSSN))
                    { CommonActions.SetText(txtssn, gblSSN); }
                }
                Actions.Click(btnok);
            }

        }


        public void VerifyDonorHeader()
        {

            Waits.WaitForPageLoad();
            Verify.ElementContainsText(hdrdonorname, gblLastName + ", " + gblFirstName);
            Verify.ElementContainsText(hdrdonorid, txtDonorID);
            gblDateOfBirth = gblDateOfBirth.Substring(0, 2) + "-" + gblDateOfBirth.Substring(3, 2) + "-" + gblDateOfBirth.Substring(6, 4);
            Verify.ElementContainsText(hdrdob, gblDateOfBirth);
            Verify.ElementContainsText(hdrgender, gblGender);
            Verify.ElementContainsText(hdraborh, "NONE");
            Verify.ElementContainsText(hdrdonationtype, gblDonationType + "/" + gblProcedureCode.Substring(0, 2));

        }

        public void AddComment()
        {
            //Waiting for ID's to get added to the screen - MLT-2169
            strCommentDate = Actions.GetText(hdrcurrentdate);
            Waits.WaitForPageLoad();
            Actions.Click(lnkcomment);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Verify.ExactPageTitle();
            CommonActions.SetText(txtcommententry, "This is a test comment 3");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnsave);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Verify.ElementContainsText(hdrdonorname, );


        }

        public void ConfirmComment()
        {

            String pagetotal;
            string strpagedate;
            int intpagenumber;
            int totalpage;

            pagetotal = Actions.GetText(pagenumber);
            intpagenumber = pagetotal.IndexOf("of");
            totalpage = pagetotal.LastIndexOf(pagetotal);
            totalpage = pagetotal.Count();
            pagetotal = pagetotal.Substring((intpagenumber+3), (totalpage- (intpagenumber + 3)));
            Waits.WaitForPageLoad();

            strpagedate = Actions.GetText(GetCommentEnteredDate(pagetotal));

            Verify.ElementContainsText(GetCommentNote(pagetotal), "This is a test comment 3");
            if (strCommentDate == strpagedate)
            {
                Verify.ElementContainsText(GetCommentEnteredDate(pagetotal), strCommentDate);
                Report.LogPassedTest("Comment is saved for Donor: " + OnsiteHelper.txtDonorID);
                Report.TakeScreenshot();
            }

            else
            {
                Verify.ElementContainsText(GetCommentEnteredDate(pagetotal), (strCommentDate.Substring(1, 13)));
                Report.LogPassedTest("Comment is saved for Donor: " + OnsiteHelper.txtDonorID);
                Report.TakeScreenshot();
            }



        }

        public void HHButton()
        {
            Report.LogPassedTest("Donor " + txtDonorID + " is registered");
            Report.TakeScreenshot();

            Actions.Click(btnverifyok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnhhphy);
            Report.LogPassedTest("HH/PHY Button is enabled");
            Report.TakeScreenshot();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnhhphy);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void HHPFDisplayed()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(ONSITEHHPF);
            Report.LogPassedTest("Health History Parent screen is displayed");
            Report.TakeScreenshot();

        }

        public void OpenHealthHistorySupervisormode()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkhealthhistory);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtsuperusername, WebEnvironment.AppSettings["AppUserName"]);
            CommonActions.SetText(txtpassword, WebEnvironment.AppSettings["AppPassword"]);
            Report.LogPassedTest("Login as super user");
            Report.TakeScreenshot();
            Actions.Click(btnsubmit);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(txtusername);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactTextInElementIs(alertmsg, "For your information: Entry to this window require Signoff after completion");
            Report.TakeScreenshot();

            Actions.Click(btnverifyok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Verify.ExactTextInElementIs(alertmsg, "There are no Exceptions to review.");
            Report.TakeScreenshot();
            Actions.Click(btnallquestions);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Verify.ExactPageTitle(HEALTHHISTORY);
            Report.LogPassedTest("Health History Screen is displayed");
            Report.TakeScreenshot();

        }

        public void UpdateFeelingWellQuestionHH()
        {
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10));

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            for (int icount = 1; icount < 16; icount++)
                if (Actions.IsElementContainsText(lblquestion, "Question 1 (HQ0010)"))
                {

                    Actions.Click(btndelete);
                    Verify.ExactTextInElementIs(alertmsg, "Do you want to delete this answer and the associated interdiction?");
                    Report.TakeScreenshot();
                    Actions.Click(btnyes);

                    Actions.Click(optionyes);
                    Actions.Click(lnkaddanswer);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    Actions.Click(txtcodeioana);
                    Actions.Click(lnkselectanswer);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    CommonActions.SetText(txtincidentdate, Convert.ToString(txtcurrentchapterdate.ToString("MM/dd/yyyy")));
                    CommonActions.SetText(txtcomments, "Latex Allergy");
                    Report.LogPassedTest("Latex Allergy");
                    Report.TakeScreenshot();

                    Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else if (Actions.IsElementContainsText(lblquestion, "Question 2 (HQ0020)") ^ Actions.IsElementContainsText(lblquestion, "Question 18 (HQ0470)"))
                {
                    //Actions.Click(optionyes);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    if (icount != 15)
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else
                {
                    //Actions.Click(optionno);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                    if (icount != 15)
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnsummary);
            Report.LogPassedTest("Health History questions are complete");
            Report.TakeScreenshot();

        }

        public void OpenPhysicalFindingsSupervisormode()
        {

            Waits.WaitForPageLoad();
            Actions.Click(linkphysicalfindings);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtsuperusername, WebEnvironment.AppSettings["AppUserName"]);
            CommonActions.SetText(txtpassword, WebEnvironment.AppSettings["AppPassword"]);
            Report.LogPassedTest("Login as super user");
            Report.TakeScreenshot();
            Actions.Click(btnsubmit);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(txtusername);
            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(PHYSICALFINDINGS);
            Report.LogPassedTest("Physical Findings Screen is displayed");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.TakeScreenshot();


        }

        public void UpdateHGB()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.DoubleClick(hgbinitial);
            CommonActions.SetText(hgbinitial, "14");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.LogPassedTest("HGB Updated");
            Report.TakeScreenshot();
            Actions.PressKey(Keys.Tab, hgbrepeat);
            Actions.ScrollToElement(btncompleteform);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);

            Actions.Click(btncompleteform);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.LogPassedTest("Physical Findings complete");
            Report.TakeScreenshot();
            Actions.Click(btnverifyok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void OnsiteStatusQueryHHPFConsent()
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
                    Verify.ElementContainsText(By.XPath(onsitehh), ":");
                    Verify.ElementContainsText(By.XPath(onsitepf), ":");
                    Verify.ElementContainsText(By.XPath(onsiteregistration), ":");
                }
                else
                {
                    Actions.Click(btnnextpageonsite);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                    Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Pending");
                    Verify.ElementContainsText(By.XPath(onsitehh), ":");
                    Verify.ElementContainsText(By.XPath(onsitepf), ":");
                    Verify.ElementContainsText(By.XPath(onsiteregistration), ":");
                }

            Report.LogPassedTest("Donor " + txtDonorID + " has a status of Pending");

            Report.TakeScreenshot();
            Actions.Click(lnkonsitemodulemenu);

        }


    }
}
