Feature: Transunion Home Page
	
	As a Transunion Customer
	I want the Transunion Home Page to be Responsive 
	so I can us the Website on Mobile and Desktop

Background: Navigate to the Transunion.com Home Page
	Given I navigate to the "http://www.Transunion.com" Home Page


@SmokeMobile
Scenario Outline: View the Home Page in the Mobile Browser
	Given the Transunion Home Page is displayed correctly on mobile browsers <Mobile Browser>
	When the Base Mobile Home Page Image is Compared to the Current Home Page Image
	Then the Home Page images should match correctly

Examples:

| Mobile Browser            |
| Mobile Chrome Pixel Phone |