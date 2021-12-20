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
	| Certification  | From  | Year   |  Message                                                                   |
	| abc            | abcd  | 2020   | abc has been added to your certification                                    |
	| abc            | abcd  | 2020   | This information is already exist                                           |
	|                |       |        | Please enter Certification Name, Certtification From and Certification Year |
	| abc            |       |        | Please enter Certification Name, Certtification From and Certification Year |
	| abc            |       |        | Please enter Certification Name, Certtification From and Certification Year |
	|                | abcd  |        | Please enter Certification Name, Certtification From and Certification Year |
	|                |       | 2020   | Please enter Certification Name, Certtification From and Certification Year |
	
	
Scenario Outline: Updating profile Certification details
    Given I am on Home page
	When I select <Certification>                                                   
	And I click On Edit button 
    And I expect that the fields <Certification>, <From>, <Year> displays on the page
	And I click On Update button
	Then I expect the <Message> should be displyed on the screen


	Examples:  
	| Certification  | From | Year   |  Message                                                                     |
	| Best Employee  | abc  | 2020   |  Best Employee has been updated to your certification                        |
	| Best Employee  | abc  | 2020   |  This information is already exist                                           |
	|                |      |        |	Please enter Certification Name, Certtification From and Certification Year |
	|                | abc  |        |	Please enter Certification Name, Certtification From and Certification Year |
	|                |      | 2020   |	Please enter Certification Name, Certtification From and Certification Year |
	| Best Employee  |      |        |	Please enter Certification Name, Certtification From and Certification Year |
	| Best Employee  |      |        |	Please enter Certification Name, Certtification From and Certification Year |


Scenario Outline: Deleting profile Certification details
	Given I am on Home page
	When I select <Certification>                                              
	And I click on delete icon
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	 | Message                                  |
	 | Certification entry successfully removed |