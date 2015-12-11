CREATE PROCEDURE sp_I_Flight_Fare
@Flight_Id varchar(255) ,
@Class varchar(255) ,
@cost money 
AS
INSERT INTO Flight_Fare
           (Flight_Id
           ,Class
           ,cost)
     VALUES
           (@Flight_Id
           ,@Class
           ,@cost);

GO