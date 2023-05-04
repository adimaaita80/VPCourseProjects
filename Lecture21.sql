/* This is a script to create a new database  */
Create Database IU_VP_Script_DB

Use IU_VP_Script_DB

Create Table Students
(
	StudentId int PRIMARY KEY Identity(1, 1),
	StudentName nvarchar(50) not null
)

/* CRUD operations (Create, Reterieve, Update, Delete) */

/* Insert a new record into the Students table */
Insert into Students(StudentName) values('Adi Maaita') /* Create */

/* Return all the records from the Students table */
Select * From Students /* Retrieve: this is called a query operation */

/* Update a record by using the primary key value */
Update Students
Set StudentName = 'Adi Abdelhalim Maaita'	/* Update */
where StudentId = 2

/* Delete a record by using the primary key value */
Delete from Students where StudentId = 2