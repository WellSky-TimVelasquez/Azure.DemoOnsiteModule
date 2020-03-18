Feature: Health History
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive

@mytag
Scenario: OpenHealthHistory 
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History

@test
Scenario: CompleteHealthHistoryScreenAL
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then the donor is in the Onsite Status Query with HH

@test
Scenario: CompleteHealthHistoryScreenAU
	Given I register a new donor with AU WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AU Health History questions with no exceptions
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete
	Then the donor is in the Onsite Status Query with HH


@smoketest @test
Scenario: OverrideHealthHistoryScreenAL
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with an latex exception
	And I complete the Health History Summary page
	And I signoff on the Health History page
	And override the donor in Health History
	Then the Health History statistics block is updated with override

@test
Scenario: DeferHealthHistoryScreenAL
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with an latex exception
	And I complete the Health History Summary page
	And I signoff on the Health History page
	And defer the donor
	Then the Health History statistics block is updated with deferral

@test
Scenario: DeferGroupHealthHistoryScreenAL
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with an healthy exception
	And I complete the Health History Summary page
	And I signoff on the Health History page
	And defer the donor
	Then the Health History statistics block is updated with temporary deferral

@test
Scenario: UpdateAnswerfromDonorResponseinHealthHistory
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Donor Response
	And I can complete Donor Response with an exception
	Then the Donor Response statistics block is updated as complete
	Then I can open Health History
	And I update Health History questions with no latex exception
	And I complete the Health History Summary page with changed status
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete

@test
Scenario: CompleteHealthHistoryScreenALinSpanish
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions in Spanish
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete

@systemtest
Scenario Outline: DeferHealthHistoryScreenALwithdata
	Given I register a new donor with AL WB and <firstname> <lastname> <dob> <gender>
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with an latex exception
	And I complete the Health History Summary page
	And I signoff on the Health History page
	And defer the donor
	Then the Health History statistics block is updated with deferral
Examples:
| firstname | lastname | dob      | gender |deferralid |
| TIM | ROLSTON | 12011980 | M |  19111202  |

Scenario: CompleteHealthHistoryScreenALinGerman
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions in German
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete

Scenario: CompleteHealthHistoryScreenALinFrench
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with no exceptions in French
	And I complete the Health History Summary page
	And I signoff on the Health History page
	Then the Health History statistics block is updated as complete

@test
Scenario: Defer4way4HealthHistoryScreenAL
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Health History
	And I complete AL Health History questions with an fourwayfour exception
	And I complete the Health History Summary page
	And I signoff on the Health History page
	And defer the donor
	Then the Health History statistics block is updated with temporary deferral

