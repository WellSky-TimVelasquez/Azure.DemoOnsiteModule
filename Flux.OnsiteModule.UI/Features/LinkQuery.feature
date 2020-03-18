Feature: Link Query
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive

@mytag
Scenario: LinkQueryDisplayActiveDrive
	Given I open the Link Query screen
	Then the activated drive is displayed

Scenario: LinkQueryUpdateDrive
	Given I open the Link Query screen
	Then the activated drive is displayed
	And I update the Drive Id
	Then the updated Drive Id is displayed



