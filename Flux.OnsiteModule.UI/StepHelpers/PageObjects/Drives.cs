using Flux.Core;
using Flux.OnsiteModule.UI;
using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flux.OnsiteModule.UI//.StepHelpers.PageObjects
{
    public class Drives : OnsiteModule_PageBase
    {
        /** Need to create this for every page you are on when creating pages in pageobjects for classes**/
       
        private readonly By lnkactivatedrive = By.Id("link-activate-drive");
        private readonly By lnkcompletedrive = By.Id("link-complete-drive");
        private readonly By txtdrivedate = By.Id("input-choose-drive-date");
        private readonly By btnselectdrive = By.Id("button-select-drive");
        private readonly By rdodrive = By.Id("radio-drv0166701");
        private readonly By txtconfirmdrive = By.Id("input-");
        private readonly By btnok = By.Id("button-ok");
        private readonly By btncancel = By.Id("button-cancel"); 
        private readonly By btncompletedrive = By.Id("button-complete-drive");
        private readonly By txtdriveidfooter = By.Id("driveIDFooter");
        private readonly By btngotoactivatedrive = By.Id("button-go-to-activate-drive-screen");
        private readonly By gridresults = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/div/div/app-activate-drive/div/div/div/mat-card/div[1]/div/app-mat-table/table/tbody");

        //Sample Method using Actions, Waits, Verify :) 
        public void OpenActivateDriveScreen()
        {
            if(Actions.IsDisplayed(btngotoactivatedrive))
            {
                Actions.Click(btngotoactivatedrive);
            }
            else
            {
                Actions.Click(lnkactivatedrive);
            }
            CommonActions.WaitForPageLoad();
            Verify.ExactPageTitle(ONSITEACTIVATEDRIVE);
        }

        public void OpenCompleteDriveScreen()
        {
            Actions.Click(lnkcompletedrive);
            Waits.WaitForPageLoad();
            Verify.ExactPageTitle(ONSITECOMPLETEDRIVE);

        }
        public void EnterDriveDate()
        {
            Verify.ExactPageTitle("BC-Onsite (Activate Drive)");
            Actions.SendKeys(txtdrivedate, Keys.Control + "a");
            Actions.SendKeys(txtdrivedate, Keys.Delete);
            CommonActions.SetText(txtdrivedate, "03/02/2019");
            Actions.SendKeys(txtdrivedate, Keys.Enter);
            Waits.WaitForElementToBeVisible(gridresults, WaitType.Small);
            CommonActions.WaitForPageLoad();
            Waits.WaitForElementToBeClickable(rdodrive, WaitType.Small);
            Actions.Click(rdodrive);
            Report.TakeScreenshot();
            Actions.Click(btnselectdrive);
            Report.TakeScreenshot();
            CommonActions.SetText(txtconfirmdrive, "DRV0166701");
            Report.TakeScreenshot();
            //Actions.Click(btnok);
            //Waits.WaitForPageLoad();
            //Verify.ExactPageTitle("BC-Onsite (Onsite Menu)");
            //Verify.ElementContainsText(txtdriveidfooter, "DRV0166698");

        }
    }
}
