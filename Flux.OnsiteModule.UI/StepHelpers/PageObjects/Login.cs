
using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flux.OnsiteModule.UI
{
    /// <summary>
    ///  This class will provide all the necessary methods to deal with Login page.
    /// </summary>
    /// 

    public class Login : OnsiteModule_PageBase
    {

        #region PageObjects
        /** Need to create this for every page you are on when creating pages in pageobjects for classes**/
        private readonly string LoginURL = "/BCOnsiteUI/login";
        public override string URL => LoginURL;

        private readonly By txtUsername = By.Id("input-username");
        private readonly By txtPassword = By.Id("input-password");
        private readonly By btnLogin = By.Id("button-login");
        private readonly By txterror = By.Id("error-message");
        private readonly By btnActivateDrive = By.Id("button-go-to-activate-drive-screen");


        #endregion

        //Sample Method using Actions, Waits, Verify :) 
        public void LoginAsAdmin(string username, string password)
        {
            string url = WebEnvironment.AppSettings["AppUrl"];
            Console.WriteLine(url, " this is url attempted to hit");
            Log.Info(url);
            Actions.NavigateToUrl(url);
            CommonActions.WaitForPageLoad();
            Verify.ExactPageTitle(ONSITELOGIN);
            CommonActions.SetText(txtUsername, username);
            CommonActions.SetText(txtPassword, password);
            Report.LogInfo("Enter Username and Password");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.TakeScreenshot();
            Actions.Click(btnLogin);
            CommonActions.WaitForPageLoad();

        }

        public void LoginVerify()
        {
            CommonActions.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(ONSITEMODULEMAINMENU);
            Report.LogInfo("User is logged in and Onsite Menu is displayed.");
            Report.TakeScreenshot();

        }

        public void InvalidLoginVerify()
        {
            CommonActions.WaitForPageLoad();
            Waits.WaitForAlertToBePresent(Core.WaitType.Small);
            Report.LogInfo("Invalid login message is displayed");
            Report.TakeScreenshot();
            Verify.VerifyBrowserAlertMsg("Invalid Login", Core.WaitType.Small);
        }

        public void NullLoginVerify()
        {
            CommonActions.WaitForPageLoad();
            Report.LogInfo("Null login message is displayed");
            Report.TakeScreenshot();
            Waits.WaitForElementToBeVisible(txterror, Core.WaitType.Small);
        }
    }
}
