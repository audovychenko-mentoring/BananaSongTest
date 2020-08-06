Feature: SearchForYouTubeBannanaSongUsingGoogle

In order to validate views quantity for bannana song
As a basic User 
I want to search for bannana song using Google

@bannanasong

#Background: 
#	Given User navigate to the login page
#	When User submit username and password 223218Qwerty
#	Then User should be logged into Google Account: Test Mentoring (mentoringepam@gmail.com) account

Scenario: Search for YouTube song using Google
	Given User is on the Google search page
	When User search for <searchRequest>
	And User selects YouTube link to navigate
	Then User is on the page with <titleToValidate> title

Examples: 
    | searchRequest   | titleToValidate |
    | banana song     |  Despicable Me  |
    | redroom         |  Redroom        |
    | арменфильм      |  говорящая рыба |

Scenario: Validate the views quantity
	Given User is on the Google search page
	When User search for banana song
	And User selects YouTube link to navigate
	Then Views quantity for the banana song video is more than 50000000

Scenario: Login to gmail
    Given User navigate to the login page
	When User submit username and password 223218Qwerty
	Then User should be logged into Google Account: Test Mentoring (mentoringepam@gmail.com) account

Scenario: Create a new email and save as a draft
    Given User is signed in into Gmail
	When User creates new email with newTitle title
	And User saves a new email to drafts
    Then New email with newTitle title is in draft folder

Scenario: Send an email from the draft folder
    Given User is signed in into Gmail
	And User is in the draft folder
	When User send the draft email to newReceipenEmail recipient email
	Then Email with newTitle title is no longer in draft folder
	And Email with newTitle title is in sent folder