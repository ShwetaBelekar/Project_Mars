Feature: LanguageFeature
As a Project_Mars user
I would like to create, edit and delete Language records
So that I can manage Language successfully

A short summary of the feature

@regression
Scenario Outline: create language and level record with valid data
	Given I logged into Project Mars successfully for language management
	When I navigate to Language
	When I create multiple '<Language>' and '<Level>' in language record
	Then the multiple '<language>' and '<Level>' record should be created successfully
	Examples: 
| Language | Level  |
| German   | Fluent |
| Java     | Basic  |
| C#       | Basic  |
| EnGlish  | Fluent |


Scenario Outline: edit existing language record with valid data
Given I logged into Project Mars successfully for language management
When I navigate to Language
When I update the '<Language>' and '<Level>' on an existing language record
Then the record should have the updated '<Language>' and '<Level>'

Examples: 
| Language | Level  |
| German   | Fluent |
| Java     | Basic  |
| C#       | Basic  |
| French   | Fluent |

Scenario:remove existing language record with valid data
Given I logged into Project Mars successfully for language management
When I navigate to Language
When I remove the existing language record
Then the record should not be present on the language list