using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class EquipmentSteps : OnsiteModule_TestBase
    {

        [Given(@"I open the Equipment screen")]
        public void GivenIOpenTheEquipmentScreen()
        {
            Application.NewPage<Equipment>().OpenEquipment();
        }

        [Given(@"I select a Drive Profile of WBPP")]
        public void GivenISelectADriveProfileOfWBPP()
        {
            Application.NewPage<Equipment>().SelectDriveProfile();
        }

        [Given(@"I enter BP with a status of PASS")]
        public void GivenIEnterBPWithAStatusOfPASS()
        {
            EquipmentData equipmentdata = Application.TestDataBuilder.Equipment().Create();
            Application.NewPage<Equipment>().AddBPCuff(equipmentdata);
        }

        [Given(@"I enter AMIC with a status of PASS")]
        public void GivenIEnterAMICWithAStatusOfPASS()
        {
            EquipmentData equipmentdata = Application.TestDataBuilder.Equipment().Create();
            Application.NewPage<Equipment>().AddAmic(equipmentdata);
        }

        [Given(@"I enter SCALE with a status of PASS")]
        public void GivenIEnterSCALEWithAStatusOfPASS()
        {
            EquipmentData equipmentdata = Application.TestDataBuilder.Equipment().Create();
            Application.NewPage<Equipment>().AddScale(equipmentdata);
        }

        [Given(@"I save the equipment and supply")]
        public void GivenISaveTheEquipmentAndSupply()
        {
            Application.NewPage<Equipment>().SaveEquipment();
        }


        [Given(@"I enter BP Cuff with a status of PASS")]
        public void GivenIEnterBPCuffWithAStatusOfPASS()
        {
            EquipmentData equipmentdata = Application.TestDataBuilder.Equipment().Create();
            Application.NewPage<Equipment>().AddBPCuff(equipmentdata);
        }

        [Given(@"I enter Alyx with a status of PASS")]
        public void GivenIEnterAlyxWithAStatusOfPASS()
        {
            EquipmentData equipmentdata = Application.TestDataBuilder.Equipment().Create();
            Application.NewPage<Equipment>().AddAlyx(equipmentdata);
        }

        [Given(@"I enter HCUE with a status of PASS")]
        public void GivenIEnterHCUEWithAStatusOfPASS()
        {
            EquipmentData equipmentdata = Application.TestDataBuilder.Equipment().Create();
            Application.NewPage<Equipment>().AddHcue(equipmentdata);
        }

        [Given(@"I enter Ther with a status of PASS")]
        public void GivenIEnterTherWithAStatusOfPASS()
        {
            EquipmentData equipmentdata = Application.TestDataBuilder.Equipment().Create();
            Application.NewPage<Equipment>().AddTher(equipmentdata);
        }

        [Given(@"I enter Trim with a status of PASS")]
        public void GivenIEnterTrimWithAStatusOfPASS()
        {
            EquipmentData equipmentdata = Application.TestDataBuilder.Equipment().Create();
            Application.NewPage<Equipment>().AddTrim(equipmentdata);
        }

        [Given(@"I enter Vist with a status of PASS")]
        public void GivenIEnterVistWithAStatusOfPASS()
        {
            EquipmentData equipmentdata = Application.TestDataBuilder.Equipment().Create();
            Application.NewPage<Equipment>().AddVist(equipmentdata);
        }

        [Given(@"I open the Supply screen")]
        public void GivenIOpenTheSupplyScreen()
        {
            Application.NewPage<Equipment>().OpenSupply();
        }

        [Given(@"I enter CB with a status of PASS")]
        public void GivenIEnterCBWithAStatusOfPASS()
        {
            Application.NewPage<Equipment>().AddCb();
        }

        [Given(@"I enter Lance with a status of PASS")]
        public void GivenIEnterLanceWithAStatusOfPASS()
        {
            Application.NewPage<Equipment>().AddLance();
        }

        [Given(@"I enter Bags with a status of PASS")]
        public void GivenIEnterBagsWithAStatusOfPASS()
        {
            Application.NewPage<Equipment>().AddBags();
        }

        [Given(@"I enter Chlop with a status of PASS")]
        public void GivenIEnterChlopWithAStatusOfPASS()
        {
            Application.NewPage<Equipment>().AddChlop();
        }

        [Given(@"I enter PPKit with a status of PASS")]
        public void GivenIEnterPPKitWithAStatusOfPASS()
        {
            Application.NewPage<Equipment>().AddPpkit();
        }

        [Given(@"I enter Tums with a status of PASS")]
        public void GivenIEnterTumsWithAStatusOfPASS()
        {
            Application.NewPage<Equipment>().AddTums();
        }

        [Given(@"I enter Wb Kit with a status of PASS")]
        public void GivenIEnterWbKitWithAStatusOfPASS()
        {
            Application.NewPage<Equipment>().AddWbkit();
        }

    }
}
