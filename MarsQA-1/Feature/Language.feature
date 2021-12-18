Feature: Language
        In oder to add,update and delete profile details 
		As seller of this website
		I want to add,update and delete profile details

@mytag
 Scenario Outline: Adding details to Language
    Given I am on Home page
	When I select <Language>                                                
	And I click On Add New button 
        And I expect that the fields <Language>, <Level> displays on the page
	And I click On Add button
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	| language  | Level  |  Message                                        |
	| English   | Basic  |English language has been added to your languages|
	
	
Scenario Outline: Updating profile Language details
    Given I am on Home page
	When I select <Certification>                                                   
	And I click On Edit button 
        And I expect that the fields <Language>, <Level> displays on the page
	And I click On Update button
	Then I expect the <Message> should be displyed on the screen


	Examples:  
	| language  | Level  |  Message                                                       |
	| abc       | Fluent |  abc language has been added to your languages                 |
	| abc       | Fluent | 	This langauge is already added your langauge list             |           


Scenario Outline: Deleting profile Language details
	Given I am on Home page
	When I select <Language>                                              
	And I click on delete icon
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	 | Message                                  |
	 | abc has been deleted from your languages |
