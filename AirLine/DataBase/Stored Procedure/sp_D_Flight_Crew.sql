create PROCEDURE sp_D_Flight_Crew
@Flight_Id varchar(255) ,
@Position_Id varchar(255)
AS
DELETE from Crew WHERE Flight_Id = @Flight_Id and Position_Id = @Position_Id;
GO