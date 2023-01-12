Feature: Certifications

I want to be able to add my certification to the profile

@tag1
Scenario Outline: 1 I want to add certification to the profile
	Given I logged into localhost successfully
	When I navigate to the certification tab
	And I add '<Certificate>', '<Certified From>', '<Year>'
	Then I am able to see the '<Certificate>' added certification
Examples: 
|        Certificate       | Certified From | Year |
| SAP Fi      | Sap         | 2013 | 
| ISTQB | ANISTQB     | 2022   |

Scenario Outline:2 I want to edit me certification
Given I logged into localhost successfully
When I navigate to the certification tab 
And I edit the existing certification '<Certificate>', '<Certified From>'
Then I am able to see updated '<Certificate>' Certification
Examples: 
| Certificate|Certified From |
| Ballet Dancer | IBDA|

Scenario Outline: 3 I want to delete a qualification from my profile
Given I logged into localhost successfully
When I navigate to the certification tab
And I delete the existing certification '<Certificate>'
Then I am not able to see the deleted '<Certificate>' certification
Examples: 
| Certificate|
| Ballet Dancer |