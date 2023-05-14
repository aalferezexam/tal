Feature: Search Insurance and Make Quote

Scenario: Search Insurance and Make Quote
	Given I am on the home page
	And I navigate to the insurance page and make a quote
	And I create a quote with the following details
	| FirstName | LastName | Gender | BirthDate | IsSmoker | Occupation                        | AnnualIncome | PhoneNumber | EmailAddress                    | PostCode |
	| Joe       | Bloggs   | M      | 01011990  | false    | Accountant - University qualified | 150000        | 0470000000 | my.subscriptions.post@gmail.com | 1010     |
 	When I add Life Insurance with 1500000 cover
 	Then The total monthly premium is 53.14