CREATE PROCEDURE sp_U_Flight_Fare
@Flight_Id varchar(255) ,
@class varchar(255) ,
@cost money 
AS
UPDATE Flight_Fare
   SET Cost = @cost
 WHERE Flight_Id = @Flight_Id and class = @class;
GO