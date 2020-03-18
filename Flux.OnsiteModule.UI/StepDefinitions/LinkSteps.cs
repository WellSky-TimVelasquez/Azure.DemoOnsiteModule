using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class LinkSteps : OnsiteModule_TestBase
    {

        [Then(@"I open the link screen")]
        public void ThenIOpenTheLinkScreen()
        {
            Application.NewPage<Link>().OpenLinkFromHHPF();
        }

        //[Then(@"I link unit number (.*) to the donation")]
        //public void ThenILinkUnitNumberToTheDonation(string unitid)
        //{
        //    Application.NewPage<Link>().LinkUnit();
        //}

        [Then(@"I link unit number to the donation")]
        public void ThenILinkUnitNumberToTheDonation()
        {
            Application.NewPage<Link>().LinkUnit();
        }


        [Then(@"the unit is linked")]
        public void ThenTheUnitIsLinked()
        {
            Application.NewPage<Link>().UnitinLinkQuery(OnsiteModule_PageBase.gblunitdeferralid);
        }

        //[Then(@"I unlink the unit id (.*)")]
        //public void ThenIUnlinkTheUnitId(string unitid)
        //{
        //    Application.NewPage<Link>().UnlinkUnit(unitid);
        //}

        [Then(@"I unlink the unit id")]
        public void ThenIUnlinkTheUnitId()
        {
            Application.NewPage<Link>().UnlinkUnit();
        }


        [Then(@"the unit id is unlinked in Link Query")]
        public void ThenTheUnitIdIsUnlinkedInLinkQuery()
        {
            
            Application.NewPage<Link>().NoUnitinLinkQuery(OnsiteModule_PageBase.gblunitdeferralid);
        }

        [Then(@"I open the link screen from the menu")]
        public void ThenIOpenTheLinkScreenFromTheMenu()
        {
            Application.NewPage<Link>().OpenLinkFromMenu();
            Application.NewPage<HealthHistoryParentForm>().SelectDonor();
        }

        [Then(@"a (.*) is entered to void the unit")]
        public void ThenAIsEnteredToVoidTheUnit(string newunitid)
        {
            Application.NewPage<Link>().LinkNewUnit();
        }

        [Then(@"the void information is entered")]
        public void ThenTheVoidInformationIsEntered()
        {
            Application.NewPage<Link>().Voidinformation();
        }

        //[Given(@"I link temporary (.*) to the donation")]
        //public void GivenILinkTemporaryToTheDonation(string deferralid)
        //{
        //    Application.NewPage<Link>().LinkTemporaryDeferral(deferralid);
        //}

        [Given(@"I link temporary deferral id to the donation")]
        public void GivenILinkTemporaryDeferralIdToTheDonation()
        {
            Application.NewPage<Link>().LinkTemporaryDeferral();
        }


        [Given(@"I open the link screen from the menu for a deferral")]
        public void GivenIOpenTheLinkScreenFromTheMenuForADeferral()
        {
            Application.NewPage<Link>().OpenLinkFromMenu();
            Application.NewPage<Link>().OpenLinkUnlinkDeferralTab();
            Application.NewPage<HealthHistoryParentForm>().SelectDonor();
        }

        //[Given(@"I link permanent (.*) to the donation")]
        //public void GivenILinkPermanentToTheDonation(string deferralid)
        //{
        //    Application.NewPage<Link>().LinkPermanentDeferral(deferralid);
        //}

        [Given(@"I link permanent deferral id to the donation")]
        public void GivenILinkPermanentDeferralIdToTheDonation()
        {
            Application.NewPage<Link>().LinkPermanentDeferral();
        }

        [Then(@"I unlink the deferral id")]
        public void ThenIUnlinkTheDeferralId()
        {
            Application.NewPage<Link>().UnlinkDeferral();
            
        }

        [Then(@"I open the link screen from the menu for a deferral")]
        public void ThenIOpenTheLinkScreenFromTheMenuForADeferral()
        {
            Application.NewPage<Link>().OpenLinkFromMenu();
            Application.NewPage<Link>().OpenLinkUnlinkDeferralTab();
            Application.NewPage<HealthHistoryParentForm>().SelectDonor();
        }

    }
}
