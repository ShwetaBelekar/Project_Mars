Feature: SkillsFeature
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

	Scenario: remove existing skill record with valid data
	Given I logged into Project Mars successfully for Skill management
	When  I navigate to Skill
	When I remove the existing skill record
	Then the record should not be present on the skill list

	Scenario Outline: Create Skill record
	Given I logged into Project Mars successfully for Skill management
	When  I navigate to Skill
	When I create '<skill>' and '<level>' record
	Then the record for '<skill>' and '<level>' should be created successfully
	Examples: 
	| skill    | level        |
	| Drawing  | Beginner     |
	| Painting | Expert       |
	| Dance    | Intermediate |  

