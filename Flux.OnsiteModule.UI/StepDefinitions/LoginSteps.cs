using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flux.Web;
using TechTalk.SpecFlow;


namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class LoginSteps : OnsiteModule_TestBase
    {

        [Given(@"I open application home page")]
        public void GivenIOpenApplicationHomePage()
        {
            Application.NewPage<Login>().LoginVerify();
        }

        [Given(@"I login the application")]
        public void GivenILoginTheApplication()
        {
            //Application.NewPage<Login>().LoginAsAdmin("eiltoy", "et1234");
            Login login = Application.NewPage<Login>();
            login.LoginAsAdmin(WebEnvironment.AppSettings["AppUserName"], WebEnvironment.AppSettings["AppPassword"]);

        }

        [Given(@"An invalid user logs into the application")]
        public void GivenAnInvalidUserLogsIntoTheApplication()
        {
            //Application.NewPage<Login>().LoginAsAdmin("test", "et1234");
            Login login = Application.NewPage<Login>();
            login.LoginAsAdmin("test", WebEnvironment.AppSettings["AppPassword"]);

        }

        [Given(@"I get invalid login message")]
        public void GivenIGetInvalidLoginMessage()
        {
            Application.NewPage<Login>().InvalidLoginVerify();

        }

        [Given(@"A null user logs into the application")]
        public void GivenANullUserLogsIntoTheApplication()
        {
            //Application.NewPage<Login>().LoginAsAdmin("^", "et1234");
            Login login = Application.NewPage<Login>();
            login.LoginAsAdmin("^", WebEnvironment.AppSettings["AppPassword"]);

        }

        [Given(@"I get null login message")]
        public void GivenIGetNullLoginMessage()
        {
            Application.NewPage<Login>().NullLoginVerify();
        }

        [Given(@"A user with null password logs into the application")]
        public void GivenAUserWithNullPasswordLogsIntoTheApplication()
        {
            //Application.NewPage<Login>().LoginAsAdmin("eiltoy", "^");
            Login login = Application.NewPage<Login>();
            login.LoginAsAdmin(WebEnvironment.AppSettings["AppUserName"], "^");

        }

    }

   
}
