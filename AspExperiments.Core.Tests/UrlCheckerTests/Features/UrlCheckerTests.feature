Feature: UrlCheckerTests
	In order to avoid silly mistakes
	As image checker
	I want to be told the existing file

@mytag
Scenario Outline: Add two numbers
	Given I have an UrlChecker
	When I have '<Url>' link
	Then The result should be '<Result>'

	Examples: 
	| Url                                                                                     | Result |
	| https://www.google.by/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png       | True   |
	| https://www.google.by/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png.Error | False  |

