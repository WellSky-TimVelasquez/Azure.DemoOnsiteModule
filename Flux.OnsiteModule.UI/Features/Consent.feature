Feature: Consent
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive

@test
Scenario: ManualConsent
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Consent
	And I manually sign consent one and two
	Then the Consent statistics block is updated as complete
@test
Scenario: DeclineOneConsent
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Consent
	And I manually sign consent one 
	Then I decline consent two
	Then the Consent statistics block status is declined
@test
Scenario: DeclineTwoConsents
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Consent
	And I decline consent one
	Then I decline consent two
	Then the Consent statistics block status is declined
@systemtest
Scenario Outline: DeclineOneConsentwithdata
	Given I register a new donor with AL WB and <firstname> <lastname> <dob> <gender>
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Consent
	And I manually sign consent one 
	Then I decline consent two
	Then the Consent statistics block status is declined
Examples:
| firstname | lastname | dob      | gender |
| AMANDA | JONAS | 08101980 | F |


