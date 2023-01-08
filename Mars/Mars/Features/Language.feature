Feature: Language

I want to be able to add, edit and delete languages to the profile page

@tag1
Scenario Outline:1 Add languages to the profile page
	Given I logged into localhost successfully 
	When I navigate to languages tab
	And I add new '<Language>', '<Level>' to my profile
	Then I am able to see '<Language>' added to my profile
	Examples: 
	| Language | Level            |
	| English  | Fluent           |
	| Hindi    | Fluent           |
	| Kannada  | Native/Bilingual |
	| French   | Basic            |

	Scenario Outline:2 Edit existing languages
	When I navigate to languages tab
	And I edit the existing language '<Language>', '<Level>'
	Then I am able to see the edited language '<Language>'
	Examples: 
	| Language | Level            |
	| German   | Native/Bilingual |

	Scenario Outline:3 Delete existing language
	When I navigate to languages tab
	And I delete a language '<Language>'
	Then I am not able to see the language in profile '<Language>'
	Examples: 
	| Language |
	|  French  |
