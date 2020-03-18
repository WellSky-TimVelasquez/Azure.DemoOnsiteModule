Feature: Walkout
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive

@test
Scenario: WalkoutDonor
	Given I register a new donor with AL WB
	And I navigate to the Walkout screen
	And I select the donor in Walkout screen
	And I walkout the donor
	Then the donor status is Walk in Onsite Status Query

@test
Scenario: HoldDonor	
	Given I register a new donor with AL WB
	And I navigate to the Walkout screen
	And I select the donor in Walkout screen
	And I put the donor on hold
	Then the donor status is Hold in Onsite Status Query

@test
Scenario: ReturnWalkoutDonor
	Given I register a new donor with AL WB
	And I navigate to the Walkout screen
	And I select the donor in Walkout screen
	And I walkout the donor
	Then the donor status is Walk in Onsite Status Query
	And I return the donor to Registration
	Then Donor is registered

@test
Scenario: ReturnHoldDonorafterHHPF
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
	Given I navigate to the Walkout screen
	And I select the donor in Walkout screen
	And I put the donor on hold
	Then the donor status is Hold in Onsite Status Query
	And I return the donor to Registration after hold
	Then Donor is registered
	Given I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then the HH and PF status is updated
	Then I can open Health History
	And I complete AL Health History questions with no exceptions after hold
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then I can open Physical Findings
	And Physical Findings is completed after Hold
	Then the donor is in the Onsite Status Query with HH





