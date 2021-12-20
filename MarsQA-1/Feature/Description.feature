Feature: Description
	    In oder to add and update profile details 
		As seller of this website
		I want to add and update profile details

@mytag
Scenario Outline: Adding profile Description details
	Given I am on profile page
	When I select <Description> icon                                              
	And I expect Description textbox will open
	And I will be able to add data in description text box
	And I click Save button
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	 | Description | Message                                 |
	 | abc         | Description has been saved successfully |
	 | abcdef       | Description has been saved successfully |

Scenario Outline: Not adding profile Description details
	Given I am on profile page
	When I select <Description> icon                                              
	And I expect Description textbox will open
	And I am not adding data in description text box
	And I click Save button
	Then I expect the <Message> should be displyed on the screen

	Examples:  
	 | Message                                |
	 | Please, a description is required      |
