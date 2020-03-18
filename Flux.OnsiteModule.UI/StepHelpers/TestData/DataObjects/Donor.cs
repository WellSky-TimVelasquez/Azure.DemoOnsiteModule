using Flux.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flux.Web;

namespace Flux.OnsiteModule.UI
{
    public class Donor
    {
        public class DonorBuilder : Builder<Donor, DonorBuilder> { }

        /// <summary>
        /// Method to create a standard donor with mandatory details filled.
        /// </summary>
        public static string RandomString(int length)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        public static string RandomNum(int length)
        {
            Random rnd = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
        public Donor()
        {
            var StringUtils = new StringUtils();
            var NumberUtils = new NumberUtils();
            var DateTimeUtils = new DateTimeUtils();
            
            FirstName = RandomString(10);
            LastName = RandomString(11);
            DateOfBirth = (DateTimeUtils.GetDate(-(Convert.ToInt32("1" + RandomNum(4)))).Replace("/", "-"));
            //DateOfBirth = "05171990";
            Gender = "M";
            SSN = RandomNum(9);
            AlternateType = "DRLIC";
            AlternateID = RandomNum(6);
            MiddleName = "S";
            Suffix = "";
            ScanID = "^";
            Height = "5'7\"";
            Weight = "200";
            Ethnicity = "CA";
            Address = RandomNum(4) + " WESTERN AVE";
            City = "Chicago";
            AptNumber = "1A";
            ZipCode = "60606";
            Email = "test@yahoo.com";
            EmployerName = "^";
            EmployerCity = "^";
            EmployerZip = "^";
            Sponsor = "";
            PrefHomePhone = "^";
            HomePhone = "^";
            PrefWorkPhone = "^";
            WorkPhone = "^";
            WorkExtension = "^";
            PrefMobilePhone = "^";
            MobilePhone = "^";
            DonationType = "AL";
            ProcedureCode = "WB";
            Equipment = "VIST";

        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string SSN { get; set; }
        public string AlternateType { get; set; }
        public string AlternateID { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public string ScanID { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Ethnicity { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string AptNumber { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string EmployerName { get; set; }
        public string EmployerCity { get; set; }
        public string EmployerZip { get; set; }
        public string Sponsor { get; set; }
        public string PrefHomePhone { get; set; }
        public string HomePhone { get; set; }
        public string PrefWorkPhone { get; set; }
        public string WorkPhone { get; set; }
        public string WorkExtension { get; set; }
        public string PrefMobilePhone { get; set; }
        public string MobilePhone { get; set; }
        public string DonationType { get; set; }
        public string ProcedureCode { get; set; }
        public string Equipment { get; set; }

    }
}
