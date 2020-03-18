Feature: RegisterDonor
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I login the application as a Blood Centers User
	And I open Active Drive screen
	And I activate a drive

@test
Scenario: RegisterNewALWBDonor
	Given I register a new donor with AL WB
	Then Donor is registered
	Then the donor is in the Onsite Status Query

@test
Scenario: RegisterNewALPPDonor
	Given I register a new donor with AL PP
	Then Donor is registered

@test
Scenario: RegisterNewAUWBDonor
	Given I register a new donor with AU WB
	Then Donor is registered

@test
Scenario: RegisterNewDIWBDonor
	Given I register a new donor with DI WB
	Then Donor is registered

@test
	Scenario: RegisterNewMobilePrefDonor
	Given I register a new donor with Mobile Preferred phone number
	Then Donor is registered with preferred phone number

@test
Scenario: RegisterDonorOverAgeLimit
	And Over error message is displayed
	Then the donor can be registered
	Then Donor is registered

@test
Scenario: RegisterDonorUnderAgeLimit
	Given I register a new donor Under Age Limit
	And Under error message is displayed
	Then the donor can be registered
	Then Donor is registered


@systemtest
Scenario Outline: RegisterExistingDonor
	Given I have entered <donorid> in find donor
	And I register an existing <ssn> <lastname> <firstname> <dob> <gender> and <donorid> with AL WB
	Then Donor is registered
Examples:
| ssn       | lastname      | firstname   | dob      | gender | donorid    |
| 111111111 | PAST		|	LANCE	      |	02141980 |	M     |	DN30120063 |

@systemtest
Scenario Outline: RegisterExistingDonorCheck
	Given I have entered <donorid> in find donor
	And I register an existing <ssn> <lastname> <firstname> <dob> <gender> and <donorid> with AL WB
	Then Donor is registered with <address> <city> <state> <zipcode> <abo> <cmv> and <gallon> information
Examples:
| ssn       | lastname | firstname | dob      | gender | donorid    | address				 | city   | state | zipcode | abo	  | cmv	   | gallon |
| 111111111 | PAST    | LANCE    | 02141980 | M      | DN30122256 | 200_WESTERN_AVE	 | CHICAGO | IL    | 60606   | A_Pos  | CMV-   | 1      |

@test
Scenario: DeferatInquiry
	Given I register a new donor with AL WB
	And enter donor inquiry 
	And defer the donor
	Then the donor is displayed in Link Query

@test
Scenario: OverrideatInquiry
	Given I register a new donor with AL WB
	And enter donor inquiry 
	And override the donor
	Then the donor is displayed in Online Status Query

@systemtest
Scenario Outline: ExistingTempDeferredDonorEligibility
	Given I have entered <donorid> in find donor
	And I enter an existing <ssn> <lastname> <firstname> <dob> <gender> and <donorid> with AL WB
	Then the eligibility is temporarily deferred
Examples:
| ssn       | lastname      | firstname   | dob      | gender | donorid    |
| 111111111 | GRAY			|	BILL      |	05141999 |	M     |	DN30122738 |

@systemtest
Scenario Outline: ExistingPermDeferredDonorEligibility
	Given I have entered <donorid> in find donor
	And I enter an existing <ssn> <lastname> <firstname> <dob> <gender> and <donorid> with AL WB
	Then the eligibility is permanently deferred
Examples:
| ssn       | lastname      | firstname   | dob      | gender | donorid    |
| 111111111 | CHANG			|	RYAN      |	02021998 |	M     |	DN30122737 |

@test
Scenario: UpdateALWBDonor
	Given I register a new donor with AL WB
	Then Donor is registered
	And I update the registration information
	Then Donor is registered
	Then Donor information is udpated

@systemtest
Scenario Outline: RegisterNewALWBDonorwithdonorinformation
	Given I register a new donor with AL WB and <firstname> <lastname> <dob> <gender>
	Then Donor is registered
Examples:
| firstname | lastname | dob      | gender |
| SARAH     | JONES    | 05141990 | F      |
| OWEN      | HINES    | 06201997 | M      |

@systemtest
Scenario Outline: RegisterNewALPPDonorwithdonorinformation
	Given I register a new donor with AL PP and <firstname> <lastname> <dob> <gender>
	Then Donor is registered
Examples:
| firstname | lastname | dob      | gender |
| SARAH     | JONES    | 05141990 | F      |
| OWEN      | HINES    | 06201997 | M      |

@systemtest
Scenario Outline: OverrideatInquiryDIWBwithdonor
	Given I register a new donor with DI WB and <firstname> <lastname> <dob> <gender>
	And enter donor inquiry with oxygen therapy
	And override the donor 
	Then the donor is displayed in Online Status Query
Examples:
| firstname | lastname | dob      | gender |
| JAMES     | PIKE    | 05101990 | M      |

@systemtest
Scenario Outline: RegisterNewDIWBDonorwithdonorinformation
	Given I register a new donor with DI WB and <firstname> <lastname> <dob> <gender>
	Then Donor is registered
Examples:
| firstname | lastname | dob      | gender |
| SARAH     | JONES    | 05141990 | F      |
| OWEN      | HINES    | 06201997 | M      |

@systemtest
Scenario Outline: DeferatInquirywithdonor
	Given I register a new donor with AL WB and <firstname> <lastname> <dob> <gender>
	And enter donor inquiry 
	And defer the donor
	Then the donor is displayed in Link Query
Examples:
| firstname | lastname | dob      | gender | deferralid |
| RACHEL | EVANS | 10181990 | F |19111201   |

@systemtest
Scenario Outline: RegisterNewALPPAMICDonorwithdonorinformation
	Given I register a new donor with AL PP AMIC and <firstname> <lastname> <dob> <gender>
	Then Donor is registered
Examples:
| firstname | lastname | dob      | gender |
| SARAH     | JONES    | 05141990 | F      |

@systemtest
Scenario Outline: RegisterExistingDonorALPP
	Given I have entered <donorid> in find donor
	And I register an existing <ssn> <lastname> <firstname> <dob> <gender> and <donorid> with AL PP
	Then Donor is registered
Examples:
| ssn       | lastname      | firstname   | dob      | gender | donorid    |
| 111111111 | PAST		|	LANCE	      |	02141980 |	M     |	DN30120063 |

@systemtest
Scenario Outline: RegisterExistingDonorAUPP
	Given I have entered <donorid> in find donor
	And I register an existing <ssn> <lastname> <firstname> <dob> <gender> and <donorid> with AU PP
	Then Donor is registered
Examples:
| ssn       | lastname      | firstname   | dob      | gender | donorid    |
| 111111111 | PAST		|	LANCE	      |	02141980 |	M     |	DN30120063 |

Scenario Outline: RegisterNewDIDRDonorwithdonorinformation
	Given I register a new donor with DI DR and <firstname> <lastname> <dob> <gender>
	Then Donor is registered
Examples:
| firstname | lastname | dob      | gender |
| EMILY     | LEE    | 08101960| F      |
| SOPHIA      | KIM    | 08101961 | F      |
| AMELIA     | MORROW    | 08101962| F      |
| HARPER      | MISTRY    | 08101963 | F      |
| EVELYN     | PARKER    | 08101964| F      |
| ABIGAIL      | RAMSEY    | 08101965 | F      |
| EMILY     | RIVERA    | 08101966| F      |
| LIZ      | ROBERTSON    | 08101967 | F      |
| MILA     | ROGERS    | 08101968| F      |
| ELLA      | RANGEL    | 08101969 | F      |
| AVERY     | MULLARKEY    | 08101970| F      |
| SOFIA      | THALLER    | 08101971 | F      |
| CAMILA     | VARGAS    | 08101972| F      |
| ARIA      | VIERA    | 08101973 | F      |
| MADISON     | WONG    | 08101974| F      |
| VICTORIA      | WILSON    | 08101975 | F      |
| LUNA     | ASHBY    | 08101976| F      |
| GRACE      | BERKSTEIN    | 08101977 | F      |
| CHLOE     | BRANTON    | 08101978| F      |
| LAYLA      | TAN    | 08101979 | F      |
| RILEY     | SUH    | 08101980| F      |
| ZOEY      | SOLON    | 08101981 | F      |
| PENELOPE     | SHEA    | 08101982| F      |
| LEAH      | SREY    | 08101983 | F      |
| HAZEL     | WATKINS    | 08101984| F      |
| VIOLET      | HOWEY    | 08101985 | F      |
| NATALIE     | HILL    | 08101986| F      |
| STELLA      | GARCIA    | 08101987 | F      |
| ELLIE     | KUMAR    | 08101988| F      |
| AUBREY      | MARLETT    | 08101989 | F      |
| ADDISON     | DIAZ    | 08101990| F      |
