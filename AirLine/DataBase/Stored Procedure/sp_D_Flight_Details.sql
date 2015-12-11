CREATE PROCEDURE sp_D_Flight_Details
@Flight_Id varchar(255) 
AS
DELETE from Flight_details WHERE Flight_Id = @Flight_Id;
GO