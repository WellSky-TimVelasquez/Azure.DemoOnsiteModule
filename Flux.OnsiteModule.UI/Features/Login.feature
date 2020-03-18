Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Valid Login
	Given I login the application
	And I open application home page

Scenario: Invalid Login
	Given An invalid user logs into the application
	And I get invalid login message

Scenario: Null Login
	Given A null user logs into the application
	And I get null login message

Scenario: Null Password
	Given A user with null password logs into the application
	And I get null login message