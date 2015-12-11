create PROCEDURE sp_U_Flight_Crew
@Flight_Id varchar(255) ,
@Employee_Name varchar(255) ,
@Position_Id varchar(255) ,
@Age int,
@Sex varchar(255)
AS
UPDATE Crew
   SET Employee_Name = @Employee_Name
      ,Position_Id = @Position_Id
      ,age = @Age
      ,sex = @Sex
 WHERE Flight_Id = @Flight_Id and Position_Id = @Position_Id;
GO