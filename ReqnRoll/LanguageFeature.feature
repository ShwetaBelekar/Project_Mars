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