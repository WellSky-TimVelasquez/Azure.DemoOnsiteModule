// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Flux.OnsiteModule.UI.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Link")]
    public partial class LinkFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Link.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Link", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("I login the application as a Blood Centers User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I open Active Drive screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("I activate a drive", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Linkaunit")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void Linkaunit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Linkaunit", null, new string[] {
                        "test"});
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 13
 testRunner.Given("I register a new donor with AL WB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.And("I navigate to the Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("I select the donor in Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then("I can open Health History", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.And("I complete AL Health History questions with no exceptions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("I complete the Health History Summary page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I signoff on the Health History page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("the Health History statistics block is updated as complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("I can open Physical Findings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.And("Valid Physical Findings entry is made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("Physical Findings is completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.Then("I can open Consent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.And("I manually sign consent one and two", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("I open the link screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("I link unit number to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("the donor is in the Onsite Status Query", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Unlinkaunit")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void Unlinkaunit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Unlinkaunit", null, new string[] {
                        "test"});
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 34
 testRunner.Given("I register a new donor with AL WB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
 testRunner.And("I navigate to the Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("I select the donor in Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then("I can open Health History", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.And("I complete AL Health History questions with no exceptions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("I complete the Health History Summary page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("I signoff on the Health History page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.Then("the Health History statistics block is updated as complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.Then("I can open Physical Findings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.And("Valid Physical Findings entry is made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("Physical Findings is completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.Then("I can open Consent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.And("I manually sign consent one and two", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("I open the link screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("I link unit number to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.And("I open the link screen from the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("I unlink the unit id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.Then("the unit id is unlinked in Link Query", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("LinkaunitwithDataALWB")]
        [NUnit.Framework.CategoryAttribute("systemtest")]
        [NUnit.Framework.TestCaseAttribute("IAN", "THORNTON", "11042000", "M", null)]
        [NUnit.Framework.TestCaseAttribute("DAN", "BATEMAN", "05111980", "M", null)]
        [NUnit.Framework.TestCaseAttribute("KIRK", "ROBINSON", "09261980", "M", null)]
        public virtual void LinkaunitwithDataALWB(string firstname, string lastname, string dob, string gender, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "systemtest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LinkaunitwithDataALWB", null, @__tags);
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 58
 testRunner.Given(string.Format("I register a new donor with AL WB and {0} {1} {2} {3}", firstname, lastname, dob, gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
 testRunner.And("I navigate to the Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("I select the donor in Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.Then("I can open Health History", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.And("I complete AL Health History questions with no exceptions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("I complete the Health History Summary page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("I signoff on the Health History page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.Then("the Health History statistics block is updated as complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.Then("I can open Physical Findings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.And("Valid Physical Findings entry is made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("Physical Findings is completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.Then("I can open Consent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.And("I manually sign consent one and two", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("I open the link screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("I link unit number to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("LinkaunitwithDataALPP")]
        [NUnit.Framework.TestCaseAttribute("JOE", "JONES", "04101970", "M", null)]
        public virtual void LinkaunitwithDataALPP(string firstname, string lastname, string dob, string gender, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LinkaunitwithDataALPP", null, exampleTags);
#line 81
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 82
 testRunner.Given(string.Format("I register a new donor with AL PP and {0} {1} {2} {3}", firstname, lastname, dob, gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 83
 testRunner.And("I navigate to the Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("I select the donor in Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.Then("I can open Health History", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.And("I complete AL Health History questions with no exceptions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("I complete the Health History Summary page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("I signoff on the Health History page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.Then("the Health History statistics block is updated as complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.Then("I can open Physical Findings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.And("Valid AL PP Physical Findings entry is made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("Physical Findings is completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.Then("I can open Consent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.And("I manually sign consent one and two", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("I open the link screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("I link unit number to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("LinkaunitwithDataALPPAMIC")]
        [NUnit.Framework.CategoryAttribute("systemtest")]
        [NUnit.Framework.TestCaseAttribute("NICK", "DAVIS", "11141995", "M", null)]
        public virtual void LinkaunitwithDataALPPAMIC(string firstname, string lastname, string dob, string gender, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "systemtest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LinkaunitwithDataALPPAMIC", null, @__tags);
#line 104
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 105
 testRunner.Given(string.Format("I register a new donor with AL PP AMIC and {0} {1} {2} {3}", firstname, lastname, dob, gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 106
 testRunner.And("I navigate to the Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("I select the donor in Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.Then("I can open Health History", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.And("I complete AL Health History questions with no exceptions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("I complete the Health History Summary page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("I signoff on the Health History page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.Then("the Health History statistics block is updated as complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.Then("I can open Physical Findings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
 testRunner.And("Valid AL PP Physical Findings entry is made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("Physical Findings is completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.Then("I can open Consent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
 testRunner.And("I manually sign consent one and two", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And("I open the link screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("I link unit number to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("LinkaunitreturningdonorwithDataALPP")]
        [NUnit.Framework.CategoryAttribute("systemtest")]
        [NUnit.Framework.TestCaseAttribute("792131455", "HWANG", "PATRICIA", "08141989", "F", "DN30114854", null)]
        [NUnit.Framework.TestCaseAttribute("652548555", "GROHN", "WES", "06041955", "M", "DN30115140", null)]
        [NUnit.Framework.TestCaseAttribute("620802012", "PACHECO", "MICHAEL", "09101959", "M", "DN30119980", null)]
        [NUnit.Framework.TestCaseAttribute("485735633", "HOPPER", "DUNCAN", "05291982", "M", "DN30117359", null)]
        public virtual void LinkaunitreturningdonorwithDataALPP(string ssn, string lastname, string firstname, string dob, string gender, string donorid, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "systemtest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LinkaunitreturningdonorwithDataALPP", null, @__tags);
#line 126
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 127
 testRunner.Given(string.Format("I have entered {0} in find donor", donorid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 128
 testRunner.And(string.Format("I register an existing {0} {1} {2} {3} {4} and {5} with AL PP", ssn, lastname, firstname, dob, gender, donorid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.And("I navigate to the Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.And("I select the donor in Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.Then("I can open Health History", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.And("I complete AL Health History questions with no exceptions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.And("I complete the Health History Summary page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And("I signoff on the Health History page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.Then("the Health History statistics block is updated as complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 136
 testRunner.Then("I can open Physical Findings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
 testRunner.And("Valid AL PP Physical Findings entry is made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("Physical Findings is completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.Then("I can open Consent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.And("I manually sign consent one and two", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.And("I open the link screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
 testRunner.And("I link unit number to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("LinkaunitreturningdonorwithDataAUPP")]
        [NUnit.Framework.CategoryAttribute("systemtest")]
        [NUnit.Framework.TestCaseAttribute("792156493", "RABIDOUX", "COURTNEY", "03141976", "F", "DN00021089", null)]
        public virtual void LinkaunitreturningdonorwithDataAUPP(string ssn, string lastname, string firstname, string dob, string gender, string donorid, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "systemtest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LinkaunitreturningdonorwithDataAUPP", null, @__tags);
#line 152
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 153
 testRunner.Given(string.Format("I have entered {0} in find donor", donorid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 154
 testRunner.And(string.Format("I register an existing {0} {1} {2} {3} {4} and {5} with AU PP", ssn, lastname, firstname, dob, gender, donorid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.And("I navigate to the Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
 testRunner.And("I select the donor in Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.Then("I can open Health History", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 158
 testRunner.And("I complete AU Health History questions with no exceptions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.And("I complete the Health History Summary page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
 testRunner.And("I signoff on the Health History page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.Then("the Health History statistics block is updated as complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 162
 testRunner.Then("I can open Physical Findings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 163
 testRunner.And("Valid Physical Findings entry is made with AU PP", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.And("Physical Findings is completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
 testRunner.Then("I can open Consent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 166
 testRunner.And("I manually sign consent one and two", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 167
 testRunner.And("I open the link screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 168
 testRunner.And("I link unit number to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("LinkaunitreturningdonorwithDataALWB")]
        [NUnit.Framework.CategoryAttribute("systemtest")]
        [NUnit.Framework.TestCaseAttribute("266332333", "ROSEMARY", "JEFF", "01011990", "M", "DN30119222", null)]
        [NUnit.Framework.TestCaseAttribute("487544432", "WINTERS", "NATE", "03121980", "M", "DN30119228", null)]
        [NUnit.Framework.TestCaseAttribute("792146337", "HOLLAND", "DONNA", "05181962", "F", "DN30105549", null)]
        public virtual void LinkaunitreturningdonorwithDataALWB(string ssn, string lastname, string firstname, string dob, string gender, string donorid, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "systemtest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LinkaunitreturningdonorwithDataALWB", null, @__tags);
#line 175
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 176
 testRunner.Given(string.Format("I have entered {0} in find donor", donorid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 177
 testRunner.And(string.Format("I register an existing {0} {1} {2} {3} {4} and {5} with AL WB", ssn, lastname, firstname, dob, gender, donorid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
 testRunner.And("I navigate to the Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
 testRunner.And("I select the donor in Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 180
 testRunner.Then("I can open Health History", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 181
 testRunner.And("I complete AL Health History questions with no exceptions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
 testRunner.And("I complete the Health History Summary page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
 testRunner.And("I signoff on the Health History page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 184
 testRunner.Then("the Health History statistics block is updated as complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 185
 testRunner.Then("I can open Physical Findings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 186
 testRunner.And("Valid Physical Findings entry is made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 187
 testRunner.And("Physical Findings is completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 188
 testRunner.Then("I can open Consent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 189
 testRunner.And("I manually sign consent one and two", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 190
 testRunner.And("I open the link screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 191
 testRunner.And("I link unit number to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 192
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Voidaunit")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void Voidaunit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Voidaunit", null, new string[] {
                        "test"});
#line 200
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 201
 testRunner.Given("I register a new donor with AL WB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 202
 testRunner.And("I navigate to the Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 203
 testRunner.And("I select the donor in Health History/Physical screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 204
 testRunner.Then("I can open Health History", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 205
 testRunner.And("I complete AL Health History questions with no exceptions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 206
 testRunner.And("I complete the Health History Summary page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 207
 testRunner.And("I signoff on the Health History page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 208
 testRunner.Then("the Health History statistics block is updated as complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 209
 testRunner.Then("I can open Physical Findings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 210
 testRunner.And("Valid Physical Findings entry is made", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 211
 testRunner.And("Physical Findings is completed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 212
 testRunner.Then("I can open Consent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 213
 testRunner.And("I manually sign consent one and two", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 214
 testRunner.And("I open the link screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 215
 testRunner.And("I link unit number to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 216
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 217
 testRunner.And("I open the link screen from the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 218
 testRunner.And("a new unit number is entered to void the unit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 219
 testRunner.Then("the void information is entered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 220
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("LinkTemporaryDeferralID")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void LinkTemporaryDeferralID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LinkTemporaryDeferralID", null, new string[] {
                        "test"});
#line 223
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 224
 testRunner.Given("I register a new donor with AL WB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 225
 testRunner.And("I open the link screen from the menu for a deferral", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 226
 testRunner.And("I link temporary deferral id to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 227
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 228
 testRunner.Then("the donor is in the Onsite Status Query", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("LinkPermanentDeferralID")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void LinkPermanentDeferralID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("LinkPermanentDeferralID", null, new string[] {
                        "test"});
#line 231
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 232
 testRunner.Given("I register a new donor with AL WB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 233
 testRunner.And("I open the link screen from the menu for a deferral", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 234
 testRunner.And("I link permanent deferral id to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 235
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Unlinkadeferral")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void Unlinkadeferral()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Unlinkadeferral", null, new string[] {
                        "test"});
#line 238
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 239
 testRunner.Given("I register a new donor with AL WB", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 240
 testRunner.And("I open the link screen from the menu for a deferral", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 241
 testRunner.And("I link permanent deferral id to the donation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 242
 testRunner.Then("the unit is linked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 243
 testRunner.And("I open the link screen from the menu for a deferral", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 244
 testRunner.And("I unlink the deferral id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 245
 testRunner.Then("the unit id is unlinked in Link Query", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
