Feature: DebugFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Debug
	Given I login the application as a Blood Centers User
	And TESTscript
	And I open Active Drive screen
	And I activate a drive



Scenario: DebugComment
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive
	And I navigate to the Health History/Physical screen
	And I select the donor in Health History/Physical screen
	Then I can open Consent
	And I manually sign consent one and two
	Then the Consent statistics block is updated as complete

Scenario Outline: Debugquery
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive
	And I register an existing <ssn> <lastname> <firstname> <dob> <gender> and <donorid> with AL WB
	Then Donor is registered with <address> <city> <state> <zipcode> <abo> <cmv> and <gallon> information
Examples:
| ssn       | lastname | firstname | dob      | gender | donorid    | address				 | city   | state | zipcode | abo	  | cmv	   | gallon |
| 111111111 | HIBBS    | JAYCE    | 12011991 | M      | DN30122253 | 29_LONG_TIME	 | DALLAS | TX    | 75235   | AB_Pos  | CMV-   | 0      |

