Feature: MakingClaim

Scenario: Making a claim
	Given I am on the home page
	And I navigate to the quote page
	And I create a quote with the following details
	| FirstName | LastName | Gender | BirthDate | IsSmoker | Occupation                        | AnnualIncome | PhoneNumber | EmailAddress                    | PostCode |
	| Joe       | Bloggs   | M      | 01011990  | false    | Accountant - University qualified | 150000        | 0470000000 | my.subscriptions.post@gmail.com | 1010     |
 	When I add Life Insurance with 1500000 cover
 	Then The total monthly premium is 53.14