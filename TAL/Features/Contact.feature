Feature: ContactUs

Scenario: Contact Us Message
	Given I am on the home page
	And I navigate to the contact us page
	And I create a general enquiry with the following details
	| Name | Email | Phone |  Query | 
	| Joe Bloggs | my.subscriptions.post@gmail.com  | 0470000000 | Testing query |