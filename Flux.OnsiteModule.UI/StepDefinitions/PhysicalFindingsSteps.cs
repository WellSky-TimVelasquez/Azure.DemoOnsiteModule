using Flux.OnsiteModule.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Flux.OnsiteModule.UI.StepDefinitions
{
    [Binding]
    public class PhysicalFindingsSteps : OnsiteModule_TestBase
    {

        [Then(@"I can open Physical Findings")]
        public void ThenICanOpenPhysicalFindings()
        {
            Application.NewPage<PhysicalFindings>().OpenPhysicalFindingsScreen();
        }

        [Then(@"Valid Physical Findings entry is made")]
        public void ThenValidPhysicalFindingsEntryIsMade()
        {
            PhysicalFindingsData physicalfindingsdata = Application.TestDataBuilder.PhysicalFindings().Create();
            Application.NewPage<PhysicalFindings>().ValidALWBPhysicalFindings(physicalfindingsdata);
        }

        [Then(@"Physical Findings is completed")]
        public void ThenPhysicalFindingsIsCompleted()
        {
            Application.NewPage<PhysicalFindings>().PFComplete();
        }

        [Then(@"the statistics block is updated as complete")]
        public void ThenTheStatisticsBlockIsUpdatedAsComplete()
        {
            Application.NewPage<PhysicalFindings>().ConfirmStatisticsBlockPassed();
        }

        [Then(@"Valid AL PP Physical Findings entry is made")]
        public void ThenValidALPPPhysicalFindingsEntryIsMade()
        {
            PhysicalFindingsData physicalfindingsdata = Application.TestDataBuilder.ALPPHH().Create();
            Application.NewPage<PhysicalFindings>().ValidALPPPhysicalFindings(physicalfindingsdata);
        }

        [Then(@"Valid AL WB Physical Findings entry is made with initial value out of range and repeat in range")]
        public void ThenValidALWBPhysicalFindingsEntryIsMadeWithInitialValueOutOfRangeAndRepeatInRange()
        {
            PhysicalFindingsData physicalfindingsdata = Application.TestDataBuilder.PulseOutofRange().Create();
            Application.NewPage<PhysicalFindings>().ALWBPhysicalFindingsInitialOutofRangeRepeatinrange(physicalfindingsdata);
        }

        [Then(@"Valid AL WB Physical Findings entry is made with initial value out of range and repeat out of range")]
        public void ThenValidALWBPhysicalFindingsEntryIsMadeWithInitialValueOutOfRangeAndRepeatOutOfRange()
        {
            PhysicalFindingsData physicalfindingsdata = Application.TestDataBuilder.HGBOutofRange().Create(); 
            Application.NewPage<PhysicalFindings>().ALWBPhysicalFindingsInitialOutofRangeRepeatoutofrange(physicalfindingsdata);
        }

        [Then(@"the statistics block is updated as Deferred")]
        public void ThenTheStatisticsBlockIsUpdatedAsDeferred()
        {
            Application.NewPage<PhysicalFindings>().PFDeferredStatistics();
        }

        //[Then(@"defer the donor with (.*)")]
        //public void ThenDeferTheDonorWith(string deferralid)
        //{
        //    Application.NewPage<RegisterDonor>().EnterDeferralID();
        //}

        [Then(@"defer the donor")]
        public void ThenDeferTheDonor()
        {
            Application.NewPage<RegisterDonor>().EnterDeferralID();
        }


        [Then(@"Invalid AL WB Physical Findings with comment")]
        public void ThenInvalidALWBPhysicalFindingsWithComment()
        {
            PhysicalFindingsData physicalfindingsdata = Application.TestDataBuilder.TEMPOutofRange().Create();
            Application.NewPage<PhysicalFindings>().InvalidPhysicalFindingswithcomment(physicalfindingsdata);
        }

        [Then(@"the Physical Findings statistics block is updated with override")]
        public void ThenThePhysicalFindingsStatisticsBlockIsUpdatedWithOverride()
        {
            Application.NewPage<PhysicalFindings>().ConfirmPFStatisticsBlockOverride();
        }

        [Then(@"override the donor")]
        public void ThenOverrideTheDonor()
        {
            Application.NewPage<RegisterDonor>().OverrideDonor();
        }

        [Then(@"Valid Physical Findings entry is made with AU PP")]
        public void ThenValidPhysicalFindingsEntryIsMadeWithAUPP()
        {
            PhysicalFindingsData physicalfindingsdata = Application.TestDataBuilder.PhysicalFindings().Create();
            Application.NewPage<PhysicalFindings>().ValidAUPPPhysicalFindings(physicalfindingsdata);
        }

        [Then(@"the Physical Findings statistics block is updated with override and hold")]
        public void ThenThePhysicalFindingsStatisticsBlockIsUpdatedWithOverrideAndHold()
        {
            Application.NewPage<PhysicalFindings>().ConfirmPFStatisticsBlockOverrideHold();
        }

        [Then(@"the donor is deferred in the Onsite Status Query")]
        public void ThenTheDonorIsDeferredInTheOnsiteStatusQuery()
        {
            Application.NewPage<PhysicalFindings>().OnsiteStatusQueryDeferred();
        }

        [Then(@"I add equipment")]
        public void ThenIAddEquipment()
        {
            Application.NewPage<PhysicalFindings>().AddEquipment();
        }

        [Then(@"I add supplies")]
        public void ThenIAddSupplies()
        {
            Application.NewPage<PhysicalFindings>().AddSupplies();
        }


    }
}
