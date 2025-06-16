Feature: LanguageFeature
As a Project_Mars user
I would like to create, edit and delete Skill records
So that I can manage Skill successfully

A short summary of the feature

@tag1
Scenario Outline: Create valid language and level record
	Given I login to Project Mars
	When I navigate to language
	When I create valid '<Language>' and valid '<Level>' record
	Then the record for valid '<Language>' and '<Level>' should be created successfully
	Examples:
	| Language | Level  |
	| German   | Fluent |
	| Java     | Basic  |
	| C#       | Basic  |
	| EnGlish  | Fluent |

	Scenario Outline: Create blank language and valid level record
	Given I login to Project Mars
	When I navigate to language
	When I create blank '<Language>' and valid '<Level>' record
	Then I should see error message for blank '<Language>' name
	Examples: 
	| Language | Level  |
	|          | Fluent |


	Scenario Outline: Edit existing language and level record
	Given I login to Project Mars
	When I navigate to language
	When I edit existing '<Language>' and '<Level>' record
	Then the record for '<Language>' and '<Level>' should be updated successfully
	Examples:
	| Language | Level            |
	| Spanish  | Fluent           |
	| Python   | Basic            |
	| Marathi  | Native/Bilingual |
	| Hindi    | Fluent           |