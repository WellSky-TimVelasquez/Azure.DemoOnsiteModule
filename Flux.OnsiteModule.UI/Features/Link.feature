Feature: Link
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive

@test
Scenario: Linkaunit
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then I can open Physical Findings
	And Valid Physical Findings entry is made
	And Physical Findings is completed
	Then I can open Consent
	And I manually sign consent one and two
	And I open the link screen
	And I link unit number to the donation
	Then the unit is linked
	Then the donor is in the Onsite Status Query


@test
Scenario: Unlinkaunit
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then I can open Physical Findings
	And Valid Physical Findings entry is made
	And Physical Findings is completed
	Then I can open Consent
	And I manually sign consent one and two
	And I open the link screen
	And I link unit number to the donation
	Then the unit is linked
	And I open the link screen from the menu
	And I unlink the unit id
	Then the unit id is unlinked in Link Query



@systemtest
Scenario Outline: LinkaunitwithDataALWB
	Given I register a new donor with AL WB and <firstname> <lastname> <dob> <gender>
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then I can open Physical Findings
	And Valid Physical Findings entry is made
	And Physical Findings is completed
	Then I can open Consent
	And I manually sign consent one and two
	And I open the link screen
	And I link unit number to the donation
	Then the unit is linked
Examples:
| firstname | lastname | dob      | gender | 
| IAN     | THORNTON    | 11042000 | M      |
| DAN     | BATEMAN    | 05111980 | M      |
| KIRK     | ROBINSON    | 09261980 | M      |


Scenario Outline: LinkaunitwithDataALPP
	Given I register a new donor with AL PP and <firstname> <lastname> <dob> <gender>
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then I can open Physical Findings
	And Valid AL PP Physical Findings entry is made
	And Physical Findings is completed
	Then I can open Consent
	And I manually sign consent one and two
	And I open the link screen
	And I link unit number to the donation
	Then the unit is linked
Examples:
| firstname | lastname | dob      | gender | 
| JOE| JONES| 04101970 | M |


@systemtest
Scenario Outline: LinkaunitwithDataALPPAMIC
	Given I register a new donor with AL PP AMIC and <firstname> <lastname> <dob> <gender>
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then I can open Physical Findings
	And Valid AL PP Physical Findings entry is made
	And Physical Findings is completed
	Then I can open Consent
	And I manually sign consent one and two
	And I open the link screen
	And I link unit number to the donation
	Then the unit is linked
Examples:
| firstname | lastname | dob      | gender | 
| NICK | DAVIS | 11141995 | M|

@systemtest
Scenario Outline: LinkaunitreturningdonorwithDataALPP
	Given I have entered <donorid> in find donor
	And I register an existing <ssn> <lastname> <firstname> <dob> <gender> and <donorid> with AL PP
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then I can open Physical Findings
	And Valid AL PP Physical Findings entry is made
	And Physical Findings is completed
	Then I can open Consent
	And I manually sign consent one and two
	And I open the link screen
	And I link unit number to the donation
	Then the unit is linked
Examples:
| ssn       | lastname | firstname | dob      | gender | donorid | 
| 792131455 | HWANG    | PATRICIA  | 08141989 |F | DN30114854 | 
|652548555 | GROHN | WES | 06041955 | M | DN30115140 | 
|620802012 | PACHECO  | MICHAEL | 09101959 | M | DN30119980|
|485735633| HOPPER| DUNCAN| 05291982| M | DN30117359| 

@systemtest
Scenario Outline: LinkaunitreturningdonorwithDataAUPP
	Given I have entered <donorid> in find donor
	And I register an existing <ssn> <lastname> <firstname> <dob> <gender> and <donorid> with AU PP
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AU Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then I can open Physical Findings
	And Valid Physical Findings entry is made with AU PP
	And Physical Findings is completed
	Then I can open Consent
	And I manually sign consent one and two
	And I open the link screen
	And I link unit number to the donation
	Then the unit is linked
Examples:
| ssn       | lastname | firstname | dob      | gender | donorid    | 
| 792156493 | RABIDOUX | COURTNEY | 03141976 | F | DN00021089| 

@systemtest
Scenario Outline: LinkaunitreturningdonorwithDataALWB
	Given I have entered <donorid> in find donor
	And I register an existing <ssn> <lastname> <firstname> <dob> <gender> and <donorid> with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then I can open Physical Findings
	And Valid Physical Findings entry is made
	And Physical Findings is completed
	Then I can open Consent
	And I manually sign consent one and two
	And I open the link screen
	And I link unit number to the donation
	Then the unit is linked
Examples:
| ssn       | lastname | firstname | dob      | gender | donorid    | 
| 266332333 | ROSEMARY | JEFF | 01011990 | M | DN30119222 |
| 487544432 | WINTERS | NATE | 03121980 | M | DN30119228 | 
| 792146337 | HOLLAND | DONNA | 05181962 | F | DN30105549 | 

@test
Scenario: Voidaunit
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then I can open Physical Findings
	And Valid Physical Findings entry is made
	And Physical Findings is completed
	Then I can open Consent
	And I manually sign consent one and two
	And I open the link screen
	And I link unit number to the donation
	Then the unit is linked
	And I open the link screen from the menu
	And a new unit number is entered to void the unit
	Then the void information is entered
	Then the unit is linked

@test
Scenario: LinkTemporaryDeferralID
	Given I register a new donor with AL WB
	And I open the link screen from the menu for a deferral
	And I link temporary deferral id to the donation
	Then the unit is linked
	Then the donor is in the Onsite Status Query

@test
Scenario: LinkPermanentDeferralID
	Given I register a new donor with AL WB
	And I open the link screen from the menu for a deferral
	And I link permanent deferral id to the donation
	Then the unit is linked

@test
Scenario: Unlinkadeferral
	Given I register a new donor with AL WB
	And I open the link screen from the menu for a deferral
	And I link permanent deferral id to the donation
	Then the unit is linked
	And I open the link screen from the menu for a deferral
	And I unlink the deferral id
	Then the unit id is unlinked in Link Query


