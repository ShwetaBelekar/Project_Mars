@skill
Feature: Skill
As a Project_Mars user
I would like to create, edit and delete Skill records
So that I can manage Skill successfully

A short summary of the feature

@regression
Scenario: create skill record with valid data
	Given I logged into Project Mars successfully for Skill management
	When  I navigate to Skill
	When  I create a Skill record
	Then  the record should be created successfully for Skill

	Scenario: edit existing skill record with valid data
	Given I logged into Project Mars successfully for Skill management
	When  I navigate to Skill
	When I update the level on an existing skill record
	Then the  skill record should have the updated level

	Scenario: remove existing skill record 
	Given I logged into Project Mars successfully for Skill management
	When  I navigate to Skill
	When I deleted the existing skill record 
	Then i should see a message that record deleted successfully

	Scenario Outline: Create blank skill and valid level record
	Given I logged into Project Mars successfully for Skill management
	When I navigate to Skill
	When I create blank '<skill>' and valid '<level>' 
	Then I should see error message for the blank '<skill>' record 
	Examples: 
	| skill | level  |
	|       |Expert |

	Scenario Outline: Create valid skill and blank level record
	Given I logged into Project Mars successfully for Skill management
	When I navigate to Skill
	When I create valid '<skill>' and blank '<level>' 
	Then I should see error message for the blank '<level>' 
	Examples: 
	| skill | level |
	| Drawing|       |
	
	Scenario Outline: Create skill record with invalid data
	Given I logged into Project Mars successfully for Skill management
	When  I navigate to Skill
	When I create invalid '<skill>' and valid '<level>' record
	Then if the system accepts invalid '<skill>' and valid '<level>' record then there is error in the system
	Examples: 
	| skill                                                       | level        |
	| 123@abc                                                     | Expert       |
	| Englih                                                      | Intermediate |
	| 12345678                                                    | Beginner     |
	| aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa                            | Expert       |
	| xyz                                                         | Beginner     |
	| DRawIng                                                     | Expert       |
	| SKETching                                                   | Beginner     |
	| DrawingPaintingColouringCraftingBakingCookingDancingSinging | Expert       |