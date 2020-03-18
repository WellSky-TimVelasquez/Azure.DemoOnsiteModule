using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flux.OnsiteModule.UI//.StepHelpers.Base.Helper
{
    public class OnsiteHelper : OnsiteModule_PageBase

    {
        #region config
        /// <summary>
        /// Sets and Gets the <see cref="WebEnvironment"/> instance.
        /// </summary>
        private WebEnvironment WebEnvironment { get; set; }

        public OnsiteHelper(WebEnvironment webEnvironment)
        {
            WebEnvironment = webEnvironment;
            Waits = new WebWaits(webEnvironment);
            Actions = new WebActions(webEnvironment);
        }
        #endregion

        #region PageObjects
        //Activate Drive
        private readonly string rdodrive = "location-drv0{0}"; 
        private readonly By btnok = By.Id("button-ok");
        private readonly By btnactivatedrive = By.Id("button-go-to-activate-drive-screen");
        private readonly By txtconfirmdrive = By.Id("input-verify-driveid");
        private readonly By txtdriveidfooter = By.Id("driveIDFooter");
        private readonly By btnselectdrive = By.Id("button-select-drive");
        private readonly By btnmultiok = By.Id("multi-button-ok");

        private readonly By lblchapterdate = By.Id("label-chapter-date-time");
        private readonly By lblusername = By.Id("label-username");

        //Page Links
        private readonly By lnklookupregistration = By.Id("link-lookupregistration--modify-data"); 
        private readonly By lnkhealthhistoryphysfindings = By.Id("link-health-history--physical-findings");
        private readonly By lnkdonorlookup = By.Id("link-lookupregistration--modify-data"); 
        private readonly By lnkonsitemodulemenu = By.Id("link-onsite-module-menu");


        //Find Donor
        private readonly By txtlastname = By.Id("input-last-name");
        private readonly By txtfirstname = By.Id("input-first-name");
        private readonly By txtdob = By.Id("input-dob");
        private readonly By selectsex = By.Id("input-gender");
        private readonly By txtdonorid = By.Id("input-donor-id");
        private readonly By txtssn = By.Id("input-ssn");
        private readonly By txtalternatetype = By.Id("input-alternate-type");
        private readonly By txtalternateid = By.Id("input-alternate-id");
        private readonly By btnsearch = By.Id("button-search");
        private readonly By btnselect = By.Id("button-select");
        private readonly By strrtndnid = By.XPath("/html/body/app-root/app-main-layout/mat-drawer-container/mat-drawer-content/main/div/div/app-onsite-router/div/div/app-lookup-and-registration/div/app-find-donor/div/div/mat-card/div/app-mat-table/table/tbody/mat-row/td[3]/app-highlighted-text/div");

        //Register Donor
        private readonly By txtconfirmdob = By.Id("input-dob");
        private readonly By txtconfirmgender = By.Id("input-gender");
        private readonly By txtconfirmlastname = By.Id("input-verify-last-name");
        private readonly By txtmessage = By.Id("alert-title");
        private readonly By btnnew = By.Id("button-new");
        private readonly By txtconfirmdiff = By.Id("confirm-title");
        private readonly By txtmiddlename = By.Id("input-middle-name");
        private readonly By txtsuffix = By.Id("input-suffix");
        private readonly By txtscan = By.Id("input-scan");
        private readonly By txtheight = By.Id("input-height");
        private readonly By txtweight = By.Id("input-weight");
        private readonly By selectethnicity = By.Id("input-ethnicity");
        private readonly By txtaddress = By.Id("input-address");
        private readonly By txtcity = By.Id("input-city");
        private readonly By txtaptnumber = By.Id("input-apartment-number");
        private readonly By txtzip = By.Id("input-zip");
        private readonly By txtstate = By.Id("input-state");
        private readonly By txtemail = By.Id("input-email");
        private readonly By txtemployername = By.Id("input-employer-name");
        private readonly By txtemployercity = By.Id("input-employer-city");
        private readonly By txtemployerzip = By.Id("input-employer-zip");
        private readonly By txtsponsor = By.Id("input-alternate-sponsor");
        private readonly By chkhomephone = By.Id("check-phone-h");
        private readonly By txthomephone = By.Id("input-home-phone");
        private readonly By chkworkphone = By.Id("check-phone-d");
        private readonly By txtworkphone = By.Id("input-work-phone");
        private readonly By chkmobilephone = By.Id("check-phone-m");
        private readonly By txtmobilephone = By.Id("input-mobile-phone");
        private readonly By selectdonation = By.Id("input-donation");
        private readonly By selectprocedure = By.Id("input-procedure");
        private readonly By txtsecondweight = By.Id("input-donor-weight");     
        private readonly By equipment = By.Id("input-equipment");
        private readonly By btneligibility = By.Id("button-full-eligibility");
        private readonly By btnregister = By.Id("button-register");
        private readonly By btncomments = By.Id("button-comments");
        private readonly By btnhhpf = By.Id("button-hhphy");
        private readonly By btnprintcard = By.Id("button-print-card");
        private readonly By btndonations = By.Id("button-donations");
        private readonly By btnsearchdonor = By.Id("button-search-donor");
        private readonly By btninquiry = By.Id("button-inquiry");
        private readonly By btnother = By.Id("button-other");
        private readonly By txtdonoralert = By.Id("alert-title");
        private readonly By chkidverify = By.Id("check-id-verified");
        private readonly By btnverifyok = By.Id("multi-button-ok");
        private readonly By btnupdate = By.Id("button-update");


        //Select Donor
        //private readonly By rdodonorselect = By.Id("radio-dn30121122");
        private readonly string rdodonorselect = "radio-dn{0}";
        private readonly string seldonorid = "donor-id-dn{0}"; 
        private readonly string seldonorname = "name-dn{0}";
        private readonly string seldob = "dob-dn{0}";
        private readonly string selssn = "ssn-dn{0}";
        private readonly string seltimeinqueue = "time-in-queue-dn{0}";


        private readonly By btnselectdonor = By.Id("button-select-donor");
        private readonly By txtverifydonorlastname = By.Id("input-last-name");

        //sign in pop up
        private readonly By txtusername = By.Id("input-username"); 
        private readonly By txtpassword = By.Id("input-password");
        private readonly By btnsign = By.Id("button-sign");

        public By GetDRVRadioBtnLocator(int drvnum)
        {
            By locator = By.Id(string.Format(rdodrive, drvnum));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorRadioBtnLocator(string donorid)
        {
            By locator = By.Id(string.Format(rdodonorselect, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorIdLocator(string donorid)
        {
            By locator = By.Id(string.Format(seldonorid, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorSsnLocator(string donorid)
        {
            By locator = By.Id(string.Format(selssn, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorDobLocator(string donorid)
        {
            By locator = By.Id(string.Format(seldob, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorNameLocator(string donorid)
        {
            By locator = By.Id(string.Format(seldonorname, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }

        public By GetDonorTimeinQueueLocator(string donorid)
        {
            By locator = By.Id(string.Format(seltimeinqueue, donorid));
            //Report.LogInfo("locator: " + locator);
            return locator;
        }
        #endregion

        #region Getters/Setters
        public string LastName
        {
            get => Actions.GetAttributeValue(txtlastname, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtlastname, value);
                    GlobalData.Set("LastName", value);
                    gblLastName = LastName;
                }
            }
        }
        public string FirstName
        {
            get => Actions.GetAttributeValue(txtfirstname, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtfirstname, value);
                    GlobalData.Set("FirstName", value);
                    gblFirstName = FirstName;
                }
            }
        }
        public string DateOfBirth
        {
            get => Actions.GetAttributeValue(txtdob, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtdob, value);
                    GlobalData.Set("DateOfBirth", value);
                    gblDateOfBirth = DateOfBirth;
                }
            }
        }
        public string ConfirmDateOfBirth
        {
            get => Actions.GetAttributeValue(txtconfirmdob, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtconfirmdob, value);
                    GlobalData.Set("DateOfBirth", value);
                }
            }
        }
        public string ConfirmGender
        {
            get => Actions.GetAttributeValue(txtconfirmgender, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtconfirmgender, value);
                    GlobalData.Set("Gender", value);
                }
            }
        }
        public string Gender
        {
            get => Actions.GetAttributeValue(selectsex, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(selectsex, value);
                    GlobalData.Set("Gender", value);
                    gblGender = Gender;
                }
            }
        }
        public string SSN
        {
            get => Actions.GetAttributeValue(txtssn, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtssn, value);
                    GlobalData.Set("SSN", value);
                    gblSSN = SSN;
                }
            }
        }
        public string AlternateType
        {
            get => Actions.GetAttributeValue(txtalternatetype, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtalternatetype, value);
                    GlobalData.Set("AlternateType", value); 
                }
            }
        }
        public string AlternateID
        {
            get => Actions.GetAttributeValue(txtalternateid, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtalternateid, value);
                    GlobalData.Set("AlternateID", value); 
                }
            }
        }

        public string MiddleName
        {
            get => Actions.GetAttributeValue(txtmiddlename, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtmiddlename, value);
                    GlobalData.Set("MiddleName", value);
                }
            }
        }
        public string Suffix
        {
            get => Actions.GetAttributeValue(txtsuffix, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtsuffix, value);
                    GlobalData.Set("Suffix", value);
                }
            }
        }
        public string ScanID
        {
            get => Actions.GetAttributeValue(txtscan, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtscan, value);
                    GlobalData.Set("ScanID", value);
                }
            }
        }
        public string Height
        {
            get => Actions.GetAttributeValue(txtheight, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtheight, value);
                    GlobalData.Set("Height", value);
                }
            }
        }
        public string Weight
        {
            get => Actions.GetAttributeValue(txtweight, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtweight, value);
                    GlobalData.Set("Weight", value);
                }
            }
        }
        public string Ethnicity
        {
            get => Actions.GetAttributeValue(selectethnicity, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(selectethnicity, value);
                    GlobalData.Set("Ethnicity", value);
                }
            }
        }
        public string Address
        {
            get => Actions.GetAttributeValue(txtaddress, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtaddress, value);
                    GlobalData.Set("Address", value);
                    gblAddress = Address;
                }
            }
        }
        public string City
        {
            get => Actions.GetAttributeValue(txtcity, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    //CommonActions.SetText(txtcity, value);
                    Actions.SendHumanKeys(txtcity, value, TimeSpan.FromMilliseconds(40));

                    GlobalData.Set("City", value);
                    gblCity = City;
                }
            }
        }
        public string AptNumber
        {
            get => Actions.GetAttributeValue(txtaptnumber, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtaptnumber, value);
                    GlobalData.Set("AptNumber", value);
                }
            }
        }
        public string ZipCode
        {
            get => Actions.GetAttributeValue(txtzip, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    //CommonActions.SetText(txtzip, value);
                    Actions.SendHumanKeys(txtzip, value, TimeSpan.FromMilliseconds(40));

                    GlobalData.Set("ZipCode", value);
                    gblZipCode = ZipCode;
                }
            }
        }
        public string Email
        {
            get => Actions.GetAttributeValue(txtemail, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtemail, value);
                    GlobalData.Set("Email", value);
                }
            }
        }
        public string EmployerName
        {
            get => Actions.GetAttributeValue(txtemployername, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtemployername, value);
                    GlobalData.Set("EmployerName", value);
                }
            }
        }
        public string EmployerCity
        {
            get => Actions.GetAttributeValue(txtemployercity, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtemployercity, value);
                    GlobalData.Set("EmployerCity", value);
                }
            }
        }
        public string EmployerZip
        {
            get => Actions.GetAttributeValue(txtemployerzip, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtemployerzip, value);
                    GlobalData.Set("EmployerZip", value);
                }
            }
        }
        public string Sponsor
        {
            get => Actions.GetAttributeValue(txtsponsor, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    Actions.SendKeys(txtsponsor, value);
                    //CommonActions.SetText(txtsponsor, value);
                    GlobalData.Set("Sponsor", value);
                }
            }
        }
        public string PrefHomePhone
        {
            get => Actions.GetAttributeValue(chkhomephone, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    //CommonActions.SetText(chkhomephone, value);
                    Actions.Click(chkhomephone);
                    GlobalData.Set("PrefHomePhone", value);
                }
            }
        }
        public string HomePhone
        {
            get => Actions.GetAttributeValue(txthomephone, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txthomephone, value);
                    GlobalData.Set("HomePhone", value);
                }
            }
        }
        public string PrefWorkPhone
        {
            get => Actions.GetAttributeValue(chkworkphone, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    //CommonActions.SetText(chkworkphone, value);
                    Actions.Click(chkworkphone);
                    GlobalData.Set("PrefWorkPhone", value);
                }
            }
        }
        public string WorkPhone
        {
            get => Actions.GetAttributeValue(txtworkphone, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtworkphone, value);
                    GlobalData.Set("WorkPhone", value);
                }
            }
        }
        //public string WorkExtension
        //{
        //    get => Actions.GetAttributeValue(txtw, "value");
        //    set
        //    {
        //        if (!string.IsNullOrEmpty(value.Trim()))
        //        {
        //            CommonActions.SetText(txtzip, value);
        //            GlobalData.Set("WorkExtension", value);
        //        }
        //    }
        //}
        public string PrefMobilePhone
        {
            get => Actions.GetAttributeValue(chkmobilephone, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    //CommonActions.SetText(chkmobilephone, value);
                    Actions.Click(chkmobilephone);
                    GlobalData.Set("PrefMobilePhone", value);
                }
            }
        }
        public string MobilePhone
        {
            get => Actions.GetAttributeValue(txtmobilephone, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(txtmobilephone, value);
                    GlobalData.Set("MobilePhone", value);
                    gblMobilePhone = MobilePhone;

                }
            }
        }
        public string DonationType
        {
            get => Actions.GetAttributeValue(selectdonation, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(selectdonation, value);
                    GlobalData.Set("DonationType", value);
                    gblDonationType = DonationType;
                }
            }
        }
        public string ProcedureCode
        {
            get => Actions.GetAttributeValue(selectprocedure, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(selectprocedure, value);
                    GlobalData.Set("ProcedureCode", value);
                    gblProcedureCode = ProcedureCode;
                }
            }
        }

        public string Equipment
        {
            get => Actions.GetAttributeValue(equipment, "value");
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    CommonActions.SetText(equipment, value);
                    GlobalData.Set("Equipment", value);
                }
            }
        }


        #endregion

        public void SelectDrive()
        {

            Actions.Click(lnklookupregistration);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            var driveIds = Actions.ExecuteJavascript<IEnumerable<IWebElement>>("document.querySelectorAll(\"[id^='id-drv']>div\")");
            foreach (var driveId in driveIds)
            {
                SelectedDrive = driveId.Text;
                //Console.WriteLine(driveId.Text);
                totaldrives++;
                DriveidList.Add(driveId.Text);
            }

            SelectedDrive = SelectedDrive.Substring(3, 7);
            //Actions.ScrollToElement(GetDRVRadioBtnLocator(intdrive));
            //Actions.Click(GetDRVRadioBtnLocator(intdrive));
            Actions.ScrollToElement(GetDRVRadioBtnLocator(Convert.ToInt32(SelectedDrive)));
            Actions.Click(GetDRVRadioBtnLocator(Convert.ToInt32(SelectedDrive)));
            Actions.Click(btnselectdrive);
            CommonActions.SetText(txtconfirmdrive, "DRV" + SelectedDrive);
            Actions.Click(btnok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(lnklookupregistration);
            Waits.WaitForPageLoad();
            gblintdrive = Convert.ToString(SelectedDrive);

            //Verify.ExactPageTitle("BC-Onsite (Lookup & Registration)");

            //Verify.ExactPageTitle("BC-Onsite (Onsite Menu)");
            //Verify.ElementContainsText(txtdriveidfooter, strdrive);

        }


        public void FindDonor(Donor donor)
        {
            //CommonActions.WaitForPageLoad();
            //Verify.ExactPageTitle("BC-Onsite (Lookup & Registration)");
            if (Actions.IsEnabled(txtlastname))
            {
                LastName = donor.LastName;
                if (Actions.IsElementDoesNotContainsText(txtlastname, LastName))
                    { LastName = donor.LastName; }
            }
            if (Actions.IsEnabled(txtfirstname))
            {
                FirstName = donor.FirstName;
                if (Actions.IsElementContainsText(txtfirstname, FirstName))
                    { FirstName = donor.FirstName; }
            }
            if (Actions.IsEnabled(txtdob))
            {
                DateOfBirth = donor.DateOfBirth;
                if (Actions.IsElementContainsText(txtdob, DateOfBirth))
                    { DateOfBirth = donor.DateOfBirth; }
            }
            if (Actions.IsEnabled(selectsex))
            {
                Actions.Click(selectsex);
                Gender = donor.Gender;
                if (Actions.IsElementContainsText(selectsex, Gender))
                //if (Actions.IsElementDoesNotContainsText(selectsex, Gender))

                    { Gender = donor.Gender; }
            }
            CommonActions.SetText(txtdonorid, "^");
            Boolean ssnenabled = Actions.IsEnabled(txtssn);
            if (Actions.IsEnabled(txtssn))
            {
                SSN = donor.SSN;
                if (Actions.IsElementContainsText(txtssn, SSN))
                    { SSN = donor.SSN; }
            }
            Waits.WaitForPageLoad();
            if (Actions.IsEnabled(txtalternatetype))
            {
                AlternateType = donor.AlternateType;
                if (Actions.IsElementContainsText(txtalternatetype, AlternateType))
                { AlternateType = donor.AlternateType; }
            }
            if (Actions.IsEnabled(txtalternateid))
            {
                AlternateID = donor.AlternateID;
                if (Actions.IsElementContainsText(txtalternateid, AlternateID))
                { AlternateID = donor.AlternateID; }

            }

            Actions.Click(btnsearch);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Actions.Click(btnmultiok);

        }


        public void EnterNewDonor(Donor donor)
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnnew);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            bool helpme;

            if (Actions.IsElementPresent(txtconfirmdiff))
            {
                if (Actions.IsElementPresent(txtconfirmdob))
                    { CommonActions.SetText(txtconfirmdob, donor.DateOfBirth);
                    if (Actions.IsElementContainsText(txtdob, DateOfBirth))
                    { DateOfBirth = donor.DateOfBirth; }
                    }
                if (Actions.IsElementPresent(txtfirstname))
                    { FirstName = donor.FirstName;
                    if (Actions.IsElementContainsText(txtfirstname, FirstName))
                    { FirstName = donor.FirstName; }
                    }
                if (Actions.IsElementPresent(txtconfirmlastname))
                    {CommonActions.SetText(txtconfirmlastname, gblLastName);
                    //if (Actions.IsElementContainsText(txtconfirmlastname, LastName))
                    helpme = Actions.IsElementContainsText(txtconfirmlastname, gblLastName);
                        if (Actions.IsElementDoesNotContainsText(txtconfirmlastname, gblLastName))
                        { CommonActions.SetText(txtconfirmlastname, gblLastName); }
                    }
                if (Actions.IsElementPresent(txtconfirmgender))
                    { CommonActions.SetText(txtconfirmgender, donor.Gender);
                    if (Actions.IsElementContainsText(selectsex, Gender))
                    { Gender = donor.Gender; }
                    }
                if (Actions.IsElementPresent(txtssn))
                    { SSN = donor.SSN;
                    if (Actions.IsElementContainsText(txtssn, SSN))
                    { SSN = donor.SSN; }
                    }
                Actions.Click(btnok);
            }


            MiddleName = donor.MiddleName;
            Suffix = donor.Suffix;
            //ScanID = donor.ScanID;
            Height = donor.Height;
            Weight = donor.Weight;
            Actions.Click(selectethnicity);
            Ethnicity = donor.Ethnicity;
            Address = donor.Address;
            AptNumber = donor.AptNumber;
            Actions.Click(txtcity);
            City = donor.City;
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.PressKey(Keys.Tab, txtcity);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            ZipCode = donor.ZipCode;
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.PressKey(Keys.Tab, txtzip);
            Waits.WaitForPageLoad();
            gblState = Actions.GetText(txtstate);
            Actions.ScrollToElement(chkidverify);
            Waits.WaitForPageLoad();
            Actions.Click(chkidverify);
            //this is for temporary message
            Actions.Click(btnverifyok);
            Waits.WaitForPageLoad();
            if (donor.PrefHomePhone == "Y")
                PrefHomePhone = donor.PrefHomePhone;
            HomePhone = donor.HomePhone;
            if (donor.PrefWorkPhone == "Y")
                PrefWorkPhone = donor.PrefWorkPhone;
            WorkPhone = donor.WorkPhone;
            //WorkExtension = "^";
            if (donor.PrefMobilePhone == "Y")
                PrefMobilePhone = donor.PrefMobilePhone;
            MobilePhone = donor.MobilePhone;
            Email = donor.Email;

            Actions.ScrollToElement(txtemployername);
            EmployerName = donor.EmployerName;
            EmployerCity = donor.EmployerCity;
            EmployerZip = donor.EmployerZip;
            Actions.ScrollToElement(txtsponsor);
            Waits.WaitForPageLoad();
            Sponsor = donor.Sponsor;
            
            Actions.ScrollToElement(btnregister);
            //Actions.Click(selectdonation);
            DonationType = donor.DonationType;
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            ProcedureCode = donor.ProcedureCode;
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            if (Actions.IsEnabled(equipment))
                Equipment = donor.Equipment;
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.ScrollToElement(btnregister);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnregister);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            txtDonorID = Actions.GetText(txtdonoralert).Substring(53, 10);
            txtDonorIDonly = Actions.GetText(txtdonoralert).Substring(55, 8);
            //Verify.ElementContainsText(txtmessage, "Msg: 21000: Donor Registered Successfully. Donor ID: " + txtDonorID);
            //Report.LogPassedTest("Donor " + txtDonorID + " is registered");
            //Report.TakeScreenshot();

            //Actions.Click(btnverifyok);
            //Waits.WaitForPageLoad();
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Actions.Click(lnkonsitemodulemenu);


        }

        public void SelectRegisteredDonor(Donor donor)
        {

            Actions.Click(GetDonorRadioBtnLocator(OnsiteHelper.txtDonorIDonly));
            CommonActions.SetText(txtverifydonorlastname, LastName);
            Actions.Click(btnok);
            CommonActions.WaitForPageLoad();
            Verify.ExactPageTitle(ONSITEHHPF);

        }

        public void FindExistingDonor(String donorid)
        {
            Actions.Click(txtdonorid);
            CommonActions.SetText(txtdonorid, "DN" + donorid);
            //Actions.Click(btnsearch);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }

        public void EnterExistingDonor(string ssn, string lastname, string firstname, string dob, string gender, string donorid)
        {

            //Waits.WaitForPageLoad();
            ////Actions.Click(btnselect);
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


            if (Actions.IsElementPresent(txtconfirmdiff))
            {
                if (Actions.IsElementPresent(txtconfirmdob))
                {
                    CommonActions.SetText(txtconfirmdob, dob);
                    //ConfirmDateOfBirth = dob;
                    if (Actions.IsElementContainsText(txtconfirmdob, dob))
                    { ConfirmDateOfBirth = dob; }
                }
                if (Actions.IsElementPresent(txtfirstname))
                {
                    FirstName = firstname;
                    if (Actions.IsElementContainsText(txtfirstname, firstname))
                    { FirstName = firstname; }
                }
                if (Actions.IsElementPresent(txtlastname))
                {
                    LastName = lastname;
                    if (Actions.IsElementContainsText(txtlastname, lastname))
                    { LastName = lastname; }
                }
                if (Actions.IsElementPresent(txtconfirmgender))
                {
                    CommonActions.SetText(txtconfirmgender, gender);
                    if (Actions.IsElementContainsText(selectsex, gender))
                    { Gender = gender; }
                }
                if (Actions.IsElementPresent(txtssn))
                {
                    SSN = ssn;
                    if (Actions.IsElementContainsText(txtssn, ssn))
                    { SSN = ssn; }
                }
                Actions.Click(btnok);
            }
            else
                Actions.Click(btnselect);


            CommonActions.SetText(selectethnicity, "CA");
            Waits.WaitForPageLoad();
            Actions.Click(chkidverify);
            //this is for temporary message
            Actions.Click(btnverifyok);
            Waits.WaitForPageLoad();


            var donorhomephone = Actions.ExecuteJavascript<string>("document.getElementById('input-home-phone').value");
            var donorworkphone = Actions.ExecuteJavascript<string>("document.getElementById('input-work-phone').value");
            var donormobilephone = Actions.ExecuteJavascript<string>("document.getElementById('input-mobile-phone').value");
            var donorweight = Actions.ExecuteJavascript<string>("document.getElementById('input-weight').value");

            if (donorweight == "")
            {
                CommonActions.SetText(txtweight, "200");
            }

            if (donorhomephone != "")
            {
                Actions.Click(chkhomephone);
            }
            if (donorworkphone != "")
            {
                Actions.Click(chkworkphone);
            }
            if (donormobilephone != "")
            {
                Actions.Click(chkmobilephone);
            }

            Actions.ScrollToElement(btnregister);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(selectdonation);
            Actions.SendKeys(selectdonation, "AL");
            Actions.PressKey(Keys.Tab, selectdonation);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Actions.Click(selectprocedure);
            Actions.SendKeys(selectprocedure, "WB");
            Actions.PressKey(Keys.Tab, selectprocedure);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.ScrollToElement(btnregister);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnregister);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            txtDonorID = Actions.GetText(txtdonoralert).Substring(53, 10);
            txtDonorIDonly = Actions.GetText(txtdonoralert).Substring(55, 8);
            //Verify.ElementContainsText(txtmessage, "Msg: 21000: Donor Registered Successfully. Donor ID: " + txtDonorID);
            //Report.LogPassedTest("Donor " + txtDonorID + " is registered");
            //Report.TakeScreenshot();

            //Actions.Click(btnverifyok);
            //Waits.WaitForPageLoad();
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Actions.Click(lnkonsitemodulemenu);

        }

        public void Loginpopup()
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Verify.ElementIsPresent(txtusername);
            CommonActions.SetText(txtusername, WebEnvironment.AppSettings["AppUserName"]);
            CommonActions.SetText(txtpassword, WebEnvironment.AppSettings["AppPassword"]);
            Actions.Click(btnsign);

        }

        public void EnteroutofrangeageDonor(Donor donor)
        {

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            bool helpme;

            if (Actions.IsElementPresent(txtconfirmdiff))
            {
                if (Actions.IsElementPresent(txtconfirmdob))
                {
                    CommonActions.SetText(txtconfirmdob, donor.DateOfBirth);
                    if (Actions.IsElementContainsText(txtdob, DateOfBirth))
                    { DateOfBirth = donor.DateOfBirth; }
                }
                if (Actions.IsElementPresent(txtfirstname))
                {
                    FirstName = donor.FirstName;
                    if (Actions.IsElementContainsText(txtfirstname, FirstName))
                    { FirstName = donor.FirstName; }
                }
                if (Actions.IsElementPresent(txtconfirmlastname))
                {
                    CommonActions.SetText(txtconfirmlastname, gblLastName);
                    //if (Actions.IsElementContainsText(txtconfirmlastname, LastName))
                    helpme = Actions.IsElementContainsText(txtconfirmlastname, gblLastName);
                    if (Actions.IsElementDoesNotContainsText(txtconfirmlastname, gblLastName))
                    { CommonActions.SetText(txtconfirmlastname, gblLastName); }
                }
                if (Actions.IsElementPresent(txtconfirmgender))
                {
                    CommonActions.SetText(txtconfirmgender, donor.Gender);
                    if (Actions.IsElementContainsText(selectsex, Gender))
                    { Gender = donor.Gender; }
                }
                if (Actions.IsElementPresent(txtssn))
                {
                    SSN = donor.SSN;
                    if (Actions.IsElementContainsText(txtssn, SSN))
                    { SSN = donor.SSN; }
                }
                Actions.Click(btnok);
            }


            MiddleName = donor.MiddleName;
            Suffix = donor.Suffix;
            //ScanID = donor.ScanID;
            Height = donor.Height;
            Weight = donor.Weight;
            Actions.Click(selectethnicity);
            Ethnicity = donor.Ethnicity;
            Address = donor.Address;
            AptNumber = donor.AptNumber;
            Actions.Click(txtcity);
            City = donor.City;
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.PressKey(Keys.Tab, txtcity);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            ZipCode = donor.ZipCode;
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.PressKey(Keys.Tab, txtzip);
            Waits.WaitForPageLoad();
            gblState = Actions.GetText(txtstate);
            Actions.ScrollToElement(chkidverify);
            Waits.WaitForPageLoad();
            Actions.Click(chkidverify);
            //this is for temporary message
            Actions.Click(btnverifyok);
            Waits.WaitForPageLoad();
            if (donor.PrefHomePhone == "Y")
                PrefHomePhone = donor.PrefHomePhone;
            HomePhone = donor.HomePhone;
            if (donor.PrefWorkPhone == "Y")
                PrefWorkPhone = donor.PrefWorkPhone;
            WorkPhone = donor.WorkPhone;
            //WorkExtension = "^";
            if (donor.PrefMobilePhone == "Y")
                PrefMobilePhone = donor.PrefMobilePhone;
            MobilePhone = donor.MobilePhone;
            Email = donor.Email;

            Actions.ScrollToElement(txtemployername);
            EmployerName = donor.EmployerName;
            EmployerCity = donor.EmployerCity;
            EmployerZip = donor.EmployerZip;
            Actions.ScrollToElement(txtsponsor);
            Waits.WaitForPageLoad();
            Sponsor = donor.Sponsor;

            Actions.ScrollToElement(btnregister);
            Actions.Click(selectdonation);
            DonationType = donor.DonationType;
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            ProcedureCode = donor.ProcedureCode;
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            if (Actions.IsEnabled(equipment))
                Equipment = donor.Equipment;
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.ScrollToElement(btnregister);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnregister);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            txtDonorID = Actions.GetText(txtdonoralert).Substring(53, 10);
            txtDonorIDonly = Actions.GetText(txtdonoralert).Substring(55, 8);
            //Verify.ElementContainsText(txtmessage, "Msg: 21000: Donor Registered Successfully. Donor ID: " + txtDonorID);
            //Report.LogPassedTest("Donor " + txtDonorID + " is registered");
            //Report.TakeScreenshot();

            //Actions.Click(btnverifyok);
            //Waits.WaitForPageLoad();
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Actions.Click(lnkonsitemodulemenu);

        }

        public void ReturnRegistration()
        {


            Actions.ScrollToElement(chkidverify);
            Waits.WaitForPageLoad();
            Actions.Click(chkidverify);
            //this is for temporary message
            Actions.Click(btnverifyok);
            Waits.WaitForPageLoad();
            Actions.ScrollToElement(btnregister);
            Actions.Click(selectdonation);
            CommonActions.SetText(selectdonation, "AL");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(selectprocedure, "WB");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            if (Actions.IsEnabled(equipment))
                CommonActions.SetText(equipment, "AMIC");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.ScrollToElement(btnregister);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnregister);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


        }

        public void ReturnRegistrationNoSave(string ssn, string lastname, string firstname, string dob, string gender, string donorid)
        {
            //Waits.WaitForPageLoad();
            ////Actions.Click(btnselect);
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


            if (Actions.IsElementPresent(txtconfirmdiff))
            {
                if (Actions.IsElementPresent(txtconfirmdob))
                {
                    CommonActions.SetText(txtconfirmdob, dob);
                    //ConfirmDateOfBirth = dob;
                    if (Actions.IsElementContainsText(txtconfirmdob, dob))
                    { ConfirmDateOfBirth = dob; }
                }
                if (Actions.IsElementPresent(txtfirstname))
                {
                    FirstName = firstname;
                    if (Actions.IsElementContainsText(txtfirstname, firstname))
                    { FirstName = firstname; }
                }
                if (Actions.IsElementPresent(txtlastname))
                {
                    LastName = lastname;
                    if (Actions.IsElementContainsText(txtlastname, lastname))
                    { LastName = lastname; }
                }
                if (Actions.IsElementPresent(txtconfirmgender))
                {
                    CommonActions.SetText(txtconfirmgender, gender);
                    if (Actions.IsElementContainsText(selectsex, gender))
                    { Gender = gender; }
                }
                if (Actions.IsElementPresent(txtssn))
                {
                    SSN = ssn;
                    if (Actions.IsElementContainsText(txtssn, ssn))
                    { SSN = ssn; }
                }
                Actions.Click(btnok);
            }
            else
                Actions.Click(btnselect);



            Actions.ScrollToElement(chkidverify);
            Waits.WaitForPageLoad();
            Actions.Click(chkidverify);
            //this is for temporary message
            Actions.Click(btnverifyok);
            Waits.WaitForPageLoad();
            Actions.ScrollToElement(btnregister);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Actions.Click(selectdonation);
            CommonActions.SetText(selectdonation, "AL");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(selectprocedure, "WB");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            if (Actions.IsEnabled(equipment))
                CommonActions.SetText(equipment, "AMIC");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            CommonActions.SetText(txtsecondweight, "175");



    }

        public void UpdateDonorAddress()
        {
            gblHomePhone = "(303) 554-8848";
            gblEmployerName = "TOTAL QUALITY LABELS";
            gblAddress = "175 WASHINGTON AVE";
            gblCity = "DENVER";
            gblZipCode = "80205";

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            bool helpme;

            if (Actions.IsElementPresent(txtconfirmdiff))
            {
                if (Actions.IsElementPresent(txtconfirmdob))
                {
                    CommonActions.SetText(txtconfirmdob, gblDateOfBirth);
                    if (Actions.IsElementContainsText(txtdob, DateOfBirth))
                    { DateOfBirth = gblDateOfBirth; }
                }
                if (Actions.IsElementPresent(txtfirstname))
                {
                    FirstName = gblFirstName;
                    if (Actions.IsElementContainsText(txtfirstname, FirstName))
                    { FirstName = gblFirstName; }
                }
                if (Actions.IsElementPresent(txtconfirmlastname))
                {
                    CommonActions.SetText(txtconfirmlastname, gblLastName);
                    //if (Actions.IsElementContainsText(txtconfirmlastname, LastName))
                    helpme = Actions.IsElementContainsText(txtconfirmlastname, gblLastName);
                    if (Actions.IsElementDoesNotContainsText(txtconfirmlastname, gblLastName))
                    { CommonActions.SetText(txtconfirmlastname, gblLastName); }
                }
                if (Actions.IsElementPresent(txtconfirmgender))
                {
                    CommonActions.SetText(txtconfirmgender, gblGender);
                    if (Actions.IsElementContainsText(selectsex, Gender))
                    { Gender = gblGender; }
                }
                if (Actions.IsElementPresent(txtssn))
                {
                    SSN = gblSSN;
                    if (Actions.IsElementContainsText(txtssn, SSN))
                    { SSN = gblSSN; }
                }
                Actions.Click(btnok);
            }

            Actions.SendKeys(txtaddress, Keys.LeftShift+Keys.Home);
            CommonActions.SetText(txtaddress, gblAddress);

            Actions.SendKeys(txtcity, Keys.LeftShift + Keys.Home);
            CommonActions.SetText(txtcity, gblCity);
            Actions.SendKeys(txtzip, Keys.LeftShift + Keys.Home);
            CommonActions.SetText(txtzip, gblZipCode);

            Actions.Click(chkidverify);
            Actions.Click(btnverifyok);
            Waits.WaitForPageLoad();
            Actions.Click(chkhomephone);
            CommonActions.SetText(txthomephone, "3035548848");
            Actions.ScrollToElement(txtemployername);
            CommonActions.SetText(txtemployername, gblEmployerName);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.ScrollToElement(btnupdate);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnupdate);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);


        }

        public void EnterNewDonorNameGiven(Donor donor, string firstnamenew, string lastnamenew, string dobnew, string gendernew)
        {
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnnew);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            bool helpme;

            if (Actions.IsElementPresent(txtconfirmdiff))
            {
                if (Actions.IsElementPresent(txtconfirmdob))
                {
                    CommonActions.SetText(txtconfirmdob, dobnew);
                    if (Actions.IsElementContainsText(txtdob, dobnew))
                    { DateOfBirth = dobnew; }
                }
                if (Actions.IsElementPresent(txtfirstname))
                {
                    FirstName = firstnamenew;
                    if (Actions.IsElementContainsText(txtfirstname, firstnamenew))
                    { FirstName = firstnamenew; }
                }
                if (Actions.IsElementPresent(txtconfirmlastname))
                {
                    CommonActions.SetText(txtconfirmlastname, lastnamenew);
                    //if (Actions.IsElementContainsText(txtconfirmlastname, LastName))
                    helpme = Actions.IsElementContainsText(txtconfirmlastname, lastnamenew);
                    if (Actions.IsElementDoesNotContainsText(txtconfirmlastname, lastnamenew))
                    { CommonActions.SetText(txtconfirmlastname, lastnamenew); }
                }
                if (Actions.IsElementPresent(txtconfirmgender))
                {
                    CommonActions.SetText(txtconfirmgender, gendernew);
                    if (Actions.IsElementContainsText(selectsex, gendernew))
                    { Gender = gendernew; }
                }
                if (Actions.IsElementPresent(txtssn))
                {
                    SSN = donor.SSN;
                    if (Actions.IsElementContainsText(txtssn, SSN))
                    { SSN = donor.SSN; }
                }
                Actions.Click(btnok);
            }


            MiddleName = donor.MiddleName;
            Suffix = donor.Suffix;
            //ScanID = donor.ScanID;
            Height = donor.Height;
            Weight = donor.Weight;
            Actions.Click(selectethnicity);
            Ethnicity = donor.Ethnicity;
            Address = donor.Address;
            AptNumber = donor.AptNumber;
            Actions.Click(txtcity);
            City = donor.City;
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.PressKey(Keys.Tab, txtcity);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            ZipCode = donor.ZipCode;
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.PressKey(Keys.Tab, txtzip);
            Waits.WaitForPageLoad();
            gblState = Actions.GetText(txtstate);
            Actions.ScrollToElement(chkidverify);
            Waits.WaitForPageLoad();
            Actions.Click(chkidverify);
            //this is for temporary message
            Actions.Click(btnverifyok);
            Waits.WaitForPageLoad();
            if (donor.PrefHomePhone == "Y")
                PrefHomePhone = donor.PrefHomePhone;
            HomePhone = donor.HomePhone;
            if (donor.PrefWorkPhone == "Y")
                PrefWorkPhone = donor.PrefWorkPhone;
            WorkPhone = donor.WorkPhone;
            //WorkExtension = "^";
            if (donor.PrefMobilePhone == "Y")
                PrefMobilePhone = donor.PrefMobilePhone;
            MobilePhone = donor.MobilePhone;
            Email = donor.Email;

            Actions.ScrollToElement(txtemployername);
            EmployerName = donor.EmployerName;
            EmployerCity = donor.EmployerCity;
            EmployerZip = donor.EmployerZip;
            Actions.ScrollToElement(txtsponsor);
            Waits.WaitForPageLoad();
            Sponsor = donor.Sponsor;

            Actions.ScrollToElement(btnregister);
            Actions.Click(selectdonation);
            DonationType = donor.DonationType;
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            ProcedureCode = donor.ProcedureCode;
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Equipment = donor.Equipment;
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.ScrollToElement(btnregister);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnregister);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            txtDonorID = Actions.GetText(txtdonoralert).Substring(53, 10);
            txtDonorIDonly = Actions.GetText(txtdonoralert).Substring(55, 8);
            //Verify.ElementContainsText(txtmessage, "Msg: 21000: Donor Registered Successfully. Donor ID: " + txtDonorID);
            //Report.LogPassedTest("Donor " + txtDonorID + " is registered");
            //Report.TakeScreenshot();

            //Actions.Click(btnverifyok);
            //Waits.WaitForPageLoad();
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Actions.Click(lnkonsitemodulemenu);


        }

        public void FindDonorNameGiven(Donor donor, string firstname, string lastname, string dob, string gender)
        {
            //CommonActions.WaitForPageLoad();
            //Verify.ExactPageTitle("BC-Onsite (Lookup & Registration)");
            if (Actions.IsEnabled(txtlastname))
            {
                LastName = lastname;
                if (Actions.IsElementDoesNotContainsText(txtlastname, LastName))
                { LastName = lastname; }
            }
            if (Actions.IsEnabled(txtfirstname))
            {
                FirstName = firstname;
                if (Actions.IsElementContainsText(txtfirstname, FirstName))
                { FirstName = firstname; }
            }
            if (Actions.IsEnabled(txtdob))
            {
                DateOfBirth = dob;
                if (Actions.IsElementContainsText(txtdob, DateOfBirth))
                { DateOfBirth = dob; }
            }
            if (Actions.IsEnabled(selectsex))
            {
                Actions.Click(selectsex);
                Gender = gender;
                if (Actions.IsElementContainsText(selectsex, Gender))
                //if (Actions.IsElementDoesNotContainsText(selectsex, Gender))

                { Gender = gender; }
            }
            CommonActions.SetText(txtdonorid, "^");
            Boolean ssnenabled = Actions.IsEnabled(txtssn);
            if (Actions.IsEnabled(txtssn))
            {
                SSN = donor.SSN;
                if (Actions.IsElementContainsText(txtssn, SSN))
                { SSN = donor.SSN; }
            }
            Waits.WaitForPageLoad();
            if (Actions.IsEnabled(txtalternatetype))
            {
                AlternateType = donor.AlternateType;
                if (Actions.IsElementContainsText(txtalternatetype, AlternateType))
                { AlternateType = donor.AlternateType; }
            }
            if (Actions.IsEnabled(txtalternateid))
            {
                AlternateID = donor.AlternateID;
                if (Actions.IsElementContainsText(txtalternateid, AlternateID))
                { AlternateID = donor.AlternateID; }

            }

            Actions.Click(btnsearch);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Actions.Click(btnmultiok);

        }

        public void EnterExistingDonorDonTypeProcCode(string ssn, string lastname, string firstname, string dob, string gender, string donorid, string donationtype, string procedurecode)
        {

            //Waits.WaitForPageLoad();
            ////Actions.Click(btnselect);
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            gblGender = gender;

            if (Actions.IsElementPresent(txtconfirmdiff))
            {
                if (Actions.IsElementPresent(txtconfirmdob))
                {
                    CommonActions.SetText(txtconfirmdob, dob);
                    //ConfirmDateOfBirth = dob;
                    if (Actions.IsElementContainsText(txtconfirmdob, dob))
                    { ConfirmDateOfBirth = dob; }
                }
                if (Actions.IsElementPresent(txtfirstname))
                {
                    FirstName = firstname;
                    if (Actions.IsElementContainsText(txtfirstname, firstname))
                    { FirstName = firstname; }
                }
                if (Actions.IsElementPresent(txtlastname))
                {
                    LastName = lastname;
                    if (Actions.IsElementContainsText(txtlastname, lastname))
                    { LastName = lastname; }
                }
                if (Actions.IsElementPresent(txtconfirmgender))
                {
                    CommonActions.SetText(txtconfirmgender, gender);
                    if (Actions.IsElementContainsText(selectsex, gender))
                    { Gender = gender; }
                }
                if (Actions.IsElementPresent(txtssn))
                {
                    SSN = ssn;
                    if (Actions.IsElementContainsText(txtssn, ssn))
                    { SSN = ssn; }
                }
                Actions.Click(btnok);
            }
            else
                Actions.Click(btnselect);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(chkidverify);
            //this is for temporary message
            Actions.Click(btnverifyok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(txtalternateid);
            var donorhomephone = Actions.ExecuteJavascript<string>("document.getElementById('input-home-phone').value");
            var donorhomephonecheck = Actions.ExecuteJavascript<string>("document.getElementById('check-phone-h').value");
            var donorworkphone = Actions.ExecuteJavascript<string>("document.getElementById('input-work-phone').value");
            var donorworkphonecheck = Actions.ExecuteJavascript<string>("document.getElementById('check-phone-d').value");
            var donormobilephone = Actions.ExecuteJavascript<string>("document.getElementById('input-mobile-phone').value");
            var donormobilephonecheck = Actions.ExecuteJavascript<string>("document.getElementById('check-phone-m').value");
            var donorweight = Actions.ExecuteJavascript<string>("document.getElementById('input-weight').value");
            var donorheight = Actions.ExecuteJavascript<string>("document.getElementById('input-height').value");

            if (donorheight == "")
            {
                CommonActions.SetText(txtheight, "5'7\"");
            }
            if (donorweight == "")
            {
                CommonActions.SetText(txtweight, "200");
            }
            Actions.Click(txtalternateid);

            if (donorhomephone != "")
            {
                //if (donorhomephonecheck == "")
                    Actions.Click(chkhomephone);
            }
            if (donorworkphone != "")
            {
                if (donorworkphonecheck == "")
                    Actions.Click(chkworkphone);
            }
            if (donormobilephone != "")
            {
                if (donormobilephonecheck == "")
                    Actions.Click(chkmobilephone);
            }
            Actions.Click(txtemail);
            Actions.ScrollToBottom();
            Actions.ScrollToElement(btnregister);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Waits.WaitForElementToBeVisible(btnregister, Core.WaitType.Small);
            Actions.Click(selectdonation);
            Actions.SendKeys(selectdonation, donationtype);
            Actions.PressKey(Keys.Tab, selectdonation);

            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            //Actions.Click(selectprocedure);
            Actions.SendKeys(selectprocedure, procedurecode);
            Actions.PressKey(Keys.Tab, selectprocedure);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.ScrollToElement(btnregister);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            if (Actions.IsEnabled(equipment))
                CommonActions.SetText(equipment, "VIST");
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnregister);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            txtDonorID = Actions.GetText(txtdonoralert).Substring(53, 10);
            txtDonorIDonly = Actions.GetText(txtdonoralert).Substring(55, 8);
            //Verify.ElementContainsText(txtmessage, "Msg: 21000: Donor Registered Successfully. Donor ID: " + txtDonorID);
            //Report.LogPassedTest("Donor " + txtDonorID + " is registered");
            //Report.TakeScreenshot();

            //Actions.Click(btnverifyok);
            //Waits.WaitForPageLoad();
            //Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

            //Actions.Click(lnkonsitemodulemenu);

        }

        public void generateunitid()
        {
            //generate Unit ID
            Random random = new Random();
            int randomNumber = random.Next(50, 100);
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10));
            if (Actions.GetText(lblusername) == "AUTUSR")
                gblunitdeferralid = "W1234" + txtcurrentchapterdate.ToString("yy/MM/dd").Replace("/", "") + randomNumber;
            else
                gblunitdeferralid = "W6333" + txtcurrentchapterdate.ToString("yy/MM/dd").Replace("/", "") + randomNumber;

        }

        public void generatedeferralid()
        {
            //generate Unit ID
            Random random = new Random();
            int randomNumber = random.Next(50, 100);
            DateTime txtcurrentchapterdate = Convert.ToDateTime(Actions.GetText(lblchapterdate).Substring(0, 10));
            gblunitdeferralid = txtcurrentchapterdate.ToString("yy/MM/dd").Replace("/", "") + randomNumber;

        }

        public void ReturnRegistrationfromHold()
        {


            Actions.ScrollToElement(chkidverify);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(chkidverify);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnverifyok);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.ScrollToElement(btnupdate);
            Actions.PressKey(Keys.ArrowDown);
            Actions.PressKey(Keys.ArrowDown);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);
            Actions.Click(btnupdate);
            Waits.WaitForElementToBeInvisible(By.Id("loading-dialog"), Core.WaitType.Small);

        }


    }
}
