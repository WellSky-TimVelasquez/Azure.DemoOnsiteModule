Feature: Drives
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive

@mytag
Scenario: ActivateDrive
	Given I enter a drive date
	And I select an available drive
	When I press Select Drive
	And I confirm the drive
	Then the drive is activated

Scenario: CompleteDrive
	Given I select an available drive
	When I press Complete Drive
	Then the drive is completed



