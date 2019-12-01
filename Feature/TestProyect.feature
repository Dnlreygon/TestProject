Feature: TestProyect
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@TC01
Scenario: Google search text box is displayed
	Given Open google web browser
	When I navigate to google page
	Then Validate search bar is Displayed.

	@TC02
Scenario: Google logo is displayed
	Given Open google web browser
	When I navigate to google page
	Then Validate google logo is displayed

	@TC03
Scenario: Google displays results when I search "youtube"
	Given Open google web browser
	When I navigate to google page
	And Search "youtube"
	Then Validate youtube results are down

	@TC04
Scenario: Google displays results when I search "Luxoft"
	Given Open google web browser
	When I navigate to google page
	And Search for "Luxoft"
	Then Validate google results are down