Feature: HealthHistoryParentForm
	
Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive

@mytag
Scenario: SelectDonor 1.01
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	Then the donor information is displayed

Scenario: DonorHeader 2.02
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then the donor information is displayed in the donor header

Scenario: DonorComment 2.03
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	And I add a comment
	Then the comment is saved

Scenario: ConsentPFHH
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Consent
	And I manually sign consent one and two
	Then the Consent statistics block is updated as complete
	Then I can open Physical Findings
	And Valid Physical Findings entry is made
	And Physical Findings is completed
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then the donor is in the Onsite Status Query with HHPFConsent


Scenario: PFConsentHH
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings
	And Valid Physical Findings entry is made
	And Physical Findings is completed
	Then I can open Consent
	And I manually sign consent one and two
	Then the Consent statistics block is updated as complete
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then the donor is in the Onsite Status Query with HHPFConsent


Scenario: HHPFConsent
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
	Then the Consent statistics block is updated as complete
	Then the donor is in the Onsite Status Query with HHPFConsent


Scenario: LinktoHHfromRegistration
	Given I register a new donor with AL WB and don't close registration
	And I press the HH button on registration
	Then Health History Parent form is displayed

Scenario Outline: HealthHistorySupervisorOverride
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then I can open Health History in supervisor override
	Then I update Health History for the donor
	And I complete the Health History Summary page
	And I signoff on the Health History page	
	And defer the donor with <deferralid>
	Then the Health History statistics block is updated with deferral
Examples:
| deferralid |
| 19102104  |


Scenario: PhysicalFindingsSupervisorOverride
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings
	And Valid Physical Findings entry is made
	And Physical Findings is completed
	Then the statistics block is updated as complete
	Then I can open Physical Findings in supervisor override
	Then I update Physical Findings for the donor
	Then the statistics block is updated as complete



