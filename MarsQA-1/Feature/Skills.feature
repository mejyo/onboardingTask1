Feature: Skills
        In oder to add,update and delete profile details 
		As seller of this website
		I want to add,update and delete profile details

@mytag
 Scenario Outline: Adding details to Skills
    Given I am on Home page
	When I select <Skills>                                                
	And I click On Add New button 
    And I expect that the fields <Skills>, <Level> displays on the page
	And I click On Add button
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	| Skills    | Level    |  Message                                        |
	| abc       | Beginner | abc has been added to your skills               |
	| abc       | Beginner | This skill is already added your skill list     |
	|           | Beginner | Please enter skill and experience level         |
	| abc       |          | Please enter skill and experience level         |
	|           |          | Please enter skill and experience level         |
	
	
Scenario Outline: Updating profile Skills details
    Given I am on Home page
	When I select <Skills>                                                   
	And I click On Edit button 
    And I expect that the fields <Skills>, <Level> displays on the page
	And I click On Update button
	Then I expect the <Message> should be displyed on the screen


	Examples:  
	| Skills    | Level        |  Message                                     |
	| abcd      | Intermediate |  abcd has been updated to your skills        |
	| abcd      | Intermediate |  This skill is already added your skill list |    
	|           | Intermediate |  Please enter skill and experience level     |  
	| abcd      |              |  Please enter skill and experience level     | 
	|           |              |  Please enter skill and experience level     | 

Scenario Outline: Deleting profile Skills details
	Given I am on Home page
	When I select <Skills>                                              
	And I click on delete icon
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	 | Message               |
	 | abcs has been deleted |


