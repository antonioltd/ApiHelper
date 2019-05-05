Feature: f1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given Posts rest endpoint is up
	When I request to get a post with id number 1
	Then the system will response 200 code
