using System;
using System.Collections.Generic;
using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Linq;

namespace Flux.OnsiteModule.UI
{
    public class CommonActions
    {
        private ILogger logger;

        public CommonActions(WebEnvironment testEnvironment)
        {
            TestEnvironment = testEnvironment;
            Waits = new WebWaits(testEnvironment);
            Actions = new WebActions(testEnvironment);
            Driver = new DriverManager();
            Verify = new WebVerify(testEnvironment);
            Logger = new Logger();
        }

        private ILogger Logger { get; set; }
        private WebWaits Waits { get; set; }

        private WebActions Actions { get; set; }

        private WebVerify Verify { get; set; }

        private WebEnvironment TestEnvironment { get; set; }

        private DriverManager Driver { get; set; }

        //Common method to Tab or Set and Send text
        public void SetText(By strlocator, String strvalue)
        {
            if (strvalue == "^")
                Actions.PressKey(Keys.Tab, strlocator);
            else
                Actions.SendKeys(strlocator, strvalue);
            Actions.PressKey(Keys.Tab, strlocator);

        }

        
        public void WaitForPageLoad()
        {
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), WaitType.Small);

        }

    



    }
}
