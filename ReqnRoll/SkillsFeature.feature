@skill
Feature: Skill
As a Project_Mars user
I would like to create, edit and delete Skill records
So that I can manage Skill successfully

A short summary of the feature

@regression
Scenario Outline: create skill record with valid data
	Given I logged into Project Mars successfully for Skill management
	When  I navigate to Skill
	When  I create a '<Skill>' with '<Level>' record
	Then  the record for '<Skill>' with '<Level>' should be created successfully 
	Examples: 
	| Skill           | Level        |
	| Problem Solving | Expert       |
	| Quick Learner   | Expert       |
	| Makeup          | Beginner     |
	| Dancing         | Intermediate |

	Scenario Outline: edit existing skill record with valid data
	Given I logged into Project Mars successfully for Skill management
	When  I navigate to Skill
	When i see existing '<Skill>' and '<Level>' records
	When I update the existing skill and level with new '<NewSkill>' and '<NewLevel>' 
	Then the should the '<NewSkill>' and '<NewLevel>' record 
	Examples: 
	| Skill    | Level        | NewSkill  | NewLevel |
	| Singing  | Expert       | Sketching | Beginner |
	| Painting | Intermediate | Running   | Expert   |

	Scenario Outline: remove existing skill record 
	Given I logged into Project Mars successfully for Skill management
	When  I navigate to Skill
	When i see '<Skill>' and '<Level>' 
	When I deleted the existing skill record 
	Then i should see a message that record deleted successfully
	Examples: 
	| Skill    | Level    |
	| Drawing  | Expert   |
	

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

	Scenario Outline: Check if you can create duplicate record
	Given I logged into Project Mars successfully for Skill management
	When  I navigate to Skill
	When I create '<Skill>' and '<Level>' record successfully
	When I create '<DuplicateSkill>' and '<DuplicateLevel>' record
	Then i should see error message for duplicate skill
	Examples: 
	| Skill          | Level  | DuplicateSkill | DuplicateLevel |
	| ProblemSolving | Expert | ProblemSolving | Expert         |