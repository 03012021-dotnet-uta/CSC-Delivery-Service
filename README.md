# HaikuWriter
A random haiku generator using user-submitted lines that also allows users to share their favorite random haikus with their friends over social media.
# Team Information
Team members:
  Chris Larson (Team Leader)
  Catherine Cheatle
  Sagar Luitel
  
# Product Overview
Introduction:
  Haiku Writer is a program bringing the joy of haikus to the masses in a social setting, designed to make it easy to share your favorites, discuss your love of haiku, or contribute to the generator by adding your own lines to the many already contained. Get relevant lines through our streamlined tagging system, and tag your own so others can find it easier!
  
Product Goal:
  A haiku is a traditional japanese poem containing three lines of 5, 7, and 5 syllables respectively. Often these short poems are used to demonstrate humor as well as other emotions in a short artistic style. This is one of the many types of poems that the world has to offer. 
  With our web application we will provide a way for our users to generate random haikus that they can save to their favorites. Users can also view a collection of haikus written by other users. The application will allow users to submit their own haikus or even lines of haikus that will later be reviewed by our admin team and if they are approved will be displayed to other users on our site. With a tagging system, users can easily filter and find haiku-segments based on their categories assigned to them. A tagging system will also be used to build and generate haikus based on the tags assigned upon creation of those lines. With our 3rd party social media sharing api users can be used to post poetry content from our site to social media accounts.
	Our discussion forums will bring community among our users to foster discussion and appreciation on haikus and other poetry forms. Users can create, edit and post to the forum. To ensure civility among our boards, we will implement a flagging system for posts to be reviewed by our admin staff to decide whether the post should be removed.

Minimum Viable Product:
  A user using this application should be able to sign up and login to an account. A user should be able to generate a haiku or view a list of haikus and save it under their favorites. A user should be able to share a haiku to social media. A user should be able to write a line or a whole haiku to be later reviewed by an admin user. An admin user should be able to review pending poems for review to either approve or reject. In the event a new user should need admin privileges a current admin user should be able to grant admin access. Users should be able to create, edit and delete posts on a discussion forum board. 

Tech Stack:
Angular, Azure Pipeline, VS Code, Entity Framework, AzureDB

User Stories:
1.  As a user I want to sign up so that I can keep track of personal data
2.  As a user I want to be able to login so that I can retrieve my account information
3.  As a user I want to generate a haiku so I can share or save to my favorites
4.  As a user I want to add to favorites so I can view them again
5.  As a user I want to share my haiku on social media so others can read them
6.  As a user I want to be able to write a haiku so I can publish it on the website either anonymously or publicly for other users to see 
7.  As a user I want to be able to write a single line so I can publish it for random generation
8.  As a user I want to be able to see list of haiku poems so I can share or save it to my favorites
9.  As a user I want to use a tag to generate a relevant haiku.
10. As a user I want to post on discussion forums so I can interact with other users on the site.
11. As a user and admin I want to be able to add tags to lines of haiku so I can help group haikus by relevance.
12. As an admin, I want to moderate the forum so I can delete inappropriate posts that do not follow the guidelines of the forum.
13. As an admin I want to be able to grant a user admin privileges so I can add a user to the admin team
14. As an admin I want to log in to view pending lines so I can approve them
15. As an admin I want to review pending poems so that I can either approve or reject poems to be published

Stretch Goals: 
* Add a leaderboard to view the top 10 most favorited 5-syllable and 7-syllable lines
* Add a follow feature for poets
* Add Reactions to haikus (ex. Likes, dislikes, etc)
* Add Dictionary Api to automate syllable-checking
* Adding AI to check for inappropriate and disparaging context
* Use JWT Authentication

3rd Party API:
  https://www.shareapi.com/
    To share content from website to various social media sites
  http://www.datamuse.com/api/
    For users to help find words for their haiku writing and to add spell-checking to the forum.

  
