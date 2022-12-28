# ASSESSMENT_DR2_JESSICAGALHARDI

Final Project developed by me, for prove the knowledge acquired in the first three months studied at my Fundamentals of Web Application Development ASP .NET course, 
at System Analysis And Development degree(INFNET University).

**Requests for the project, definition, tasks:**

**With the objective of practicing everything that was learned in the Fundamentals of ASP .NET Web Application Development course, 
in this Assessment, you must create, with Visual Studio, a project of a Web application of the ASP .NET Web Application type (. NET Framework) and 
use the MVC template. This project will be an application for Managing Friends' Birthdays. 
All data used by this application must be stored in a SQL Server Express LocalDB database.**

**On the application's main page, two lists should be displayed: one containing the names of friends having a birthday on
that day, and another containing the names and birthdays of friends sorted from the closest to the most distant date.**

**There should also be a page for registering friends and a page that lists all friends. 
This second one should give the options to update the friend's data or delete the friend, and should also allow a search to be carried out by the friend's name.**

**A friend must have at least a first name, last name and birthday.**

**You must create the required Models, Strongly Typed Views, Controllers, and Repositories.**

Project:

**Home:** Contains a list With the friends saved at the local DB SQL, and a link for the friends who make Birthday in the day:

![Home](https://user-images.githubusercontent.com/104734490/209805830-9ea41de6-1035-4ef2-ba04-2649fc683f91.JPG)<br/>

![ListBirthHome](https://user-images.githubusercontent.com/104734490/209805794-c7b3b32b-14e3-4bd0-8129-831601b09ba0.JPG)<br/>

**View with the friends birthday:**

![ListBirth](https://user-images.githubusercontent.com/104734490/209808358-27280c50-dd0f-4e60-bad9-3e66e002f041.JPG)

**List:** Shows a list with all friends. In this View, its possible search a friend using first name, last name or part of them
and contains the links for the CRUD operations(details,insert, update and delete):

**Search:**
![Search](https://user-images.githubusercontent.com/104734490/209807590-d25b2fe1-ce7d-403a-9387-d043244abbd4.JPG)<br/>

The search result returns contact details:

![SreachResult](https://user-images.githubusercontent.com/104734490/209807719-42f39537-97ae-415d-854a-4dea9b291379.JPG)

**Insert**

![Add](https://user-images.githubusercontent.com/104734490/209807819-62c2b315-5f8f-4e4a-9018-288c60094cf3.JPG)

![Addlist](https://user-images.githubusercontent.com/104734490/209807846-9413ae11-a380-4441-90aa-b028dc8a5955.JPG)

**Delete:** for security, first of delete a friend, the system confirm the action with the user:

![Delete](https://user-images.githubusercontent.com/104734490/209808230-dbcef355-5b58-4df4-9494-21a6ac6a35d5.JPG)<br/>

After the confirm, the contact ID 64 was deleted!

![DeleteResult](https://user-images.githubusercontent.com/104734490/209808278-99dbd31b-4427-4025-b76f-06dfbad62598.JPG)

**Update:**

![List](https://user-images.githubusercontent.com/104734490/209808500-1b014580-bc17-43ec-9225-689c4a91089e.JPG)<br/>

![UpdateResult](https://user-images.githubusercontent.com/104734490/209808541-1866d89a-d0a8-448c-9dd4-dd883f601092.JPG)

The Front-end was created using Bootstrap.





