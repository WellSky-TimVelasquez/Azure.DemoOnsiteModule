using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;


namespace Flux.OnsiteModule.UI//.StepHelpers.PageObjects
{
    public class HealthHistory : OnsiteModule_PageBase
    {

        #region PageObjects
        private readonly By lnkonsitemodulemenu = By.Id("link-onsite-module-menu");
        private readonly By lnkhealthhistoryphyfindings = By.Id("link-health-history--physical-findings");
        private readonly string strrtndnid = "donorid-dn{0}";
        private readonly By strreturndonor = By.XPath("//*/app-onsite-router/div/div/app-lookup-and-registration/div/app-find-donor/div/div/mat-card/div/app-mat-table/div[1]/table/tbody/mat-row");
        private readonly By lnkdonorlookup = By.Id("link-lookupregistration--modify-data");
        private readonly By txtdonorid = By.Id("input-donor-id");
        private readonly By txtusername = By.Id("input-username");
        private readonly By txtpassword = By.Id("input-password");
        private readonly By btnsign = By.Id("button-sign");
        private readonly By btncancel = By.Id("button-cancel");
        private readonly By lnkhealthhistory = By.Id("health-history-start-form");
        private readonly By lblchapterdate = By.Id("label-chapter-date-time");


        //Health History Screen
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
        private readonly By lblsummarychange = By.Id("changed-1");
        private readonly By btnNextQuestion = By.Id("button-next-question");
        private readonly By currentreviewquestion = By.Id("label-current-review-question-number");
        private readonly By btncompleteform = By.Id("button-complete-form");
        private readonly By btnok = By.Id("multi-button-ok");
        private readonly By btnno = By.Id("multi-button-no");
        private readonly By lnkaddanswer = By.Id("link-add-answer");
        private readonly By txtcodeioana = By.Id("code--ioana");
        private readonly By lnkselectanswer = By.Id("link-select-answer");
        private readonly By txtincidentdate = By.Id("input-ioana-incident-date");
        private readonly By txtcomments = By.Id("input-ioana-comments");
        private readonly By grpallergy = By.Id("group-allergy-");
        private readonly By grpcold = By.Id("group-cold-");
        private readonly By txtalgy2 = By.Id("code-allergy-algy2"); 
        private readonly By txt4way4 = By.Id("group-cold-4way4"); 
        private readonly By txtalgydate = By.Id("input-algy2-incident-date");
        private readonly By txt4way4startdate = By.Id("input-4way4-start-date");
        private readonly By txt4way4enddate = By.Id("input-4way4-end-date");
        private readonly By txt4way4incidentdate = By.Id("input-4way4-incident-date");
        private readonly By txt4way4comments = By.Id("input-4way4-comments");
        private readonly By txtalgycomments = By.Id("input-algy2-comments");
        private readonly By btndeleteyes = By.Id("close-yes");
        private readonly By btnyes = By.Id("multi-button-yes");
        private readonly By alertmsg = By.Id("alert-title");
        private readonly By txtnocomment = By.Id("input-no-comments");
        private readonly By chkchanged1 = By.Id("changed-1");
        private readonly By selectlanguage = By.Id("input-language");
        private readonly By txtquestion = By.Id("p-question");
        private readonly By selectlanguagelist = By.Id("select-language-option");
        private readonly By lblchanged = By.XPath("//*/app-onsite-router/div/div/app-health-history/div/div/mat-card/app-health-history-question/div/div/div[1]/mat-grid-list/div/mat-grid-tile[2]/figure/div");

        //German
        
        private readonly By txtcontinuegerman = By.Id("button-fortsetzen");

        //Health History Statistics
        private readonly By healthhistorystatus = By.Id("health-history-status");
        private readonly By deferralstat = By.Id("health-history-deferral");
        private readonly By overridestat = By.Id("health-history-override");
        private readonly By lasteditedtime = By.Id("health-history-last-edited");
        private readonly By lasteditedby = By.Id("health-history-edited-by");

        //Eligibility
        private readonly By eligibility = By.Id("label-eligibility");
        private readonly By eligiblereason = By.Id("label-reason");

        //Online Status Query
        private readonly By lnkOnsiteStatusQuery = By.Id("link-onsite-status-query");
        private readonly string strstatus = "status-dn{0}";
        private readonly string onsitehh = "//*[starts-with(@id, 'healthhistory') and contains(@id, '" + txtDonorIDonly + "')]";
        private readonly string onsiteregistration = "//*[starts-with(@id, 'registration') and contains(@id, '" + txtDonorIDonly + "')]";
        private readonly By statustitle = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-onsite-status-query/div/mat-card[1]/div/div/app-mat-table/div[1]/table/thead/mat-header-row/th[9]/div/button");
        private readonly By btnnextpage = By.Id("btn-next-page");

        public By GetDonorIDLocator(string donorid)
        {
            By locator = By.Id(string.Format(strrtndnid, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorStatusLocator(string donorid)
        {
            By locator = By.Id(string.Format(strstatus, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        #endregion

        public void SelectHHPFLink()
        {
            Actions.Click(lnkhealthhistoryphyfindings);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(ONSITEHHPF);
        }

        public void ConfirmRegisteredDonor()
        {
            //txtDonorID = "DN30120058";
            //txtDonorIDonly = "30120058";
            Actions.Click(lnkdonorlookup);
            CommonActions.SetText(txtdonorid, txtDonorID);
            //Actions.Click(btnsearch);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Waits.WaitForElementToBeVisible(strreturndonor, Core.WaitType.Small);
            Verify.ExactTextInElementIs((GetDonorIDLocator(txtDonorIDonly)), OnsiteHelper.txtDonorID);
            Report.LogPassedTest("Donor: " + OnsiteHelper.txtDonorID + " is returned");
            Report.TakeScreenshot();

        }

        public void OpenHealthHistoryScreen()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkhealthhistory);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(txtusername);
            CommonActions.SetText(txtusername, WebEnvironment.AppSettings["AppUserName"]);
            CommonActions.SetText(txtpassword, WebEnvironment.AppSettings["AppPassword"]);
            Actions.Click(btnsign);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(HEALTHHISTORY);
            Report.LogPassedTest("Health History Screen is displayed");
            Report.TakeScreenshot();

        }

        public void CompleteHHALNoExceptions()
        {
            int questiontotal;
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            if (gblGender == "F")
                questiontotal = 17;
            else
                questiontotal = 16;
            for (int icount = 1; icount < questiontotal; icount++)
                if (Actions.IsElementContainsText(lblquestion, "Question 2 (HQ0020)") ^ Actions.IsElementContainsText(lblquestion, "Question 18 (HQ0470)"))
                {
                    Actions.Click(optionyes);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    if (icount != (questiontotal-1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else
                {
                    Actions.Click(optionno);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                    if (icount != (questiontotal - 1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnsummary);
            Report.LogPassedTest("Health History questions are complete");
            Report.TakeScreenshot();

        }

        public void CompleteSummary()
        {
            Actions.Click(btnsummary);
            //Waits.WaitForPageLoad();
            string total = Actions.GetText(totalquestions);
            Verify.ExactTextInElementIs(labelsummarypage, "Health History Questionnaire Summary");
            for (int icount = 0; icount < (Convert.ToInt32(total)); icount++)
                Actions.Click(btnNextQuestion);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            if (Actions.GetText(currentreviewquestion) == Actions.GetText(totalquestions))
                Report.LogPassedTest("All questions are reviewed");
            else
                Report.LogFailedTest("All quesions are not reviewed");
            Verify.ElementIsEnabled(btncompleteform);
            Report.TakeScreenshot();

        }

        public void CompleteSignoff()
        {

            Actions.Click(btncompleteform);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(txtusername);
            CommonActions.SetText(txtusername, WebEnvironment.AppSettings["AppUserName"]);
            CommonActions.SetText(txtpassword, WebEnvironment.AppSettings["AppPassword"]);
            Actions.Click(btnsign);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            Verify.ElementIsEnabled(btnok);
            Report.LogPassedTest("Health History complete message is displayed");
            Report.TakeScreenshot();

            Actions.Click(btnok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void ConfirmHHStatisticsBlockPassed()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(healthhistorystatus, "COMPLETE");
            Verify.ElementContainsText(deferralstat, "NO");
            Verify.ElementContainsText(overridestat, "NO");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "YES");
            Verify.ElementContainsText(eligiblereason, "Donor Eligible");

            Report.LogPassedTest("Health History statistics block is complete");
            Report.TakeScreenshot();


        }

        public void CompleteHHLatexException()
        {
            int questiontotal;
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10));

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            if (gblGender == "F")
                questiontotal = 17;
            else
                questiontotal = 16;

            for (int icount = 1; icount < questiontotal; icount++)
                if (Actions.IsElementContainsText(lblquestion, "Question 1 (HQ0010)"))
                {
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
                    Actions.Click(optionyes);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    if (icount != (questiontotal-1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else
                {
                    Actions.Click(optionno);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                    if (icount != (questiontotal-1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnsummary);
            Report.LogPassedTest("Health History questions are complete");
            Report.TakeScreenshot();

        }

        public void ConfirmHHStatisticsBlockOverride()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(healthhistorystatus, "COMPLETE");
            Verify.ElementContainsText(deferralstat, "NO");
            Verify.ElementContainsText(overridestat, "YES");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "NO");
            Verify.ElementContainsText(eligiblereason, "Donor is indefinitely deferred.");

            Report.LogPassedTest("Health History statistics block is complete");
            Report.TakeScreenshot();
        }

        public void ConfirmHHStatisticsBlockDeferral()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(healthhistorystatus, "COMPLETE");
            Verify.ElementContainsText(deferralstat, "YES");
            Verify.ElementContainsText(overridestat, "NO");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "NO");
            Verify.ElementContainsText(eligiblereason, "Donor is indefinitely deferred.");

            Report.LogPassedTest("Health History statistics block is complete");
            Report.TakeScreenshot();
        }

        public void CompleteHHHealthException()
        {
            int questiontotal;
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10));
            if (gblGender == "F")
                questiontotal = 17;
            else
                questiontotal = 16;

            Waits.WaitForPageLoad();
            for (int icount = 1; icount < questiontotal; icount++)
                if (Actions.IsElementContainsText(lblquestion, "Question 2 (HQ0020)"))
                {
                    Actions.Click(optionno);
                    Actions.Click(lnkaddanswer);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    Actions.Click(grpallergy); 
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    Actions.Click(txtalgy2);
                    Report.TakeScreenshot();
                    Actions.Click(lnkselectanswer);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    CommonActions.SetText(txtalgydate, Convert.ToString(txtcurrentchapterdate.ToString("MM/dd/yyyy")));
                    CommonActions.SetText(txtalgycomments, "Allergy - severe congestion");
                    Report.LogPassedTest("Not feeling well, severe congestion");
                    Report.TakeScreenshot();

                    Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else if (Actions.IsElementContainsText(lblquestion, "Question 18 (HQ0470)"))
                {
                    Actions.Click(optionyes);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    if (icount != (questiontotal-1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else
                {
                    Actions.Click(optionno);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                    if (icount != (questiontotal-1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnsummary);
            Report.LogPassedTest("Health History questions are complete");
            Report.TakeScreenshot();

        }

        public void ConfirmHHStatisticsBlockTemporaryDeferral()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(healthhistorystatus, "COMPLETE");
            Verify.ElementContainsText(deferralstat, "YES");
            Verify.ElementContainsText(overridestat, "NO");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "NO");
            Verify.ElementContainsText(eligiblereason, "Donor is temporarily deferred.");

            Report.LogPassedTest("Health History statistics block is complete");
            Report.TakeScreenshot();
        }

        public void UpdateLatexAnswerinHHtoNoException()
        {
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10));

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //for (int icount = 1; icount < 16; icount++)
                if (Actions.IsElementContainsText(lblquestion, "Question 1 (HQ0010)"))
                {

                    Actions.Click(btndeleteyes);
                    Verify.ExactTextInElementIs(alertmsg, "Do you want to delete this answer and the associated interdiction?");
                    Report.TakeScreenshot();
                    Actions.Click(btnyes);

                    Actions.Click(optionno);
                    CommonActions.SetText(txtnocomment, "No Latex Allergy");
                    Report.LogPassedTest("Updated to No Latex Allergy");
                    Report.TakeScreenshot();

                    Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                if (Actions.IsElementContainsText(lblquestion, "Question 18 (HQ0470)"))
                {
                    Actions.Click(optionyes);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnsummary);
            Report.LogPassedTest("Health History questions are complete");
            Report.TakeScreenshot();
        }

        public void CompleteSummaryConfirmChangedAnswer()
        {
            Actions.Click(btnsummary);
            //Waits.WaitForPageLoad();
            string total = Actions.GetText(totalquestions);
            Verify.ExactTextInElementIs(labelsummarypage, "Health History Questionnaire Summary");
            Verify.ExactTextInElementIs(chkchanged1, "X");
            for (int icount = 0; icount < (Convert.ToInt32(total)); icount++)
                Actions.Click(btnNextQuestion);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            if (Actions.GetText(currentreviewquestion) == Actions.GetText(totalquestions))
                Report.LogPassedTest("All questions are reviewed");
            else
                Report.LogFailedTest("All quesions are not reviewed");
            Verify.ElementIsEnabled(btncompleteform);
            Report.TakeScreenshot();

        }

        public void CompleteHHALNoExceptionsinotherlanguage(string strlanguage)
        {
            String questionnumber;
            int questiontotal;
            Actions.Click(selectlanguage);
            Actions.SendKeys(selectlanguage, Keys.LeftShift + Keys.Home);
            Actions.SendKeys(selectlanguage, Keys.Delete);

            if (strlanguage == "Spanish")
                CommonActions.SetText(selectlanguage, "ES");
            else if (strlanguage == "German")
                CommonActions.SetText(selectlanguage, "DE");
            else if (strlanguage == "French")
                CommonActions.SetText(selectlanguage, "FR");

            questionnumber = Actions.GetText(lblquestion).Substring(12,6);

            if (gblGender == "F")
                questiontotal = 17;
            else
                questiontotal = 16;

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            for (int icount = 1; icount < questiontotal; icount++)
            {
                switch (questionnumber)
                {
                    case ("HQ0010"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "¿Es usted alérgico al Iodo y/o Látex?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Bist du allergisch gegen Jod und / oder Latex?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Êtes-vous allergique à l'iode et / ou au latex?");

                            Verify.ElementContainsText(txtquestion, "Are you allergic to iodine and/or latex?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            Report.LogPassedTest("Health History questions are displayed in " + strlanguage);
                            Report.TakeScreenshot();
                            break;
                        }
                    case ("HQ0020"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "Te sientes bien y saludable hoy?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Fühlen Sie sich heute gut und gesund?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Vous vous sentez bien et en bonne santé aujourd'hui?");

                            Verify.ElementContainsText(txtquestion, "Are you feeling well and healthy today?");
                            Actions.Click(optionyes);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0030"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "En las últimas 8 semanas, ¿ha dado sangre, plasma o plaquetas?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Haben Sie in den letzten 8 Wochen Blut, Plasma oder Blutplättchen erhalten?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Au cours des 8 dernières semaines, avez-vous donné du sang, du plasma ou des plaquettes?");

                            Verify.ElementContainsText(txtquestion, "In the past 8 weeks, have you given blood, plasma or platelets?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0040"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "¿Alguna vez ha sido rechazado como donante de sangre o le han dicho que no done sangre?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Wurden Sie jemals als Blutspender abgelehnt oder aufgefordert, kein Blut zu spenden?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Avez-vous déjà été refusé en tant que donneur de sang ou on vous a dit de ne pas donner de sang?");

                            Verify.ElementContainsText(txtquestion, "Have you ever been refused as a blood donor or told not to donate blood?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0071"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "En las últimas 4 semanas, ¿ha tomado alguna píldora o medicamento?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Haben Sie in den letzten 4 Wochen Tabletten oder Medikamente eingenommen?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Au cours des 4 dernières semaines, avez-vous pris des pilules ou des médicaments?");

                            Verify.ElementContainsText(txtquestion, "In the past 4 weeks, have you taken any pills or medications?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0141"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "En las últimas 8 semanas, ¿ha recibido alguna vacuna o vacuna?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Hatten Sie in den letzten 8 Wochen Schüsse oder Impfungen?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Au cours des 8 dernières semaines, avez-vous reçu des vaccins ou des vaccins?");

                            Verify.ElementContainsText(txtquestion, "In the past 8 weeks, have you had any shots or vaccinations?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0160"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "En los últimos 12 meses, ¿le han administrado vacunas contra la rabia?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Haben Sie in den letzten 12 Monaten Tollwut bekommen?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Au cours des 12 derniers mois, avez-vous reçu des vaccins contre la rage?");

                            Verify.ElementContainsText(txtquestion, "In the past 12 months, have you been given rabies shots?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0180"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "Mujer donante: en las últimas 6 semanas, ¿ha estado embarazada o está embarazada?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Spenderin: In den letzten 6 Wochen waren Sie schwanger oder sind Sie jetzt schwanger??");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Donneuse: Au cours des 6 dernières semaines, avez-vous été enceinte ou êtes-vous enceinte maintenant?");

                            Verify.ElementContainsText(txtquestion, "Female Donor: In the past 6 weeks have you been pregnant or are you pregnant now?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }

                    case ("HQ0234"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "Desde 1980, ¿has vivido o viajado a Europa?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Haben Sie seit 1980 in Europa gelebt oder waren Sie in Europa?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Depuis 1980, avez-vous déjà vécu ou voyagé en Europe?");

                            Verify.ElementContainsText(txtquestion, "Since 1980, have you ever lived in or traveled to Europe?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0238"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "Desde 1980 hasta 1996, ¿fue usted miembro del Ejército de los EE. UU., Empleado civil civil o dependiente de un miembro del ejército de los EE. UU.?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Waren Sie von 1980 bis 1996 Mitglied des US-Militärs, Angehöriger eines zivilen Militärs oder Angehörigen eines US-Militärs?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "De 1980 à 1996, vous avez été membre de l’armée américaine, employé militaire civil ou membre d’un membre de l’armée américaine?");

                            Verify.ElementContainsText(txtquestion, "From 1980 through 1996 were you a member of the US Military, a civilian military employee, or a dependent of a member of the US military?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0239"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "¿Pasó un tiempo total de 6 meses o más asociado con una base militar en alguno de los siguientes países: Bélgica, Países Bajos, Alemania, España, Portugal, Turquía, Italia o Grecia?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Haben Sie in einem der folgenden Länder insgesamt mindestens 6 Monate mit einem Militärstützpunkt in Verbindung gebracht: Belgien, Niederlande, Deutschland, Spanien, Portugal, Türkei, Italien oder Griechenland?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Belgique, Pays-Bas, Allemagne, Espagne, Portugal, Turquie, Italie ou Grèce? Avez-vous passé au total 6 mois ou plus?");

                            Verify.ElementContainsText(txtquestion, "Did you spend a total time of 6 months or more associated with a military base in any of the following countries:Belgium,the Netherlands,Germany,Spain,Portugal,Turkey,Italy or Greece?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0691"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "¿Has viajado a algún país de malaria?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Sind Sie in ein Malaria-Land gereist?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Avez-vous voyagé dans des pays touchés par le paludisme?");

                            Verify.ElementContainsText(txtquestion, "Have you traveled to any malarial countries");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0250"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "En los últimos 12 meses, ¿ha tenido un tatuaje, perforación de orejas o piel, acupuntura, electrólisis, punción accidental con la aguja o ha estado en contacto con la sangre de otra persona?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Hatten Sie in den letzten 12 Monaten eine Tätowierung, Ohr- oder Hautdurchdringung, Akupunktur, Elektrolyse, Nadelstiche oder sind Sie mit dem Blut einer anderen Person in Kontakt gekommen?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Au cours des 12 derniers mois, vous avez eu un tatouage, une perforation d'oreille ou de la peau, une acupuncture, une électrolyse, une piqûre accidentelle d'aiguille ou un contact avec le sang d'une autre personne?");

                            Verify.ElementContainsText(txtquestion, "In the past 12 months, have you had a tattoo, ear or skin piercing, acupuncture, electrolysis, accidental needle stick or come in contact with someone else's blood?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0360"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "Donantes masculinos: ¿Ha tenido relaciones sexuales con otro varón, incluso una vez, desde 197?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Spenderinnen: Haben Sie seit 1977 einmal mit einem anderen Mann Sex gehabt?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Donneurs masculins: Avez-vous eu des relations sexuelles avec un autre homme, même une fois, depuis 1977?");

                            Verify.ElementContainsText(txtquestion, "Male Donors: Have you had sex with another male, even once, since 1977?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("HQ0370"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "Mujeres donadoras: En los últimos 12 meses, ¿ha tenido relaciones sexuales con un hombre que ha tenido relaciones sexuales, incluso una vez desde 1977, con otro hombre?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Weibliche Spender: Hatten Sie in den letzten 12 Monaten Sex mit einem Mann, der seit 1977 einmal mit einem anderen Mann Sex hatte?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Femmes donateurs: Au cours des 12 derniers mois, avez-vous eu des relations sexuelles avec un homme qui a eu des relations sexuelles, même une fois depuis 1977, avec un autre homme?");

                            Verify.ElementContainsText(txtquestion, "Female Donors: In the past 12 months, have you had sex with a male who has had sex, even once since 1977, with another male?");
                            Actions.Click(optionno);
                            Actions.Click(btnnext);
                            break;
                        }

                    case ("HQ0470"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "¿Entiendes que si tienes el virus del SIDA, puedes contagiarlo a otra persona aunque te sientas bien y te hagan un examen de SIDA negativo?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(txtquestion, "Verstehen Sie, dass Sie das AIDS-Virus an jemand anderen weitergeben können, obwohl Sie sich wohl fühlen und einen negativen AIDS-Test haben?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(txtquestion, "Comprenez-vous que si vous avez le virus du sida, vous pouvez même lui faire passer un test de dépistage du sida négatif?");

                            Verify.ElementContainsText(txtquestion, "Do you understand that if you have the AIDS virus, you can give it to someone else even though you may feel well and have a negative AIDS test?");
                            Actions.Click(optionyes);
                            Actions.Click(btnnext);
                            break;
                        }
                    case ("D41"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(txtquestion, "¿Alguna vez ha tenido algún problema con su corazón o pulmones?");
                            //else if (strlanguage == "German")
                            //    Verify.ElementContainsText(txtquestion, "¿Es usted alérgico al Iodo y/o Látex?");
                            //else if (strlanguage == "French")
                            //    Verify.ElementContainsText(txtquestion, "¿Es usted alérgico al Iodo y/o Látex?");

                            Verify.ElementContainsText(txtquestion, "Have you EVER had any problems with your heart or lungs?");
                            Actions.Click(optionno);
                            break;
                        }

                }
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                if (Actions.GetText(lblquestion).Substring(12, 2) == "HQ")
                {
                    questionnumber = Actions.GetText(lblquestion).Substring(12, 6);
                }
                else if (Actions.GetText(lblquestion).Substring(12, 2) == "(H")
                {
                    questionnumber = Actions.GetText(lblquestion).Substring(13, 6);
                }
                else
                {
                    questionnumber = Actions.GetText(lblquestion).Substring(13, 3);
                }

            }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnsummary);
            Report.LogPassedTest("Health History questions are complete in " + strlanguage);
            Report.TakeScreenshot();

        }

        public void CompleteHHAUNoExceptions()
        {
            // TEMPLATE TMPL000521
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            for (int icount = 1; icount < 6; icount++)
                if (Actions.IsElementContainsText(lblquestion, "Question 2 (HQ0020)"))
                {
                    Actions.Click(optionyes);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    if (icount != (6 - 1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else
                {
                    Actions.Click(optionno);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                    if (icount != (6 - 1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnsummary);
            Report.LogPassedTest("Health History questions are complete");
            Report.TakeScreenshot();

        }

        public void OnsiteStatusQueryHH()
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
                    Verify.ElementContainsText(By.XPath(onsiteregistration), ":");

                }
                else
                {
                    Actions.Click(btnnextpage);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    Actions.Click(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly));
                    Verify.ElementContainsText(GetDonorStatusLocator(OnsiteHelper.txtDonorIDonly), "Pending");
                    Verify.ElementContainsText(By.XPath(onsitehh), ":");
                    Verify.ElementContainsText(By.XPath(onsiteregistration), ":");


                }

            Report.LogPassedTest("Donor " + txtDonorID + " has a status of Pending");

            Report.TakeScreenshot();
            Actions.Click(lnkonsitemodulemenu);

        }

        public void Addcommenttochangedanswer()
        {
            //add comment to HQ0010 for changed answer in Donor Response
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //for (int icount = 1; icount < 16; icount++)
            if (Actions.IsElementContainsText(lblquestion, "Question 1 (HQ0010)"))
            {
                Verify.ElementContainsText(lblchanged, "CHANGED");
                CommonActions.SetText(txtnocomment, "Donor updated the answer");
                Report.LogPassedTest("Answer updated in Donor Response");
                Report.TakeScreenshot();

                Actions.Click(btnnext);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            if (Actions.IsElementContainsText(lblquestion, "Question 18 (HQ0470)"))
            {
                Actions.Click(optionyes);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnsummary);
            Report.LogPassedTest("Health History questions are complete");
            Report.TakeScreenshot();
        }

        public void CompleteSummarywithchange()
        {
            Actions.Click(btnsummary);
            //Waits.WaitForPageLoad();
            string total = Actions.GetText(totalquestions);
            Verify.ExactTextInElementIs(labelsummarypage, "Health History Questionnaire Summary");
            Verify.ExactTextInElementIs(lblsummarychange, "X");
            Report.TakeScreenshot();

            for (int icount = 0; icount < (Convert.ToInt32(total)); icount++)
                Actions.Click(btnNextQuestion);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            if (Actions.GetText(currentreviewquestion) == Actions.GetText(totalquestions))
                Report.LogPassedTest("All questions are reviewed");
            else
                Report.LogFailedTest("All quesions are not reviewed");
            Verify.ElementIsEnabled(btncompleteform);
            Report.TakeScreenshot();

        }

        public void Updateskippedanswer()
        {
            //add comment to HQ0010 for changed answer in Donor Response
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //for (int icount = 1; icount < 16; icount++)
            if (Actions.IsElementContainsText(lblquestion, "Question 1 (HQ0010)"))
            {
                Verify.ElementContainsText(lblchanged, "BLANK RESPONSE");
                Report.LogPassedTest("Question with blank response is displayed as exception");
                Report.TakeScreenshot();
                Actions.Click(optionno);

                Actions.Click(btnnext);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            if (Actions.IsElementContainsText(lblquestion, "Question 18 (HQ0470)"))
            {
                Actions.Click(optionyes);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnsummary);
            Report.LogPassedTest("Health History questions are complete");
            Report.TakeScreenshot();
        }

        public void CompleteHHALNoExceptionsHoldReturn()
        {
            int questiontotal = 3;
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //if (gblGender == "F")
            //    questiontotal = 17;
            //else
            //    questiontotal = 16;
            for (int icount = 1; icount < questiontotal; icount++)
                if (Actions.IsElementContainsText(lblquestion, "Question 2 (HQ0020)") ^ Actions.IsElementContainsText(lblquestion, "Question 18 (HQ0470)"))
                {
                    Verify.ElementContainsText(alertmsg, "Donor was placed on hold earlier, and has answered this question. Would you like to view the previous answer? YES/NO");
                    Actions.Click(btnno);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    Actions.Click(optionyes);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    if (icount != (questiontotal - 1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else
                {
                    Verify.ElementContainsText(alertmsg, "Donor was placed on hold earlier, and has answered this question. Would you like to view the previous answer? YES/NO");
                    Actions.Click(btnno);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    Actions.Click(optionno);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                    if (icount != (questiontotal - 1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnsummary);
            Report.LogPassedTest("Health History questions are complete");
            Report.TakeScreenshot();

        }

        public void CompleteHHHealthException4Way4()
        {
            int questiontotal;
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10));
            DateTime txtpreviouschapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(-1);

            if (gblGender == "F")
                questiontotal = 17;
            else
                questiontotal = 16;

            Waits.WaitForPageLoad();
            for (int icount = 1; icount < questiontotal; icount++)
                if (Actions.IsElementContainsText(lblquestion, "Question 5 (HQ0071)"))
                {
                    Actions.Click(optionyes);
                    Actions.Click(lnkaddanswer);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    Actions.Click(grpcold);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    Actions.Click(txt4way4);
                    Report.TakeScreenshot();
                    Actions.Click(lnkselectanswer);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    CommonActions.SetText(txt4way4startdate, Convert.ToString(txtpreviouschapterdate.ToString("MM/dd/yyyy")));
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    CommonActions.SetText(txt4way4enddate, Convert.ToString(txtcurrentchapterdate.ToString("MM/dd/yyyy")));
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    CommonActions.SetText(txt4way4incidentdate, Convert.ToString(txtpreviouschapterdate.ToString("MM/dd/yyyy")));
                    CommonActions.SetText(txt4way4comments, "STUFF");
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    var txtcommentvalue = Actions.ExecuteJavascript<string>("document.getElementById('input-4way4-comments').value");
                    if (txtcommentvalue == "Stuffiness")
                        Report.LogPassedTest("Canned comment Stuff is displaying " + txtcommentvalue);
                    else
                    {
                        Report.LogError("Canned comment is not displaying");
                    }

                    Report.LogPassedTest("Donor taking cold medicine");
                    Report.TakeScreenshot();

                    Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else if (Actions.IsElementContainsText(lblquestion, "Question 2 (HQ0020)") ^ Actions.IsElementContainsText(lblquestion, "Question 18 (HQ0470)"))
                {
                Actions.Click(optionyes);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    if (icount != (questiontotal - 1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else
                {
                    Actions.Click(optionno);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                    if (icount != (questiontotal - 1))
                        Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnsummary);
            Report.LogPassedTest("Health History questions are complete");
            Report.TakeScreenshot();

        }

    }
}
