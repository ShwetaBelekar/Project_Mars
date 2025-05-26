Feature: LanguageFeature
As a Project_Mars user
I would like to create, edit and delete Language records
So that I can manage Language successfully

A short summary of the feature

@regression
Scenario: create language record with valid data
	Given I logged into Project Mars successfully
	When I navigate to Language
	When I create a language record
	Then the record should be created successfully
