----------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------
Project Name: Budeget Planning
Program Name: BudgetPlanning_POE_Task2
----------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------
* Readme file for program Budget Planning version 2.0
*
* Refer to the System and Software requirements that support the Budget planning program
----------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------
* Contents of the document
----------------------------------------------------------------------------------------------------------
This document contains the following categories:
1. General Description
2. Brief Description (Lecturers Feedback)
3. System and Software requirements
4. Compile The Program
5. Bugs
6. Contact Information

----------------------------------------------------------------------------------------------------------
* 1. GENERAL DESCRIPTION
----------------------------------------------------------------------------------------------------------
The personal budget application is an application where a user can state their salary
per month and their monthly occuring expenses. These expenses can include things such 
as their tax, grocery, travel cost, cellphone and other expenses that occur. Other 
expenses may depend on the user, such as purchasing a property, renting and the
purchasing of the vehicle. It would then calcuate the total expenses for the month, 
showing the user how much income is left. The application would then state whether the
user has exceeded their income for the month.
----------------------------------------------------------------------------------------------------------
* 2. BRIEF DESCRIPTION LECTURERS FEEDBACK)
I have removed multiple if statements and replaced it with switch statements in order to
display professionalism. Switch statements  improves clarity and reduces the number of times 
the code is repeated. I have added a try {} catch (){} block. The reason for this is that 
if the user has the incorrect input value, then it would be caught by the catch block.
A do while loop has been added, so that if the user inputs an incorrect value it would
ask the user whether they would like to restart the process or end the process. The 
list that has been created is set to manipulated. it sorts and reverses the list.
The new ReadMe file has been adjusted to occupy more relevant information, so that
the end user has a better understanding of what the program is about
----------------------------------------------------------------------------------------------------------
* 3. SYSTEM AND SOFTWARE REQUIREMENTS
The operatiing system that may be used, is the following:
	*Windows
	*macOS
	*Linux

The required Windows operating system would be Windows 7, 8 or 10.
It is preferable to use Windows 10 to run your program.
*
*
A software installation of Visual Studio is required to run the application.
You are required(*) to install any of the following software. Following software:
	*Visual Studio 2019 Community (Free to use)
	*Visual Studio 2019 Professional
	*Visual Studio 2019 Enterprise

It is availible for Windows, macOS and Linux. Use the link that is availible to download
one of the versions:
	*https://visualstudio.microsoft.com/downloads/
----------------------------------------------------------------------------------------------------------
* 4. COMPILE THE PROGRAM
Firstly the file needs to be unzipped once downloaded.
To open the application select the the file named [BudgetPlanning_POE_Task2.sln].
Double click the file or press the enter button (if the file is selected) to open up the 
application. The application will open through the visual studio application and the code 
will be brought up through the application.
*
--Too compile the code:
*Click on the [▶ BudgetPlanning_POE_Task2] (a button located on top of the visual studio application)

*A command prompt application would open as a new window.
*The user would need to input their gross monthly income
*The user would need to input all their monthly expenses. These consist of tax, groceries, 
 water and lights, travel costs, cellphone and telephone, and other expenses.
*The user would then be given the choice to puchase a property or to rent one.
*If the user chooses to purchase the property, then the user would input the price, total 
 deposit, interest rate and number of months of the property to purchase.
*If the user chooses to rent a property, then the user would input their rent.
*The user would be given an option to purchase a vehicle.
*If the user would like to purchase a vehicle, then the user would input the price, total 
 deposit, interest rate and insurance premium of the vehicle.
*If the user does not want to purchase a vehicle, it would then show that no inputs to 
 purchase a vehicles.
*After all the inputs from the user, it would show if the user has exceeded 75% of their 
 income. It would also show the expenses that the user has made for the month.
*It would display the values in decending order. 
*If during the process of the input, there is an incorrect value entered by the user, it
 would be caught and show that an error hasbeen committed.
----------------------------------------------------------------------------------------------------------
* 6. BUGS
There is a small bug at the end of the application. The whole application executes correcting. 
One value is represented as NAN (this occurs when the values are displayed in decending order).
But the calculations of all the expenses, income, vehicle and home loan executes correctly.
That is the only bug present in the application.
----------------------------------------------------------------------------------------------------------
* 7. CONTACT INFORMATION
My name is Yagnash Keeka and I am a student at Varsity College (Located in Sandton)
Email: 20108984@vcconnect.co.za
----------------------------------------------------------------------------------------------------------