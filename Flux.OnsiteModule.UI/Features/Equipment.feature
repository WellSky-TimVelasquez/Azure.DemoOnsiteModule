Feature: Equipment
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive

@test
Scenario: AddBPEquipment
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I enter BP with a status of PASS

Scenario: AddAmicEquipment
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I enter AMIC with a status of PASS

Scenario: AddScaleEquipment
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I enter SCALE with a status of PASS

Scenario: AddHcueEquipment
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I enter HCUE with a status of PASS

Scenario: AddAlyxEquipment
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I enter Alyx with a status of PASS

Scenario: AddTherEquipment
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I enter Ther with a status of PASS

Scenario: AddTrimEquipment
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I enter Trim with a status of PASS

Scenario: AddVistEquipment
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I enter Vist with a status of PASS

Scenario: AddCbSupply
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I open the Supply screen
	And I enter CB with a status of PASS

Scenario: AddLanceSupply
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I open the Supply screen
	And I enter Lance with a status of PASS

Scenario: AddBagSupply
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I open the Supply screen
	And I enter Bags with a status of PASS

Scenario: AddChlopSupply
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I open the Supply screen
	And I enter Chlop with a status of PASS

Scenario: AddBPPKitSupply
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I open the Supply screen
	And I enter PPKit with a status of PASS

Scenario: AddTumsSupply
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I open the Supply screen
	And I enter Tums with a status of PASS

Scenario: AddWbkitSupply
	Given I open the Equipment screen
	And I select a Drive Profile of WBPP
	And I open the Supply screen
	And I enter Wb Kit with a status of PASS