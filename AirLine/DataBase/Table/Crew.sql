CREATE TABLE Crew
(
Flight_Id varchar(255) NOT NULL,
Employee_Name varchar(255) NOT NULL,
Position_Id varchar(255) NOT NULL,
age int NOT NULL ,
sex varchar(255) NOT NULL,
Employee_id int not null identity(1,1) constraint pk_CREW_id primary key
);