using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class BleedSteps : OnsiteModule_TestBase
    {

        [Then(@"I enter bleed information")]
        public void ThenIEnterBleedInformation()
        {
            //Application.NewPage<Bleed>().OpenBleedScreen();
            BleedData bleeddata = Application.TestDataBuilder.Bleed().Create();

            Application.NewPage<Bleed>().BleedEntry(bleeddata);

        }

        [Then(@"donation is set to complete in Onsite Status Query")]
        public void ThenDonationIsSetToCompleteInOnsiteStatusQuery()
        {
            Application.NewPage<Bleed>().OnsiteStatusQueryBleed();
        }

        [Then(@"I enter bleed information for AL PP")]
        public void ThenIEnterBleedInformationForALPP()
        {
            //Application.NewPage<Bleed>().OpenBleedScreen();
            BleedData bleeddata = Application.TestDataBuilder.Bleed().Create();

            Application.NewPage<Bleed>().BleedEntryALPP(bleeddata);
        }

        [Then(@"I update the procedure code to PP")]
        public void ThenIUpdateTheProcedureCodeToPP()
        {

            Application.NewPage<Bleed>().OpenBleedScreen();
            Application.NewPage<Bleed>().UpdateProceduretoPP();
        }

        [Then(@"I update the procedure code to WB")]
        public void ThenIUpdateTheProcedureCodeToWB()
        {
            Application.NewPage<Bleed>().OpenBleedScreen();
            Application.NewPage<Bleed>().UpdateProceduretoWB();
        }

        [Then(@"I open the bleed screen")]
        public void ThenIOpenTheBleedScreen()
        {
            Application.NewPage<Bleed>().OpenBleedScreen();
        }

        [Given(@"I open the bleed screen")]
        public void GivenIOpenTheBleedScreen()
        {
            Application.NewPage<Bleed>().OpenBleedScreen();
        }


        [Then(@"I add bleed equipment")]
        public void ThenIAddBleedEquipment()
        {
            Application.NewPage<Bleed>().AddBleedEquipment();
        }

        [Then(@"I add bleed supplies")]
        public void ThenIAddBleedSupplies()
        {
            Application.NewPage<Bleed>().AddBleedSupplies();
        }

        [Then(@"I enter bleed information outside drive times")]
        public void ThenIEnterBleedInformationOutsideDriveTimes()
        {
            BleedData bleeddata = Application.TestDataBuilder.Bleed().Create();

            Application.NewPage<Bleed>().Bleedtimeoutofrange(bleeddata);
        }


    }
}
