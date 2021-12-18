Feature: Education
        In oder to add,update and delete profile details 
		As seller of this website
		I want to add,update and delete profile details
	

@mytag
 Scenario Outline: Adding details to education
    Given I am on Home page
	When I select <Education>                                                
	And I click On Add New button 
    And I expect that the fields <UniversityName>, <Country>, <Title>, <Degree>, <Year> displays on the page
	And I click On Add button
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	| UniversityName | Country | Title | Degree | Year | Message                   |
	| RMIT           | Canada  | B.A   | abc    | 2021 | Education has been added  |                                     
	
	
Scenario Outline: Updating profile education details
    Given I am on Home page
	When I select <Education>                                                   
	And I click On Add New button 
    And I expect that the fields <UniversityName>, <Country>, <Title>, <Degree>, <Year> displays on the page
	And I click On Update button
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	| UniversityName | Country | Title | Degree | Year |  Message                    |
	| CMRIT          | India   | M.A   | abc    | 2020 |  Education has been updated |


Scenario Outline: Deleting profile education details
	Given I am on Home page
	When I select <Education>                                              
	And I click on delete icon
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	 | Message                              |
	 | Education entry successfully removed |