Feature: Donor Response
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive


Scenario: DonorResponse 
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Donor Response

@test
Scenario: CompleteDonorResponse 
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Donor Response
	And I can complete Donor Response with expected answers
	Then the Donor Response statistics block is updated as complete

@test
Scenario: CompleteDonorResponseinSpanish
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Donor Response
	And I can complete Donor Response with expected answers in Spanish
	Then the Donor Response statistics block is updated as complete

@test
Scenario: DonorResponsewithupdatedanswer
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Donor Response
	And I can complete Donor Response with an updated answer
	Then the Donor Response statistics block is updated as complete
	Then I can open Health History
	And I complete updated Health History questions with no exceptions
	And I complete the Health History Summary page with Change
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then the donor is in the Onsite Status Query with HH

@test
Scenario: DonorResponsewithskippedanswer
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Donor Response
	And I can complete Donor Response with a skipped answer
	Then the Donor Response statistics block is updated as complete
	Then I can open Health History
	And I complete Health History questions for skipped answer
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then the donor is in the Onsite Status Query with HH

@test
Scenario: CompleteDonorResponseinGerman
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Donor Response
	And I can complete Donor Response with expected answers in German
	Then the Donor Response statistics block is updated as complete

Scenario: CompleteDonorResponseinFrench
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Donor Response
	And I can complete Donor Response with expected answers in French
	Then the Donor Response statistics block is updated as complete
