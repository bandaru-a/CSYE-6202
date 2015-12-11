create PROCEDURE sp_D_Flight_Fare
@Flight_Id varchar(255) ,
@Class varchar(255)
AS
DELETE from Flight_Fare WHERE Flight_Id = @Flight_Id and class = @Class;
GO