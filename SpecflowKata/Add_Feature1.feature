Feature: Add_Feature1
	In order to generate a sum
	As an .Add method
	I want to be told the sum of Zero numbers

@mytag
Scenario: Add zero numbers
	Given I an empty string
	When I pass the string to add
	Then the result is zero

