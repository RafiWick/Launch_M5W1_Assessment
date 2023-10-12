# Week 1 Assessment

For this assessment, imagine that you are at an interview.  Answer each question as you would for an interviewer.  Similarly, treat the exercises as part of the interview - show the best of what you can do!

### Setup
* Fork and Clone this repository
* Run `update-database`

## Questions (7 points)

### Setup and Workflow (1 point)
* Check out a branch called `questions`
* Answer the two questions below
* Use a Pull Request to merge your branch into **your** main branch

1. How would you rate your comfort level and abilities when working with a SQL database? (3 points)
I am very comfortable working with an SQL database, for example while working on a CRUD MVC project my "client" asked me to find an agregate statistic from the database I was working with. In order to get the data I needed I was able to slowly build up the query until it returned the correct information. I started with a simple SELECT * FROM members, added a WHERE the member has a certain name, then I added two join statements, changed the SELECT * to what I needed and added the group by statement to finish the query.  
2. How do you familiarize yourself with a codebase you haven’t worked in before? (3 points)
In order to familiarize myself with a new codebase I like to start by reading the comments, If the comments are thourough enough That may be all I need to do to become familiar with the code base. For example when looking at code that Joe wrote in the LevelUp project I didn't need to read his code to know what it was doing due to the comments that he writes. Sometimes when I don't have good enough comments to rely on I can just read the code. When I can't gleam understanding by reading the code I put in many breakpoints and watch the code run one step at a time. If I still don't understand the code my final resort is to refactor the code until I do understand it.

## Exercise (11 points)

### Setup and Workflow (1 point)
* Check out a branch called `error-handling-logging`
* Review the existing code in the 'RecordCollection' project
	* run the project, and play around with all MVC and API endpoints

There are **many** places where this app could use some work in Error Handling **and** Logging.
* Identify at least 5 areas for improvement, and:
	* implement the improvement (1 point each)
* Use a Pull Request to merge your branch into **your** main branch
* In the PR comment, add a note for **each improvement** you made explaining why you decided to make the improvement. (1 point each)

It is up to you to decide what improvements to make, but you need to include at least 2 of each type (Error Handling and Logging).

## Rubric

This assessment has a total of 18 points.  A score of 12 or higher is a pass.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!

