Feature: SigninFeature
As a registered user I want to login to the portal with valid credentials 
and add, edit and delete records in the language and skill module
so that i can show my language and skill proficiency to the recruiters
A short summary of the feature

@tag1
Scenario: Check if user is able to Signin to the portal with valid data
	Given I get into the homepage
	When I enter valid credentials
	Then I should be able to Signin successfully
	
	
Scenario Outline: Check if user is unable to Signin to the portal with blank email and valid password
	Given I get into the homepage
	When I enter blank '<email>' and valid '<password>'
	Then I should see an error message for blank '<email>'

	Examples:
	| email | password |
	|       | Tonymoney@2025 |
	
	Scenario Outline: Check if user is unable to Signin to the portal with valid email and blank password
	Given I get into the homepage
	When I enter valid '<email>' and blank '<password>'
	Then I should see an error message for '<password>' 
	Examples:
	| email               | password |
	| moneytony@ymail.com |          |
				
