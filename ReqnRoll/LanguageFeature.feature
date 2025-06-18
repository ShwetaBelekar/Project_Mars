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
	| Language | Level            |
	| German   | Native/Bilingual |
	| Java     | Basic            |
	| C#       | Fluent           |
	| EnGlish  | Conversational   |

	Scenario Outline: Update valid language and level record
	Given I login to Project Mars
	When I navigate to language
	When I update '<OldLanguage>' and '<OldLevel>' with new '<NewLanguage >' and '<NewLevel>'
	Then the '<NewLanguage>' and '<NewLevel>' should be updated successfully
	Examples:
	| OldLanguage | OldLevel         | NewLanguage | NewLevel            |
	| German      | Native/Bilingual | Spanish     | Fluent              |
	| Java        | Basic            | Python      | Conversational      |
	| C#          | Fluent           | Ruby        | Native/Bilingual    |
	| English     | Conversational   | French      | Basic               |
	
	Scenario Outline: Edit existing language and level record
	Given I login to Project Mars
	When I navigate to language
	When I edit existing '<Language>' and '<Level>' record
	Then the record for '<Language>' and '<Level>' should be updated successfully
	Examples:
	| Language | Level            |
	| Spanish  | Conversational   |  
	| Python   | Basic            |
	| Marathi  | Native/Bilingual |
	| Hindi    | Fluent           |

	Scenario: remove existing language and level record
	Given I login to Project Mars 
	When  I navigate to language
	When I remove the existing language and level record
	Then the record should not be present
	

	Scenario Outline: Create blank language and valid level record
	Given I login to Project Mars
	When I navigate to language
	When I create blank '<Language>' and valid '<Level>' record
	Then I should see error message for blank '<Language>' name
	Examples: 
	| Language | Level  |
	|          | Fluent |

	Scenario Outline: Create valid language and blank level record
	Given I login to Project Mars
	When I navigate to language
	When I create valid '<Language>' and blank '<Level>' record
	Then I should see error message for blank '<Level>'
	Examples: 
	| Language | Level |
	| French   |       |
	
	Scenario Outline: Create language record with invalid data
	Given I login to Project Mars
	When I navigate to language
	When I create language record with invalid '<Language>' and '<Level>'
	Then the language record with invalid '<Language>' should not be created
	Examples: 
	| Language | Level  |
	| 123@abc  | Fluent |

	Scenario Outline: Create Duplicate language and level record
	Given I login to Project Mars
	When I navigate to language
	When I create a duplicate '<Language>' and '<Level>' record
	Then I should see error message for duplicate '<Language>'
	Examples:
	| Language | Level |
	| English  | Basic |
	| English  | Basic |

	
	