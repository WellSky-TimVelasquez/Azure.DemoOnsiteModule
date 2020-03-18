Feature: Bleed
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive


Scenario: EnterBleed
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
	And I open the bleed screen
	And I enter bleed information
	Then donation is set to complete in Onsite Status Query

Scenario: EnterBleedALPP
	Given I register a new donor with AL PP
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
	And I open the bleed screen
	And I enter bleed information for AL PP
	Then donation is set to complete in Onsite Status Query

@test
Scenario: UpdateProcedureCodetoPP
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
	And I update the procedure code to PP
	And Valid AL PP Physical Findings entry is made
	And Physical Findings is completed
	#And I manually sign consent one and two
	And I enter bleed information for AL PP
	Then donation is set to complete in Onsite Status Query

@systemtest
Scenario Outline: UpdateProcedureCodetoPPnoteligible
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
	And I link unit number <unitnumber> to the donation
	Then the unit is linked
	And I update the procedure code to WB
	And Valid Physical Findings entry is made
	And Physical Findings is completed
	#And I manually sign consent one and two
	And I open the bleed screen
	And I enter bleed information for AL PP
	Then donation is set to complete in Onsite Status Query
Examples:
| ssn       | lastname | firstname | dob      | gender | donorid    | unitnumber    |
| 111111111 | ALLEN | PAT | 08101970 | M | DN30123931 | W123420012202 |

@test @smoketest
Scenario: CompleteBleedALWBwithequipmentandsupply
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
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I enter SCALE with a status of PASS
	And I save the equipment and supply
	And I open the Supply screen
	And I enter Bags with a status of PASS
	And I save the equipment and supply
	And I open the bleed screen
	Then I add bleed equipment
	And I add bleed supplies
	And I enter bleed information
	Then donation is set to complete in Onsite Status Query

@test
Scenario: EnterBleedTimesOutsideDrive
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
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I enter SCALE with a status of PASS
	And I save the equipment and supply
	And I open the Supply screen
	And I enter Bags with a status of PASS
	And I save the equipment and supply
	And I open the bleed screen
	Then I add bleed equipment
	And I add bleed supplies
	And I enter bleed information outside drive times
	Then donation is set to complete in Onsite Status Query

