Feature: Skill

I want to be able to add, edit and delete skills

@tag1
Scenario Outline:1 Add skills to the profile
	Given I logged into localhost successfully 
	When I navigate to the skills tab
	And I add new '<Skills>' and '<Level>' to the profile
	Then I am able to see my skills '<Skills>' 
	Examples: 
	| Skills     | Level        |
	| Ballet     | Expert       |
	| Cooking    | Intermediate |
	| Acrobatics | Expert       |
	| Painting   | Intermediate |

Scenario Outline:2 Edit existing skills
When I navigate to the skills tab
And I edit the existing skills '<Skills>', '<Level>'
Then I am able to see the edited skills '<Skills>'
Examples: 
| Skills | Level |
| Tango  | Expert |

Scenario Outline:3 Delete existing skills
When I navigate to the skills tab
And I delete a skill '<Skill>'
Then I am not able to see the skill in my profile '<skill>'
Examples: 
| Skill |
| Tango |


