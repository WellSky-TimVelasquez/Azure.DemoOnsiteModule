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
    class Equipment : OnsiteModule_PageBase
    {

        #region PageObjects
        //Equipment
        private readonly By lnkequipment = By.Id("link-equipment--supply-qc");
        private readonly By selectedprofile = By.Id("label-qc-drive-profile");
        private readonly By seldriveprofile = By.Id("drive-profile-select");
        private readonly By selwbpp = By.Id("option-WBPP"); 
        private readonly By btnok = By.Id("button-ok");
        private readonly By seltrim = By.Id("option-TRIM");
        private readonly By supplytab = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/app-onsite-router/div/div/app-equipment-qc/app-qc-entry/main/mat-tab-group/mat-tab-header/div[2]/div/div/div[2]/div");

        private readonly By lblchapterdate = By.Id("label-chapter-date-time");
        private readonly By lblusername = By.Id("label-username");

        private readonly By txtcaldt = By.Id("input-qc-date");
        private readonly By txtsrn = By.Id("input-qc-date");
        private readonly By txtwipe = By.Id("input-qc-date");
        private readonly By txtequip = By.Id("input-qc-date");
        private readonly By txtelec = By.Id("input-qc-date");

        private readonly string txtalyxscan = "//*[starts-with(@id, 'ALYX-') and contains(@id, 'input-scan')]";
        private readonly string txtalyxrefno = "//*[starts-with(@id, 'ALYX-') and contains(@id, 'input-scan-refno')]";
        private readonly string txtamicscan = "//*[starts-with(@id, 'AMIC-') and contains(@id, 'input-scan')]";
        private readonly string txtamicrefno = "//*[starts-with(@id, 'AMIC-') and contains(@id, 'input-scan-refno')]";
        private readonly string txtbpscan = "//*[starts-with(@id, 'BP-') and contains(@id, 'input-scan')]";
        private readonly string txtbprefno = "//*[starts-with(@id, 'BP-') and contains(@id, 'input-scan-refno')]";
        private readonly string txthcuescan = "//*[starts-with(@id, 'HCUE-') and contains(@id, 'input-scan')]";
        private readonly string txthcuerefno = "//*[starts-with(@id, 'HCUE-') and contains(@id, 'input-scan-refno')]";
        private readonly string txtscalescan = "//*[starts-with(@id, 'SCALE-') and contains(@id, 'input-scan')]";
        private readonly string txtscalerefno = "//*[starts-with(@id, 'SCALE-') and contains(@id, 'input-scan-refno')]";
        private readonly string txttherscan = "//*[starts-with(@id, 'THER-') and contains(@id, 'input-scan')]";
        private readonly string txttherrefno = "//*[starts-with(@id, 'THER-') and contains(@id, 'input-scan-refno')]";
        private readonly string txttrimscan = "//*[starts-with(@id, 'TRIM-') and contains(@id, 'input-scan')]";
        private readonly string txttrimrefno = "//*[starts-with(@id, 'TRIM-') and contains(@id, 'input-scan-refno')]";
        private readonly string txtvistscan = "//*[starts-with(@id, 'VIST-') and contains(@id, 'input-scan')]";
        private readonly string txtvistrefno = "//*[starts-with(@id, 'VIST-') and contains(@id, 'input-scan-refno')]";
        private readonly string lnkalyx = "//*[starts-with(@id, 'label-ALYX-')]";
        private readonly string lnkamic = "//*[starts-with(@id, 'label-AMIC-')]";
        private readonly string lnkbp = "//*[starts-with(@id, 'label-BP-')]";
        private readonly string lnkhcue = "//*[starts-with(@id, 'label-HCUE-')]";
        private readonly string lnkscale = "//*[starts-with(@id, 'label-SCALE-')]";
        private readonly string lnkther = "//*[starts-with(@id, 'label-THER-')]";
        private readonly string lnktrim = "//*[starts-with(@id, 'label-TRIM-')]";
        private readonly string lnkvist = "//*[starts-with(@id, 'label-VIST-')]";
        private readonly string txtalyxcaldt = "//*[starts-with(@id, 'ALYX-')and contains(@id, 'CALDT')]";
        private readonly string txtalyxequip = "//*[starts-with(@id, 'ALYX-')and contains(@id, 'EQUIP')]";
        private readonly string txtalyxwipe = "//*[starts-with(@id, 'ALYX-')and contains(@id, 'WIPE')]";
        private readonly string txtamiccaldt = "//*[starts-with(@id, 'AMIC-')and contains(@id, 'CALDT')]";
        private readonly string txtamicelec = "//*[starts-with(@id, 'AMIC-')and contains(@id, 'ELEC')]";
        private readonly string txtamicwipe = "//*[starts-with(@id, 'AMIC-')and contains(@id, 'WIPE')]";
        private readonly string txtamicequip = "//*[starts-with(@id, 'AMIC-')and contains(@id, 'EQUIP')]";
        private readonly string txtamicsrn = "//*[starts-with(@id, 'AMIC-')and contains(@id, 'SRN')]";
        private readonly string txtbpequip = "//*[starts-with(@id, 'BP-')and contains(@id, 'EQUIP')]";
        private readonly string txtbpelec = "//*[starts-with(@id, 'BP-')and contains(@id, 'ELEC')]";
        private readonly string txtbpcaldt = "//*[starts-with(@id, 'BP-')and contains(@id, 'CALDT')]";
        private readonly string txthcuecaldt = "//*[starts-with(@id, 'HCUE-')and contains(@id, 'CALDT')]";
        private readonly string txthcueelec = "//*[starts-with(@id, 'HCUE-')and contains(@id, 'ELEC')]";
        private readonly string txthcuewipe = "//*[starts-with(@id, 'HCUE-')and contains(@id, 'WIPE')]";
        private readonly string txthcuevolum = "//*[starts-with(@id, 'HCUE-')and contains(@id, 'VOLUM')]";
        private readonly string txtscalesrn = "//*[starts-with(@id, 'SCALE-')and contains(@id, 'SRN')]";
        private readonly string txtscalecaldt = "//*[starts-with(@id, 'SCALE-')and contains(@id, 'CALDT')]";
        private readonly string txtscale1000 = "//*[starts-with(@id, 'SCALE-')and contains(@id, '1000')]";
        private readonly string txtscale500 = "//*[starts-with(@id, 'SCALE-')and contains(@id, '500')]";
        private readonly string txtref10scan = "//*[starts-with(@id, 'SCALE-')and contains(@id, 'REF10')and contains(@id, 'input-scan')]";
        private readonly string txtrefnoscan = "//*[starts-with(@id, 'SCALE-')and contains(@id, 'REFNO')and contains(@id, 'input-scan')]";
        private readonly string txtref10entry = "//*[starts-with(@id, 'SCALE-')and contains(@id, 'REF10')and contains(@id, 'input-scan-refno')]";
        private readonly string txtrefnoentry = "//*[starts-with(@id, 'SCALE-')and contains(@id, 'REFNO')and contains(@id, 'input-scan-refno')]";
        private readonly string txttrimsrn = "//*[starts-with(@id, 'TRIM-')and contains(@id, 'SRN')]";
        private readonly string txttrimwipe = "//*[starts-with(@id, 'TRIM-')and contains(@id, 'WIPE')]";
        private readonly string txttrimequip = "//*[starts-with(@id, 'TRIM-')and contains(@id, 'EQUIP')]";
        private readonly string txttrimelec = "//*[starts-with(@id, 'TRIM-')and contains(@id, 'ELEC')]";
        private readonly string txttrimcaldt = "//*[starts-with(@id, 'TRIM-')and contains(@id, 'CALDT')]";
        private readonly string txtvistcaldt = "//*[starts-with(@id, 'VIST-')and contains(@id, 'CALDT')]";
        private readonly string txtvistcfail = "//*[starts-with(@id, 'VIST-')and contains(@id, 'CFAIL')]";
        private readonly string txtvistsrn = "//*[starts-with(@id, 'VIST-')and contains(@id, 'SRN')]";
        private readonly string txtvistwipe = "//*[starts-with(@id, 'VIST-')and contains(@id, 'WIPE')]";
        private readonly string txtvistequip = "//*[starts-with(@id, 'VIST-')and contains(@id, 'EQUIP')]";
        private readonly string txtvistelec = "//*[starts-with(@id, 'VIST-')and contains(@id, 'ELEC')]";
        private readonly string txtthersrn = "//*[starts-with(@id, 'THER-')and contains(@id, 'SRN')]";
        private readonly string txtobkbprefnovalue = "//*[starts-with(@id, 'label-EQ-000326')]";
        private readonly string txtobkalyxrefnovalue = "//*[starts-with(@id, 'label-EQ-000343')]";
        private readonly string txtobkamicrefnovalue = "//*[starts-with(@id, 'label-EQ-000286')]";
        private readonly string txtobkhcuerefnovalue = "//*[starts-with(@id, 'label-EQ-000339')]";
        private readonly string txtobkscalerefnovalue = "//*[starts-with(@id, 'label-EQ-000330')]";
        private readonly string txtobktherrefnovalue = "//*[starts-with(@id, 'label-EQ-000328')]";
        private readonly string txtobktrimrefnovalue = "//*[starts-with(@id, 'label-EQ-000277')]";
        private readonly string txtobkvistrefnovalue = "//*[starts-with(@id, 'label-EQ-000338')]";
        private readonly string txtdalbprefnovalue = "//*[starts-with(@id, 'label-EQ-000314')]";
        private readonly string txtdalalyxrefnovalue = "//*[starts-with(@id, 'label-EQ-000241')]";
        private readonly string txtdalamicrefnovalue = "//*[starts-with(@id, 'label-EQ-000308')]";
        private readonly string txtdalhcuerefnovalue = "//*[starts-with(@id, 'label-EQ-000312')]";
        private readonly string txtdalscalerefnovalue = "//*[starts-with(@id, 'label-EQ-000297')]";
        private readonly string txtdaltherrefnovalue = "//*[starts-with(@id, 'label-EQ-000303')]";
        private readonly string txtdaltrimrefnovalue = "//*[starts-with(@id, 'label-EQ-000270')]";
        private readonly string txtdalvistrefnovalue = "//*[starts-with(@id, 'label-EQ-000245')]";
        //Supplies
        private readonly string lnkcb = "//*[starts-with(@id, 'label-CB-')]";
        private readonly string lnkbag = "//*[starts-with(@id, 'label-BAG-')]";
        private readonly string lnkchlop = "//*[starts-with(@id, 'label-CHLOP-')]";
        private readonly string lnklance = "//*[starts-with(@id, 'label-LANCE-')]";
        private readonly string lnkppkit = "//*[starts-with(@id, 'label-PPKIT-')]";
        private readonly string lnktums = "//*[starts-with(@id, 'label-TUMS-')]";
        private readonly string lnkwbkit = "//*[starts-with(@id, 'label-WBKIT-')]";

        private readonly string txtcbvis = "//*[starts-with(@id, 'CB-')and contains(@id, 'VIS')]";
        private readonly string txtbagexpdt = "//*[starts-with(@id, 'BAG-')and contains(@id, 'EXPDT')]";
        private readonly string txtbagcatlgscan = "//*[starts-with(@id, 'BAG-')and contains(@id, 'CATLG')and contains(@id, 'input-scan')]";
        private readonly string txtbagcatlg = "//*[starts-with(@id, 'BAG-')and contains(@id, 'CATLG')and contains(@id, 'input-scan-catalog')]";
        private readonly string txtbaglotscan = "//*[starts-with(@id, 'BAG-')and contains(@id, 'LOT')and contains(@id, 'input-scan')]";
        private readonly string txtbaglot = "//*[starts-with(@id, 'BAG-')and contains(@id, 'LOT')and contains(@id, 'input-scan-lot')]";
        private readonly string txtbagopcon = "//*[starts-with(@id, 'BAG-')and contains(@id, 'OPCON')]";
        private readonly string txtchloplot = "//*[starts-with(@id, 'CHLOP-')and contains(@id, 'LOT')]";
        private readonly string txtchlopexpdt = "//*[starts-with(@id, 'CHLOP-')and contains(@id, 'EXPDT')]";
        private readonly string txtlancevis = "//*[starts-with(@id, 'LANCE-')and contains(@id, 'VIS')]";
        private readonly string txtppkitvis = "//*[starts-with(@id, 'PPKIT-')and contains(@id, 'VIS')]";
        private readonly string txtppkitlotscan = "//*[starts-with(@id, 'PPKIT-')and contains(@id, 'LOT')and contains(@id, 'input-scan')]";
        private readonly string txtppkitlot = "//*[starts-with(@id, 'PPKIT-')and contains(@id, 'LOT')and contains(@id, 'input-scan-lot')]";
        private readonly string txttumsvis = "//*[starts-with(@id, 'TUMS-')and contains(@id, 'VIS')]";
        private readonly string txtwbkitlotscan = "//*[starts-with(@id, 'WBKIT-')and contains(@id, 'LOT')and contains(@id, 'input-scan')]";
        private readonly string txtwbkitlot = "//*[starts-with(@id, 'WBKIT-')and contains(@id, 'LOT')and contains(@id, 'input-scan-lot')]";

        private readonly string lblpasscb = "//*[starts-with(@id, 'status-CB-')]";
        private readonly string lblpassbag = "//*[starts-with(@id, 'status-BAG-')]";
        private readonly string lblpasschlop = "//*[starts-with(@id, 'status-CHLOP-')]";
        private readonly string lblpasslance = "//*[starts-with(@id, 'status-LANCE-')]";
        private readonly string lblpassppkit = "//*[starts-with(@id, 'status-PPKIT-')]";
        private readonly string lblpasstums = "//*[starts-with(@id, 'status-TUMS-')]";
        private readonly string lblpasswbkit = "//*[starts-with(@id, 'status-WBKIT-')]";

        private readonly By btnsave = By.Id("button-save");
        private readonly By btnoksave = By.Id("multi-button-ok");

        #endregion

        #region Getters/Setters

        public string OBKALYX
        {
            get => Actions.GetAttributeValue(By.XPath(txtalyxrefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtalyxrefno), value);
                    GlobalData.Set("gblalyx", value);
                }
            }
        }

        public string OBKBP
        {
            get => Actions.GetAttributeValue(By.XPath(txtbprefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtbprefno), value);
                    GlobalData.Set("gblbp", value);
                }
            }
        }

        public string OBKAMIC
        {
            get => Actions.GetAttributeValue(By.XPath(txtamicrefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtamicrefno), value);
                    GlobalData.Set("gblamic", value);
                }
            }
        }

        public string OBKHCUE
        {
            get => Actions.GetAttributeValue(By.XPath(txthcuerefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txthcuerefno), value);
                    GlobalData.Set("gblHcue", value);
                }
            }
        }

        public string OBKSCALE
        {
            get => Actions.GetAttributeValue(By.XPath(txtscalerefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtscalerefno), value);
                    GlobalData.Set("gblScale", value);
                }
            }
        }

        public string OBKTHER
        {
            get => Actions.GetAttributeValue(By.XPath(txttherrefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txttherrefno), value);
                    GlobalData.Set("gblther", value);
                }
            }
        }

        public string OBKTRIM
        {
            get => Actions.GetAttributeValue(By.XPath(txttrimrefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txttrimrefno), value);
                    GlobalData.Set("gbltrim", value);
                }
            }
        }

        public string OBKVIST
        {
            get => Actions.GetAttributeValue(By.XPath(txtvistrefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtvistrefno), value);
                    GlobalData.Set("gblvist", value);
                }
            }
        }

        public string OBK500
        {
            get => Actions.GetAttributeValue(By.XPath(txtrefnoentry), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtrefnoentry), value);
                    GlobalData.Set("OBK500", value);
                }
            }
        }

        public string OBK1000
        {
            get => Actions.GetAttributeValue(By.XPath(txtref10entry), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtref10entry), value);
                    GlobalData.Set("OBK1000", value);
                }
            }

        }

        public string DALALYX
        {
            get => Actions.GetAttributeValue(By.XPath(txtalyxrefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtalyxrefno), value);
                    GlobalData.Set("gblalyx", value);
                }
            }
        }

        public string DALBP
        {
            get => Actions.GetAttributeValue(By.XPath(txtbprefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtbprefno), value);
                    GlobalData.Set("gblbp", value);
                }
            }
        }

        public string DALAMIC
        {
            get => Actions.GetAttributeValue(By.XPath(txtamicrefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtamicrefno), value);
                    GlobalData.Set("gblamic", value);
                }
            }
        }

        public string DALHCUE
        {
            get => Actions.GetAttributeValue(By.XPath(txthcuerefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txthcuerefno), value);
                    GlobalData.Set("gblHcue", value);
                }
            }
        }

        public string DALSCALE
        {
            get => Actions.GetAttributeValue(By.XPath(txtscalerefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtscalerefno), value);
                    GlobalData.Set("DALSCALE", value);
                }
            }
        }

        public string DALTHER
        {
            get => Actions.GetAttributeValue(By.XPath(txttherrefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txttherrefno), value);
                    GlobalData.Set("gblther", value);
                }
            }
        }

        public string DALTRIM
        {
            get => Actions.GetAttributeValue(By.XPath(txttrimrefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txttrimrefno), value);
                    GlobalData.Set("gbltrim", value);
                }
            }
        }

        public string DALVIST
        {
            get => Actions.GetAttributeValue(By.XPath(txtvistrefno), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtvistrefno), value);
                    GlobalData.Set("gblvist", value);
                }
            }
        }

        public string DAL500
        {
            get => Actions.GetAttributeValue(By.XPath(txtref10entry), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtref10entry), value);
                    GlobalData.Set("DAL500", value);
                }
            }
        }

        public string DAL1000
        {
            get => Actions.GetAttributeValue(By.XPath(txtrefnoentry), "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(By.XPath(txtrefnoentry), value);
                    GlobalData.Set("DAL1000", value);
                }
            }
        }



        #endregion

        public static string RandomNum(int length)
        {
            Random rnd = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        public void OpenEquipment()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnkequipment);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ExactPageTitle(EQUIPMENT);
        }

        public void OpenSupply()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(supplytab);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
        }


        public void SelectDriveProfile()
        {
            string test = Actions.GetText(selectedprofile);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            if (Actions.GetText(selectedprofile) == "Drive Profile:")
            {
                Actions.Click(seldriveprofile);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(seltrim);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(seldriveprofile);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(selwbpp);
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(btnok);
            }

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Verify.ElementContainsText(selectedprofile, "WBPP");
        }

        public void AddAlyx(EquipmentData EquipmentData)
        {

            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(-10);

            if (Actions.GetText(lblusername) == "AUTUSR")
            {
                if (Actions.IsElementContainsText(By.XPath(txtobkalyxrefnovalue), "EQ-"))
                    gblalyx = Actions.GetText(By.XPath(txtobkalyxrefnovalue));
            }
            else
            {
                if (Actions.IsElementContainsText(By.XPath(txtdalalyxrefnovalue), "EQ-"))
                    gblalyx = Actions.GetText(By.XPath(txtdalalyxrefnovalue));
            }

            if (Actions.IsElementPresent(By.XPath(txtalyxscan)))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.SendKeys(By.XPath(txtalyxscan), "m");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                if (Actions.GetText(lblusername) == "AUTUSR")
                    OBKALYX = EquipmentData.OBKALYX;
                else
                    DALALYX = EquipmentData.DALALYX;
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkalyx));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtalyxcaldt));
                CommonActions.SetText(By.XPath(txtalyxcaldt), txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));
                Actions.Click(By.XPath(txtalyxequip));
                CommonActions.SetText(By.XPath(txtalyxequip), "OK");
                Actions.Click(By.XPath(txtalyxwipe));
                CommonActions.SetText(By.XPath(txtalyxwipe), "YES");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            Actions.ScrollToElement(By.XPath(lnkalyx));
            Report.LogPassedTest("ALYX equipment passed");
            Report.TakeScreenshot();

        }

        public void AddAmic(EquipmentData EquipmentData)
        {

            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(-10);
            var NumberUtils = new NumberUtils();

            if (Actions.GetText(lblusername) == "AUTUSR")
            {
                if (Actions.IsElementContainsText(By.XPath(txtobkamicrefnovalue), "EQ-"))
                    gblamic = Actions.GetText(By.XPath(txtobkamicrefnovalue));
            }
            else
            {
                if (Actions.IsElementContainsText(By.XPath(txtdalamicrefnovalue), "EQ-"))
                    gblamic = Actions.GetText(By.XPath(txtdalamicrefnovalue));
            }

            if (Actions.IsElementPresent(By.XPath(txtamicscan)))
            {

                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.SendKeys(By.XPath(txtamicscan), "m");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                if (Actions.GetText(lblusername) == "AUTUSR")
                    OBKAMIC = EquipmentData.OBKAMIC;
                else
                    DALAMIC = EquipmentData.DALAMIC;
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkamic));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtamiccaldt));
                CommonActions.SetText(By.XPath(txtamiccaldt), txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));
                Actions.Click(By.XPath(txtamicelec));
                CommonActions.SetText(By.XPath(txtamicelec), "YES");
                Actions.Click(By.XPath(txtamicwipe));
                CommonActions.SetText(By.XPath(txtamicwipe), "YES");
                Actions.Click(By.XPath(txtamicequip));
                CommonActions.SetText(By.XPath(txtamicequip), "OK");
                Actions.Click(By.XPath(txtamicsrn));
                CommonActions.SetText(By.XPath(txtamicsrn), RandomNum(6));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            Actions.ScrollToElement(By.XPath(lnkamic));

            Report.LogPassedTest("AMIC equipment passed");
            Report.TakeScreenshot();

        }

        public void AddBPCuff(EquipmentData EquipmentData)
        {

            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(-10);
            if (Actions.GetText(lblusername) == "AUTUSR")
            {
                if (Actions.IsElementContainsText(By.XPath(txtobkbprefnovalue), "EQ-"))
                    gblbp = Actions.GetText(By.XPath(txtobkbprefnovalue));
            }
            else
            {
                if (Actions.IsElementContainsText(By.XPath(txtdalbprefnovalue), "EQ-"))
                    gblbp = Actions.GetText(By.XPath(txtdalbprefnovalue));
            }

            if (Actions.IsElementPresent(By.XPath(txtbpscan)))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.SendKeys(By.XPath(txtbpscan), "m");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                if (Actions.GetText(lblusername) == "AUTUSR")
                    OBKBP = EquipmentData.OBKBP;
                else
                    DALBP = EquipmentData.DALBP;
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkbp));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtbpequip));
                CommonActions.SetText(By.XPath(txtbpequip), "OK");
                Actions.Click(By.XPath(txtbpelec));
                CommonActions.SetText(By.XPath(txtbpelec), "YES");
                Actions.Click(By.XPath(txtbpcaldt));
                CommonActions.SetText(By.XPath(txtbpcaldt), txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            Actions.ScrollToElement(By.XPath(lnkbp));
            Report.LogPassedTest("BP equipment passed");
            Report.TakeScreenshot();

        }

        public void AddHcue(EquipmentData EquipmentData)
        {

            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(-10);
            var NumberUtils = new NumberUtils();

            if (Actions.GetText(lblusername) == "AUTUSR")
            {
                if (Actions.IsElementContainsText(By.XPath(txtobkhcuerefnovalue), "EQ-"))
                    gblHcue = Actions.GetText(By.XPath(txtobkhcuerefnovalue));
            }
            else
            {
                if (Actions.IsElementContainsText(By.XPath(txtdalhcuerefnovalue), "EQ-"))
                    gblHcue = Actions.GetText(By.XPath(txtdalhcuerefnovalue));
            }

            if (Actions.IsElementPresent(By.XPath(txthcuescan)))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.SendKeys(By.XPath(txthcuescan), "m");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                if (Actions.GetText(lblusername) == "AUTUSR")
                    OBKHCUE = EquipmentData.OBKHCUE;
                else
                    DALHCUE = EquipmentData.DALHCUE;
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkhcue));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txthcuecaldt));
                CommonActions.SetText(By.XPath(txthcuecaldt), txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));
                Actions.Click(By.XPath(txthcueelec));
                CommonActions.SetText(By.XPath(txthcueelec), "YES");
                Actions.Click(By.XPath(txthcuewipe));
                CommonActions.SetText(By.XPath(txthcuewipe), "YES");
                Actions.Click(By.XPath(txthcuevolum));
                CommonActions.SetText(By.XPath(txthcuevolum), "6");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            Actions.ScrollToElement(By.XPath(lnkhcue));

            Report.LogPassedTest("HCUE equipment passed");
            Report.TakeScreenshot();

        }

        public void AddScale(EquipmentData EquipmentData)
        {

            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(-10);
            var NumberUtils = new NumberUtils();

            if (Actions.GetText(lblusername) == "AUTUSR")
            {
                if (Actions.IsElementContainsText(By.XPath(txtobkscalerefnovalue), "EQ-"))
                    gblScale = Actions.GetText(By.XPath(txtobkscalerefnovalue));
            }
            else
            {
                if (Actions.IsElementContainsText(By.XPath(txtdalscalerefnovalue), "EQ-"))
                    gblScale = Actions.GetText(By.XPath(txtdalscalerefnovalue));
            }

            if (Actions.IsElementPresent(By.XPath(txtscalescan)))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.SendKeys(By.XPath(txtscalescan), "m");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                if (Actions.GetText(lblusername) == "AUTUSR")
                    OBKSCALE = EquipmentData.OBKSCALE;
                else
                    DALSCALE = EquipmentData.DALSCALE;
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkscale));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtscalesrn));
                CommonActions.SetText(By.XPath(txtscalesrn), RandomNum(6));
                Actions.Click(By.XPath(txtscalecaldt));
                CommonActions.SetText(By.XPath(txtscalecaldt), txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));
                Actions.Click(By.XPath(txtscale1000));
                CommonActions.SetText(By.XPath(txtscale1000), "1000");
                Actions.Click(By.XPath(txtscale500));
                CommonActions.SetText(By.XPath(txtscale500), "500");
                Actions.Click(By.XPath(txtrefnoscan));
                Actions.SendKeys(By.XPath(txtrefnoscan), "M");
                if (Actions.GetText(lblusername) == "AUTUSR")
                    OBK500 = EquipmentData.OBK500;
                else
                    DAL500 = EquipmentData.DAL500;
                Actions.Click(By.XPath(txtref10scan));
                Actions.SendKeys(By.XPath(txtref10scan), "M");
                if (Actions.GetText(lblusername) == "AUTUSR")
                    OBK1000 = EquipmentData.OBK1000;
                else
                    DAL1000 = EquipmentData.DAL1000;
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            Actions.ScrollToElement(By.XPath(lnkscale));
            Report.LogPassedTest("Scale equipment passed");
            Report.TakeScreenshot();

        }

        public void AddTher(EquipmentData EquipmentData)
        {

            var NumberUtils = new NumberUtils();

            if (Actions.GetText(lblusername) == "AUTUSR")
            {
                if (Actions.IsElementContainsText(By.XPath(txtobktherrefnovalue), "EQ-"))
                    gblther = Actions.GetText(By.XPath(txtobktherrefnovalue));
            }
            else
            {
                if (Actions.IsElementContainsText(By.XPath(txtdaltherrefnovalue), "EQ-"))
                    gblther = Actions.GetText(By.XPath(txtdaltherrefnovalue));
            }

            if (Actions.IsElementPresent(By.XPath(txttherscan)))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.SendKeys(By.XPath(txttherscan), "m");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                if (Actions.GetText(lblusername) == "AUTUSR")
                    OBKTHER = EquipmentData.OBKTHER;
                else
                    DALTHER = EquipmentData.DALTHER;
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkther));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtthersrn));
                CommonActions.SetText(By.XPath(txtthersrn), RandomNum(6));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            Actions.ScrollToElement(By.XPath(lnkther));
            Report.LogPassedTest("Thermometer equipment passed");
            Report.TakeScreenshot();

        }

        public void AddTrim(EquipmentData EquipmentData)
        {

            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(-10);
            var NumberUtils = new NumberUtils();

            if (Actions.GetText(lblusername) == "AUTUSR")
            {
                if (Actions.IsElementContainsText(By.XPath(txtobktrimrefnovalue), "EQ-"))
                    gbltrim = Actions.GetText(By.XPath(txtobktrimrefnovalue));
            }
            else
            {
                if (Actions.IsElementContainsText(By.XPath(txtdaltrimrefnovalue), "EQ-"))
                    gbltrim = Actions.GetText(By.XPath(txtdaltrimrefnovalue));
            }

            if (Actions.IsElementPresent(By.XPath(txttrimscan)))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.SendKeys(By.XPath(txttrimscan), "m");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                if (Actions.GetText(lblusername) == "AUTUSR")
                    OBKTRIM = EquipmentData.OBKTRIM;
                else
                    DALTRIM = EquipmentData.DALTRIM;
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnktrim));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txttrimsrn));
                CommonActions.SetText(By.XPath(txttrimsrn), RandomNum(6));
                Actions.Click(By.XPath(txttrimwipe));
                CommonActions.SetText(By.XPath(txttrimwipe), "YES");
                Actions.Click(By.XPath(txttrimequip));
                CommonActions.SetText(By.XPath(txttrimequip), "OK");
                Actions.Click(By.XPath(txttrimelec));
                CommonActions.SetText(By.XPath(txttrimelec), "YES");
                Actions.Click(By.XPath(txttrimcaldt));
                CommonActions.SetText(By.XPath(txttrimcaldt), txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            Actions.ScrollToElement(By.XPath(lnktrim));
            Report.LogPassedTest("TRIM equipment passed");
            Report.TakeScreenshot();

        }

        public void AddVist(EquipmentData EquipmentData)
        {

            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(-10);
            var NumberUtils = new NumberUtils();

            if (Actions.GetText(lblusername) == "AUTUSR")
            {
                if (Actions.IsElementContainsText(By.XPath(txtobkvistrefnovalue), "EQ-"))
                    gblvist = Actions.GetText(By.XPath(txtobkvistrefnovalue));
            }
            else
            {
                if (Actions.IsElementContainsText(By.XPath(txtdalvistrefnovalue), "EQ-"))
                    gblvist = Actions.GetText(By.XPath(txtdalvistrefnovalue));
            }

            if (Actions.IsElementPresent(By.XPath(txtvistscan)))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.SendKeys(By.XPath(txtvistscan), "m");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                if (Actions.GetText(lblusername) == "AUTUSR")
                    OBKVIST = EquipmentData.OBKVIST;
                else
                    DALVIST = EquipmentData.DALVIST;
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkvist));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtvistcaldt));
                CommonActions.SetText(By.XPath(txtvistcaldt), txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));
                Actions.Click(By.XPath(txtvistcfail));
                CommonActions.SetText(By.XPath(txtvistcfail), "NO");
                Actions.Click(By.XPath(txtvistsrn));
                CommonActions.SetText(By.XPath(txtvistsrn), RandomNum(6));
                Actions.Click(By.XPath(txtvistelec));
                CommonActions.SetText(By.XPath(txtvistelec), "YES");
                Actions.Click(By.XPath(txtvistequip));
                CommonActions.SetText(By.XPath(txtvistequip), "OK");
                Actions.Click(By.XPath(txtvistwipe));
                CommonActions.SetText(By.XPath(txtvistwipe), "YES");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }
            Actions.ScrollToElement(By.XPath(lnkvist));
            Report.LogPassedTest("VISTA equipment passed");
            Report.TakeScreenshot();

        }

        public void SaveEquipment()
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnsave);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Report.LogPassedTest("Equipment saved");
            Report.TakeScreenshot();

            Actions.Click(btnoksave);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void AddCb()
        {

            if (Actions.IsElementContainsText(By.XPath(lblpasscb), ""))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkcb));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                CommonActions.SetText(By.XPath(txtcbvis), "YES");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }

            Actions.ScrollToElement(By.XPath(lnkcb));
            Report.LogPassedTest("Cotton Balls supply passed");
            Report.TakeScreenshot();

        }

        public void AddBags()
        {
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(30);
            bool testvalue = (Actions.IsExactTextInElement(By.XPath(lblpassbag), ""));
            if (Actions.IsExactTextInElement(By.XPath(lblpassbag), ""))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkbag));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtbagexpdt));
                CommonActions.SetText(By.XPath(txtbagexpdt), txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtbagcatlgscan));
                Actions.SendKeys(By.XPath(txtbagcatlgscan), "M");
                CommonActions.SetText(By.XPath(txtbagcatlg), "TE0077585");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtbaglotscan));
                Actions.SendKeys(By.XPath(txtbaglotscan), "M");
                CommonActions.SetText(By.XPath(txtbaglot), "00090127KK");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtbagopcon));
                CommonActions.SetText(By.XPath(txtbagopcon), "NO");

            }

            Actions.ScrollToElement(By.XPath(lnkbag));
            Report.LogPassedTest("Bags supply passed");
            Report.TakeScreenshot();

        }

        public void AddChlop()
        {
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10)).AddDays(30);
            var NumberUtils = new NumberUtils();

            if (Actions.IsElementContainsText(By.XPath(lblpasschlop), ""))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkchlop));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtchloplot));
                CommonActions.SetText(By.XPath(txtchloplot), RandomNum(5));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(txtchlopexpdt));
                CommonActions.SetText(By.XPath(txtchlopexpdt), txtcurrentchapterdate.ToString("MM/dd/yyyy").Replace("/", "-"));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }

            Actions.ScrollToElement(By.XPath(lnkchlop));
            Report.LogPassedTest("Chlop supply passed");
            Report.TakeScreenshot();

        }

        public void AddLance()
        {

            if (Actions.IsElementContainsText(By.XPath(lblpasslance), "")) 
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnklance));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                CommonActions.SetText(By.XPath(txtlancevis), "YES");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }

            Actions.ScrollToElement(By.XPath(lnklance));
            Report.LogPassedTest("Lancets supply passed");
            Report.TakeScreenshot();

        }

        public void AddPpkit()
        {

            if (Actions.IsElementContainsText(By.XPath(lblpassppkit), ""))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkppkit));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                CommonActions.SetText(By.XPath(txtppkitvis), "YES");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                CommonActions.SetText(By.XPath(txtppkitlotscan), "M");
                CommonActions.SetText(By.XPath(txtppkitlot), "ACDA000001");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }

            Actions.ScrollToElement(By.XPath(lnkppkit));
            Report.LogPassedTest("PPKIT supply passed");
            Report.TakeScreenshot();

        }

        public void AddTums()
        {

            if (Actions.IsElementContainsText(By.XPath(lblpasstums), ""))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnktums));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                CommonActions.SetText(By.XPath(txttumsvis), "YES");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            }

            Actions.ScrollToElement(By.XPath(lnktums));
            Report.LogPassedTest("Tums supply passed");
            Report.TakeScreenshot();

        }

        public void AddWbkit()
        {

            if (Actions.IsElementContainsText(By.XPath(lblpasswbkit), ""))
            {
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                Actions.Click(By.XPath(lnkwbkit));
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                CommonActions.SetText(By.XPath(txtwbkitlotscan), "M");
                CommonActions.SetText(By.XPath(txtwbkitlot), "ACDA000040");
                Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
                
            }

            Actions.ScrollToElement(By.XPath(lnkwbkit));
            Report.LogPassedTest("WB Kit supply passed");
            Report.TakeScreenshot();

        }

    }


}

