Feature: Physical Findings
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive


Scenario: PhysicalFindings 
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings

@test
Scenario: CompletePhysicalFindingsALWB
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings
	And Valid Physical Findings entry is made
	And Physical Findings is completed
	Then the statistics block is updated as complete

@test
Scenario: CompletePhysicalFindingsALPP
	Given I register a new donor with AL PP
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings
	And Valid AL PP Physical Findings entry is made
	And Physical Findings is completed
	Then the statistics block is updated as complete

@test
Scenario: CompletePhysicalFindingsAUPP
	Given I register a new donor with AU PP
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings
	And Valid Physical Findings entry is made with AU PP
	And Physical Findings is completed
	Then the statistics block is updated as complete

@test
Scenario: PhysicalFindingsALWBwithInitialOutofRangeRepeatInRange
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings
	And Valid AL WB Physical Findings entry is made with initial value out of range and repeat in range
	And Physical Findings is completed
	Then the statistics block is updated as complete

@smoketest @test

Scenario: PhysicalFindingsALWBwithInitialOutofRangeRepeatOutofRangeDeferred
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings
	And Valid AL WB Physical Findings entry is made with initial value out of range and repeat out of range
	And defer the donor
	Then the statistics block is updated as Deferred
	Then the unit is linked
	Then the donor is deferred in the Onsite Status Query

@test
Scenario: PhysicalFindingsALWBwithOutofRangecomment
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings
	And Invalid AL WB Physical Findings with comment
	And defer the donor
	Then the statistics block is updated as Deferred

@test
Scenario: PhysicalFindingsALWBwithInitialOutofRangeOverride
	Given I register a new donor with AL WB
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings
	And Valid AL WB Physical Findings entry is made with initial value out of range and repeat out of range
	And override the donor 
	Then the Physical Findings statistics block is updated with override and hold

@systemtest
Scenario Outline: PhysicalFindingsALWBwithInitialOutofRangeRepeatOutofRangeDeferredwithdata
	Given I register a new donor with AL WB and <firstname> <lastname> <dob> <gender>
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings
	And Valid AL WB Physical Findings entry is made with initial value out of range and repeat out of range
	And defer the donor
	Then the statistics block is updated as Deferred
Examples:
| firstname | lastname | dob      | gender | deferralid |
|DUSTIN | BURKE | 11041996| M | 19111203   |

@test
Scenario: CompletePhysicalFindingsALWBwithequipmentandsupply
	Given I register a new donor with AL WB
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I enter BP Cuff with a status of PASS
	And I save the equipment and supply
	And I open the Supply screen
	And I enter Lance with a status of PASS
	And I save the equipment and supply
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Physical Findings
	Then I add equipment
	And I add supplies
	And Valid Physical Findings entry is made
	And Physical Findings is completed
	Then the statistics block is updated as complete
