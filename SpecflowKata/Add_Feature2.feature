Feature: Add_Feature2
	In order to generate a sum
	As an .Add method
	I want to be told the sum of a comma seperated string of numbers

@mytag
Scenario Outline: Add a comma seperated string of numbers
	Given I have a comma delimited <string> of numbers passed to add
	When I get the result
	Then the result is the <sum> of the numbers passed in

	Examples:
    | string | sum |
    |     |  0  |
    |  1   |  1  |
    |  1,2,3   |  6  |
    |  1,1,1   |  3  |
    |  0,0,0   |  0  |

