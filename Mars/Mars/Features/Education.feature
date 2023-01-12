Feature: Education

I want to be able to add, edit and delete education qualification

@tag1
Scenario Outline: 1 I want to add Education qualification to the profile
	Given I logged into localhost successfully
	When I navigate to the education tab
	And I add '<CollegeName>', '<CountryofCollege>','<Title>','<Degree>','<YearofGraduation>' 
	Then I am able to see the '<CollegeName>' education qualification
Examples: 
| CollegeName              | CountryofCollege | Title | Degree          | YearofGraduation |
| St. Mary University      | Canada           | BArch | Graduation      | 2000             |
| University of Canterbury | New Zealand      | PHD   | Post Graduation | 2013             |

Scenario Outline:2 I want to edit me education qualification
Given I logged into localhost successfully
When I navigate to the education tab
And I edit the existing education qualification '<College Name>', '<Country of College>'
Then I am able to see updated '<College Name>' education qualification
Examples: 
| College Name            | Country of College |
| Harvard Business School | United States      |

Scenario Outline: 3 I want to delete a qualification from my profile
Given I logged into localhost successfully
When I navigate to the education tab
And I delete the existing education qualification '<College Name>'
Then I am not able to see the deleted '<College Name>' education qualification anymore
Examples: 
| College Name            |
| Harvard Business School |


