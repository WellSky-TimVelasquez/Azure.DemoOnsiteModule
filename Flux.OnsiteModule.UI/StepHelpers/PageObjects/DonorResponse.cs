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
    class DonorResponse : OnsiteModule_PageBase
    {

        #region PageObjects
        //Select Donor
        private readonly By linkdonorresponse = By.Id("donor-response-start-form");
        private readonly By txtusername = By.Id("input-username");
        private readonly By txtpassword = By.Id("input-password");
        private readonly By btnsign = By.Id("button-sign");
        private readonly By btncancel = By.Id("button-cancel");

        //Donor Response
        private readonly By btncontinue = By.Id("button-continue");
        private readonly By lbllanguagepage = By.Id("label-language-title"); 
        private readonly By selectlanguage = By.Id("language-select");
        private readonly By Spanishlanguage = By.Id("Spanish");
        private readonly By Germanlanguage = By.Id("German");
        private readonly By Frenchlanguage = By.Id("French");

        private readonly By lblwelcomemessage = By.Id("label-welcome-message");
        private readonly By lblgreeting = By.Id("label-greeting");
        private readonly By lblquestioncode = By.Id("label-question-code");

        private readonly By inputverify = By.Id("input-verify");
        private readonly By readmoremessage = By.Id("alert-title");
        private readonly By btnok = By.Id("multi-button-ok");
        private readonly By optionyes = By.Id("answer-yes");
        private readonly By optionno = By.Id("answer-no");
        private readonly By btnfinish = By.Id("button-finish");
        private readonly By multibtnfinish = By.Id("multi-button-finish");
        private readonly By lbldonorquestion = By.Id("donor-response-question");
        private readonly By btnpreviousquestion = By.Id("button-previous-question");
        private readonly By btnnextquestion = By.Id("button-next-question");

        

        //Donor Response Spanish
        private readonly By btncontinuespanish = By.Id("button-continuar"); 
        private readonly By btnreadmorespanish = By.Id("button-leer-ms");
        private readonly By btnpreviousquestionspanish = By.Id("button-pregunta-anterior");
        private readonly By btnnextquestionspanish = By.Id("button-siguiente-pregunta");
        private readonly By btnfinishspanish = By.Id("button-finalizar");
        private readonly By multibtnfinishspanish = By.Id("multi-button-terminar");

        //Donor Response German
        private readonly By btncontinuegerman = By.Id("button-fortsetzen");
        private readonly By btnreadmoregerman = By.Id("button-weiterlesen");
        private readonly By btnpreviousquestiongerman = By.Id("button-vorherige-frage");
        private readonly By btnnextquestiongerman = By.Id("button-nchste-frage");
        private readonly By btnfinishgerman = By.Id("button-fertig");
        private readonly By multibtnfinishgerman = By.Id("multi-button-fertig");

        //Donor Response French
        private readonly By btncontinuefrench = By.Id("button-continuer");
        private readonly By btnreadmorefrench = By.Id("button-lire-la-suite");
        private readonly By btnpreviousquestionfrench = By.Id("button-question-prcdente");
        private readonly By btnnextquestionfrench = By.Id("button-question-suivante");
        private readonly By btnfinishfrench = By.Id("button-terminer");
        private readonly By multibtnfinishfrench = By.Id("multi-button-terminer");


        //Donor Response Statistics
        private readonly By donorresponsestatus = By.Id("donor-response-status");
        private readonly By lasteditedby = By.Id("donor-response-edited-by");

        //Eligibility
        private readonly By eligibility = By.Id("label-eligibility");
        private readonly By eligiblereason = By.Id("label-reason");

        #endregion


        public void OpenDonorResponseScreen()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(linkdonorresponse);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(txtusername);
            CommonActions.SetText(txtusername, WebEnvironment.AppSettings["AppUserName"]);
            CommonActions.SetText(txtpassword, WebEnvironment.AppSettings["AppPassword"]);
            Actions.Click(btnsign);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(DONORRESPONSE);

        }

        public void ConfirmDonorResponseStatisticsBlockPassed()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(donorresponsestatus, "COMPLETE");
            Verify.ElementContainsText(lasteditedby, WebEnvironment.AppSettings["AppUserName"].ToUpper());
            Verify.ElementContainsText(eligibility, "YES");
            Verify.ElementContainsText(eligiblereason, "Donor Eligible");

            Report.LogPassedTest("Donor Response statistics block is complete");
            Report.TakeScreenshot();


        }

        public void CompleteDRExpectedAnswers()
        {
            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lbllanguagepage);
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lblwelcomemessage);
            CommonActions.SetText(inputverify, "YES");
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lblgreeting);
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            if (Actions.IsElementPresent(readmoremessage))
                Actions.Click(btnok);


                    Waits.WaitForPageLoad();
            for (int icount = 1; icount < 16; icount++)
                if (Actions.IsElementContainsText(lblquestioncode, "HQ0020") ^ Actions.IsElementContainsText(lblquestioncode, "HQ0470"))
                {
                    Actions.Click(optionyes);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    //if (icount != 14)
                    //    Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else
                {
                    Actions.Click(optionno);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                    //if (icount != 14)
                    //    Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnfinish);
            Actions.Click(btnfinish);
            Verify.ElementContainsText(readmoremessage, "Thank you for your answers. Please ask for assistance.");
            Report.LogPassedTest("Donor Response questions are complete");
            Report.TakeScreenshot();

            Actions.Click(multibtnfinish);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


        }

        public void CompleteDRExpectedAnswersForeignLanguage(string strlanguage)
        {
            String questionnumber;
            int questiontotal;

            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lbllanguagepage);
            Actions.Click(selectlanguage);
            if (strlanguage == "Spanish")
            {
                Actions.Click(Spanishlanguage);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(btncontinuespanish);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            else if (strlanguage == "German")
            {
                Actions.Click(Germanlanguage);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(btncontinuegerman);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }

            else if (strlanguage == "French")
            {
                Actions.Click(Frenchlanguage);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(btncontinuefrench);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }

            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lblwelcomemessage);
            CommonActions.SetText(inputverify, "YES");
            if (strlanguage == "Spanish")
                Actions.Click(btncontinuespanish);
            else if (strlanguage == "German")
                Actions.Click(btncontinuegerman);
            else if (strlanguage == "French")
                Actions.Click(btncontinuefrench);


            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lblgreeting);
            if (strlanguage == "Spanish")
                Actions.Click(btncontinuespanish);
            else if (strlanguage == "German")
                Actions.Click(btncontinuegerman);
            else if (strlanguage == "French")
                Actions.Click(btncontinuefrench);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            if (Actions.IsElementPresent(readmoremessage))
                Actions.Click(btnok);

            if (strlanguage == "Spanish")
            {
                Verify.ElementIsPresent(btnreadmorespanish);
                Verify.ElementIsPresent(btnpreviousquestionspanish);
                Verify.ElementIsPresent(btnnextquestionspanish);
                Verify.ElementIsPresent(btnfinishspanish);
            }
            else if (strlanguage == "German")
            {
                Verify.ElementIsPresent(btnreadmoregerman);
                Verify.ElementIsPresent(btnpreviousquestiongerman);
                Verify.ElementIsPresent(btnnextquestiongerman);
                Verify.ElementIsPresent(btnfinishgerman);
            }
            else if (strlanguage == "French")
            {
                Verify.ElementIsPresent(btnreadmorefrench);
                Verify.ElementIsPresent(btnpreviousquestionfrench);
                Verify.ElementIsPresent(btnnextquestionfrench);
                Verify.ElementIsPresent(btnfinishfrench);
            }
            questionnumber = Actions.GetText(lblquestioncode).Substring(1, 6);

            if (gblGender == "F")
                questiontotal = 17;
            else
                questiontotal = 16;

            Waits.WaitForPageLoad();
            for (int icount = 1; icount < 16; icount++)
            {
                switch (questionnumber)
                {
                    case ("HQ0010"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "¿Es usted alérgico al Iodo y/o Látex?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Bist du allergisch gegen Jod und / oder Latex?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Êtes-vous allergique à l'iode et / ou au latex?");
                            Actions.Click(optionno);
                            Report.LogPassedTest("Health History questions are displayed in " + strlanguage);
                            Report.TakeScreenshot();
                            break;
                        }
                    case ("HQ0020"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "Te sientes bien y saludable hoy?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Fühlen Sie sich heute gut und gesund?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Vous vous sentez bien et en bonne santé aujourd'hui?");
                            Actions.Click(optionyes);
                            break;
                        }
                    case ("HQ0030"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "En las últimas 8 semanas, ¿ha dado sangre, plasma o plaquetas?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Haben Sie in den letzten 8 Wochen Blut, Plasma oder Blutplättchen erhalten?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Au cours des 8 dernières semaines, avez-vous donné du sang, du plasma ou des plaquettes?");
                            Actions.Click(optionno);
                            break;
                        }
                    case ("HQ0040"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "¿Alguna vez ha sido rechazado como donante de sangre o le han dicho que no done sangre?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Wurden Sie jemals als Blutspender abgelehnt oder aufgefordert, kein Blut zu spenden?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Avez-vous déjà été refusé en tant que donneur de sang ou on vous a dit de ne pas donner de sang?");
                            Actions.Click(optionno);
                            break;
                        }
                    case ("HQ0071"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "En las últimas 4 semanas, ¿ha tomado alguna píldora o medicamento?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Haben Sie in den letzten 4 Wochen Tabletten oder Medikamente eingenommen?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Au cours des 4 dernières semaines, avez-vous pris des pilules ou des médicaments?");
                            Actions.Click(optionno);
                            break;
                        }
                    case ("HQ0141"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "En las últimas 8 semanas, ¿ha recibido alguna vacuna o vacuna?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Hatten Sie in den letzten 8 Wochen Schüsse oder Impfungen?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Au cours des 8 dernières semaines, avez-vous reçu des vaccins ou des vaccins?");
                            Actions.Click(optionno);
                            break;
                        }
                    case ("HQ0160"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "En los últimos 12 meses, ¿le han administrado vacunas contra la rabia?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Haben Sie in den letzten 12 Monaten Tollwut bekommen?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Au cours des 12 derniers mois, avez-vous reçu des vaccins contre la rage?");
                            Actions.Click(optionno);
                            break;
                        }
                    case ("HQ0180"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "Mujer donante: en las últimas 6 semanas, ¿ha estado embarazada o está embarazada?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Spenderin: In den letzten 6 Wochen waren Sie schwanger oder sind Sie jetzt schwanger??");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Donneuse: Au cours des 6 dernières semaines, avez-vous été enceinte ou êtes-vous enceinte maintenant?");
                            Actions.Click(optionno);
                            break;
                        }

                    case ("HQ0234"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "Desde 1980, ¿has vivido o viajado a Europa?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Haben Sie seit 1980 in Europa gelebt oder waren Sie in Europa?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Depuis 1980, avez-vous déjà vécu ou voyagé en Europe?");
                            Actions.Click(optionno);
                            break;
                        }
                    case ("HQ0238"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "Desde 1980 hasta 1996, ¿fue usted miembro del Ejército de los EE. UU., Empleado civil civil o dependiente de un miembro del ejército de los EE. UU.?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Waren Sie von 1980 bis 1996 Mitglied des US-Militärs, Angehöriger eines zivilen Militärs oder Angehörigen eines US-Militärs?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "De 1980 à 1996, vous avez été membre de l’armée américaine, employé militaire civil ou membre d’un membre de l’armée américaine?");
                            Actions.Click(optionno);
                            break;
                        }
                    case ("HQ0239"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "¿Pasó un tiempo total de 6 meses o más asociado con una base militar en alguno de los siguientes países: Bélgica, Países Bajos, Alemania, España, Portugal, Turquía, Italia o Grecia?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Haben Sie in einem der folgenden Länder insgesamt mindestens 6 Monate mit einem Militärstützpunkt in Verbindung gebracht: Belgien, Niederlande, Deutschland, Spanien, Portugal, Türkei, Italien oder Griechenland?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Belgique, Pays-Bas, Allemagne, Espagne, Portugal, Turquie, Italie ou Grèce? Avez-vous passé au total 6 mois ou plus?");
                            Actions.Click(optionno);
                            break;
                        }
                    case ("HQ0691"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "¿Has viajado a algún país de malaria?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Sind Sie in ein Malaria-Land gereist?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Avez-vous voyagé dans des pays touchés par le paludisme?");
                            Actions.Click(optionno);
                            break;
                        }
                    case ("HQ0250"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "En los últimos 12 meses, ¿ha tenido un tatuaje, perforación de orejas o piel, acupuntura, electrólisis, punción accidental con la aguja o ha estado en contacto con la sangre de otra persona?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Hatten Sie in den letzten 12 Monaten eine Tätowierung, Ohr- oder Hautdurchdringung, Akupunktur, Elektrolyse, Nadelstiche oder sind Sie mit dem Blut einer anderen Person in Kontakt gekommen?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Au cours des 12 derniers mois, vous avez eu un tatouage, une perforation d'oreille ou de la peau, une acupuncture, une électrolyse, une piqûre accidentelle d'aiguille ou un contact avec le sang d'une autre personne?");

                            Actions.Click(optionno);
                            break;
                        }
                    case ("HQ0370"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "Mujeres donadoras: En los últimos 12 meses, ¿ha tenido relaciones sexuales con un hombre que ha tenido relaciones sexuales, incluso una vez desde 1977, con otro hombre?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Weibliche Spender: Hatten Sie in den letzten 12 Monaten Sex mit einem Mann, der seit 1977 einmal mit einem anderen Mann Sex hatte?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Femmes donateurs: Au cours des 12 derniers mois, avez-vous eu des relations sexuelles avec un homme qui a eu des relations sexuelles, même une fois depuis 1977, avec un autre homme?");

                            Actions.Click(optionno);
                            break;
                        }

                    case ("HQ0360"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "Donantes masculinos: ¿Ha tenido relaciones sexuales con otro varón, incluso una vez, desde 197?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Spenderinnen: Haben Sie seit 1977 einmal mit einem anderen Mann Sex gehabt?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Donneurs masculins: Avez-vous eu des relations sexuelles avec un autre homme, même une fois, depuis 1977?");

                            Actions.Click(optionno);
                            break;
                        }
                    case ("HQ0470"):
                        {
                            if (strlanguage == "Spanish")
                                Verify.ElementContainsText(lbldonorquestion, "¿Entiendes que si tienes el virus del SIDA, puedes contagiarlo a otra persona aunque te sientas bien y te hagan un examen de SIDA negativo?");
                            else if (strlanguage == "German")
                                Verify.ElementContainsText(lbldonorquestion, "Verstehen Sie, dass Sie das AIDS-Virus an jemand anderen weitergeben können, obwohl Sie sich wohl fühlen und einen negativen AIDS-Test haben?");
                            else if (strlanguage == "French")
                                Verify.ElementContainsText(lbldonorquestion, "Comprenez-vous que si vous avez le virus du sida, vous pouvez même lui faire passer un test de dépistage du sida négatif?");
                            Actions.Click(optionno);
                            break;
                        }
                    case ("D41"):
                        {
                            //Verify.ElementContainsText(lbldonorquestion, "¿Alguna vez ha tenido algún problema con su corazón o pulmones?");
                            Actions.Click(optionno);
                            break;
                        }



                }
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                if (Actions.GetText(lblquestioncode).Substring(1, 2) == "HQ")
                {
                    questionnumber = Actions.GetText(lblquestioncode).Substring(1, 6);
                }
                else
                {
                    questionnumber = Actions.GetText(lblquestioncode).Substring(1, 3);
                }
            }
            if (strlanguage == "Spanish")
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Verify.ElementIsPresent(btnfinishspanish);
                Actions.Click(btnfinishspanish);
                Verify.ElementContainsText(readmoremessage, "Gracias por sus respuestas. Por favor, pida ayuda.");
                Report.LogPassedTest("Donor Response questions are complete in Spanish");
                Report.TakeScreenshot();

                Actions.Click(multibtnfinishspanish);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                OnsiteHelper.Loginpopup();
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            else if (strlanguage == "German")
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Verify.ElementIsPresent(btnfinishgerman);
                Actions.Click(btnfinishgerman);
                Verify.ElementContainsText(readmoremessage, "Danke für deine Antworten. Bitte um Hilfe.");
                Report.LogPassedTest("Donor Response questions are complete in " + strlanguage);
                Report.TakeScreenshot();

                Actions.Click(multibtnfinishgerman);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                OnsiteHelper.Loginpopup();
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            else if (strlanguage == "French")
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Verify.ElementIsPresent(btnfinishfrench);
                Actions.Click(btnfinishfrench);
                Verify.ElementContainsText(readmoremessage, "Merci pour vos réponses. Veuillez demander de l'aide.");
                Report.LogPassedTest("Donor Response questions are complete in " + strlanguage);
                Report.TakeScreenshot();

                Actions.Click(multibtnfinishfrench);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                OnsiteHelper.Loginpopup();
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }



        }

        public void CompleteDRwithException()
        {

            //Question 1 HQ0010 is responded with YES
            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lbllanguagepage);
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lblwelcomemessage);
            CommonActions.SetText(inputverify, "YES");
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lblgreeting);
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            if (Actions.IsElementPresent(readmoremessage))
                Actions.Click(btnok);

            for (int icount = 1; icount < 15; icount++)
                if (Actions.IsElementContainsText(lblquestioncode, "HQ0010") ^ Actions.IsElementContainsText(lblquestioncode, "HQ0020") ^ Actions.IsElementContainsText(lblquestioncode, "HQ0470"))
                {
                    Actions.Click(optionyes);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    //if (icount != 14)
                    //    Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else
                {
                    Actions.Click(optionno);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

                    //if (icount != 14)
                    //    Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnfinish);
            Actions.Click(btnfinish);
            Verify.ElementContainsText(readmoremessage, "Thank you for your answers. Please ask for assistance.");
            Report.LogPassedTest("Donor Response questions are complete");
            Report.TakeScreenshot();

            Actions.Click(multibtnfinish);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


        }

        public void UpdateDRAnswer()
        {

            //Question 1 HQ0010 is responded with YES and update to No
            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lbllanguagepage);
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lblwelcomemessage);
            CommonActions.SetText(inputverify, "YES");
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lblgreeting);
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            if (Actions.IsElementPresent(readmoremessage))
                Actions.Click(btnok);

            for (int icount = 1; icount < 14; icount++)
                if (Actions.IsElementContainsText(lblquestioncode, "HQ0010") ^ Actions.IsElementContainsText(lblquestioncode, "HQ0020") ^ Actions.IsElementContainsText(lblquestioncode, "HQ0470"))
                {
                    Actions.Click(optionyes);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    if (Actions.IsElementContainsText(lblquestioncode, "HQ0020"))
                        Actions.Click(btnpreviousquestion);
                        Report.TakeScreenshot();
                        if (Actions.IsElementPresent(readmoremessage))
                            Actions.Click(btnok);
                        Actions.Click(optionno);
                        Report.TakeScreenshot();

                }
                else
                {
                    Actions.Click(optionno);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }



            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementIsPresent(btnfinish);
            Actions.Click(btnfinish);
            Verify.ElementContainsText(readmoremessage, "Thank you for your answers. Please ask for assistance.");
            Report.LogPassedTest("Donor Response questions are complete");
            Report.TakeScreenshot();

            Actions.Click(multibtnfinish);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void SkippedDRAnswer()
        {

            //Question 1 HQ0010 is skipped
            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lbllanguagepage);
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lblwelcomemessage);
            CommonActions.SetText(inputverify, "YES");
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Add verify the correct page is displayed
            Verify.ElementIsPresent(lblgreeting);
            Actions.Click(btncontinue);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            if (Actions.IsElementPresent(readmoremessage))
                Actions.Click(btnok);

            for (int icount = 1; icount < 15; icount++)
                if (Actions.IsElementContainsText(lblquestioncode, "HQ0010"))
                {
                    Actions.Click(btnnextquestion);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                }
                else if (Actions.IsElementContainsText(lblquestioncode, "HQ0020") ^ Actions.IsElementContainsText(lblquestioncode, "HQ0470"))
                    {
                    Actions.Click(optionyes);
                    //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    //if (icount != 14)
                    //    Actions.Click(btnnext);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                    }
                else
                    {
                    Actions.Click(optionno);
                    Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                     }

            Verify.ElementIsPresent(btnfinish);
            Actions.Click(btnfinish);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(readmoremessage, "Thank you for your answers. Please ask for assistance.");
            Report.LogPassedTest("Donor Response questions are complete");
            Report.TakeScreenshot();

            Actions.Click(multibtnfinish);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            OnsiteHelper.Loginpopup();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }
    }
}