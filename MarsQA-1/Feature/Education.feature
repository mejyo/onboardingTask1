Feature: Education
        In oder to add,update and delete profile details 
		As seller of this website
		I want to add,update and delete profile details
	

@mytag
 Scenario Outline: 1Adding details to education
    Given I am on Home page
	When I select <Education>                                    
	And I click On Add New button
	And  I entered all given values <UniversityName>, <Country>, <Title>, <Degree>, <Year>
	And I click On Add button
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	| Education | UniversityName | Country | Title | Degree | Year | Message                   |
	| Education | RMIT           | Canada  | B.A   | abc    | 2021 | Education has been added  |                                     
	
	
Scenario Outline: 2Updating profile education details
    Given I am on Home page
	When I select <Education>                               
	And I click On Edit Icon 
    And I updated all given values <UniversityName>, <Country>, <Title>, <Degree>, <Year>
	And I click On Update button
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	| Education | UniversityName | Country | Title | Degree | Year | Message                    |
	| Education | CMRIT           | India  | M.A   | abc    | 2020 | Education as been updated  |


Scenario Outline: 3Deleting profile education details
	Given I am on Home page
	When I select <Education>                         
	And I click on Delete icon
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	 | Education | Message								|
	 | Education | Education entry successfully removed |