CREATE PROCEDURE sp_I_Flight_Crew
@Flight_Id varchar(255) ,
@Employee_Name varchar(255) ,
@Position_Id varchar(255) , 
@age int,
@sex varchar(255)
AS
INSERT INTO Crew
           (Flight_Id
           ,Employee_Name
           ,Position_Id
           ,age
           ,sex)
     VALUES
           (@Flight_Id
           ,@Employee_Name
           ,@Position_Id
           ,@age
           ,@sex)
GO
