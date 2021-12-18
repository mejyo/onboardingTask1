Feature: Certification
        In oder to add,update and delete profile details 
		As seller of this website
		I want to add,update and delete profile details

@mytag
 Scenario Outline: Adding details to Certification
    Given I am on Home page
	When I select <Certification>                                                
	And I click On Add New button 
    And I expect that the fields <Certification>, <From>, <Year> displays on the page
	And I click On Add button
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	| Certification  | From | Year   |  Message                       |
	| abcd           | abcd  | 2020 | Certification has been updated  |
	
	
Scenario Outline: Updating profile Certification details
    Given I am on Home page
	When I select <Certification>                                                   
	And I click On Edit button 
        And I expect that the fields <Certification>, <From>, <Year> displays on the page
	And I click On Update button
	Then I expect the <Message> should be displyed on the screen


	Examples:  
	| Certification | From | Year   |  Message                              |
	| Best Employee | abc  | 2020   |  Certification has been updated       |
	| Best Employee | abc  | 2020   |  The information is already exist     |


Scenario Outline: Deleting profile Certification details
	Given I am on Home page
	When I select <Certification>                                              
	And I click on delete icon
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	 | Message                              |
	 | Certification entry successfully removed |