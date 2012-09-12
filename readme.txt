JustGiving Senior Automation Test Tasks
=======================================

These are the interview questions for the role of a senior QA automation engineer.
We've provided a running, executing Visual Studio 2012 solution with a website
under test, and a C# project for automation / UI / acceptance tests.

You'll need at least a copy of Visual Studio 2012 Express Edition (free) 
to run this project / the tests.

We've included some of the things we think you'll need; a working copy of 
selenium (you'll need firefox installed though), NUnit (and the NUnit runner),
an embedded SQL Express database and an example test file that loads the website
when you press F5. You should first run the JustGiving.Recruitment.QaAutomation.Website
from within Visual Studio, and then execute your tests against it.

We have included the NUnit test runner for you to use and you can find it in
\packages\NUnit.Runners.2.6.1\tools. We use the ReSharper test runner internally
and execute our tests using TeamCity and we will verify your tests using ReSharper.

All of your tests should be inside JustGiving.Recruitment.QaAutomation.Website.Tests.
Feel free to use any external libraries or components that you need, but please
make sure you include them when you send the test back to us, as we expect it to run
when we open it.

We develop new features at JustGiving using user stories in agile iterations.
In order to keep this test relevant, we've written some user stories for features
of the fake website included in this repository. We'd like you to complete 
automation tests for them.

It shouldn't take too long, around 30 minutes, and is designed to test your 
knowledge of Selenium, your style and composition of tests and your approach
to keeping tests maintainable. The user stories are relatively simple, and
get harder as you work through. These tests act as our "phone screen", so 
don't worry if you don't find them too challenging.

We will discuss your tests and the way you approached them in any subsequent
interview.

Story 1
=======
As a user
When I click "Log on" on the site (http://localhost:9876)
I am offered the ability to register

Story 2
=======
As a user of the registration page (http://localhost:9876/Account/Register)
When I provide valid unique credentials
An account is created for me

Story 3
=======
As a user of the registration page (http://localhost:9876/Account/Register)
When I provide a username that has already been created in the system
I see an error message to enter another username.

Story 4
=======
As a user of the list selection page (http://localhost:9876/Home/About)
When I select the list option "ThisOne"
I am redirected to a page with the h2 tag that says "ThisOne"

Story 5
=======
As a user of the list selection page (http://localhost:9876/Home/About)
When I select each list item
I am redirected to a page where the h2 tag says the name of the item selected