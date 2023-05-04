/* This is script to create a new database  */

Create Database IU_VP_Script_DB

Use IU_VP_Script_DB

Create Table Students
(
	StudentId int PRIMARY KEY Identity(1, 1),
	StudentName nvarchar(50) not null
)

/* Insert a new record into the Students table */
Insert into Students(StudentName) values('Adi Maaita')

/* Return all the records from the Students table */
Select * From Students