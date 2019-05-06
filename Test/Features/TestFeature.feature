Feature: TestFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@posts
Scenario: Get a specific post
	Given Posts rest endpoint is up
	When I request to get a post with id number 1
	Then the system will return 200 code
	And the title of the post is 'sunt aut facere repellat provident occaecati excepturi optio reprehenderit'
	
Scenario: Get all posts
	Given Posts rest endpoint is up
	When I request to get all posts
	Then the system will return 200 code
	And the total number of posts is 100

Scenario: Write a post successfully
	Given Posts rest endpoint is up
	When I request to write a post with detail:
	| Title  | Body                     | UserId |
	| brexit | What happen after brexit | 1      |
	Then the system will return 201 code
	And returned a unique id