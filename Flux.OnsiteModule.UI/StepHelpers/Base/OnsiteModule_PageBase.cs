using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flux.OnsiteModule.UI
{
    public abstract class OnsiteModule_PageBase : WebPageBase
    {
        ////If you have any project specific reusable classes please create an object for the same as mentioned below
        public CommonActions CommonActions { get => new CommonActions(Singleton.GetService<WebEnvironment>()); }

        public OnsiteHelper OnsiteHelper { get => new OnsiteHelper (Singleton.GetService<WebEnvironment>()); }

        //public Login Login { get => new Login (Singleton.GetService<WebEnvironment>()); }
        //Activate Drive

        public static String ONSITELOGIN = "BC-Onsite (Login)"; 
        public static String ONSITEMODULEMAINMENU = "BC-Onsite (Onsite Module Menu)";
        public static String ONSITEHHPF = "BC-Onsite (Health History & Physical Findings)";
        public static String ONSITEACTIVATEDRIVE = "BC-Onsite (Activate Drive)"; 
        public static String ONSITECOMPLETEDRIVE = "BC-Onsite(Complete Drive)";
        public static String DONORRESPONSE = "BC-Onsite (Donor Response)";
        public static String HEALTHHISTORY = "BC-Onsite (Health History Button)";
        public static String PHYSICALFINDINGS = "BC-Onsite (Physical Findings Button)";
        public static String ONSITESTATUSQUERY = "BC-Onsite (On-Site Status Query)";
        public static String WALKOUT = "BC-Onsite (Donor Walkout)";
        public static String LINKQUERY = "BC-Onsite (Unit/Deferral Link Status Query)";
        public static String CONSENT = "BC-Onsite (Donor Consents)";
        public static String LINK = "BC-Onsite (Link / Unlink Unit or Deferral)";
        public static String BLEED = "BC-Onsite (Bleed Time / Phlebotomy Data)";
        public static String EQUIPMENT = "BC-Onsite (Equipment & Supply QC)";

        public static String txtDonorID;
        public static String txtDonorIDonly;
        public static String gblLastName;
        public static String gblFirstName;
        public static String gblSSN;
        public static String gblDateOfBirth;
        public static String gblGender;
        public static String gblDonationType;
        public static String gblProcedureCode;
        public static String gblAddress;
        public static String gblAptNumber;
        public static String gblCity;
        public static String gblZipCode;
        public static String gblState;
        public static String gblMobilePhone;
        public static String gblHomePhone;
        public static String gblEmployerName;
        public static String strCommentDate;
        public static String gblintdrive;
        public static String gblunitdeferralid;
        public static String gblScale;
        public static String gblHcue;
        public static String gblamic;
        public static String gblbp;
        public static String gblalyx;
        public static String gblther;
        public static String gbltrim;
        public static String gblvist;
        public static String gblTransactionID;
        public static String SelectedDrive;
        public static int totaldrives = 0;
        public static List<string> DriveidList = new List<string>();
        public static List<string> SelectedLanguagelist = new List<string>();

        public static String updateid;






    }
}
