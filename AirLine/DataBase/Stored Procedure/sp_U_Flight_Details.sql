CREATE PROCEDURE sp_U_Flight_Details
@Flight_Id varchar(255) ,
@Flight_Description varchar(255) ,
@Arrival_time datetime ,
@Departure_time datetime ,
@FSource varchar(255)  ,
@FDestination varchar(255) 
AS
UPDATE Flight_details
   SET Flight_Description = @Flight_Description
      ,Arrival_time = @Arrival_time
      ,Departure_time = @Departure_time
      ,FSource = @FSource
      ,FDestination = @FDestination
 WHERE Flight_Id = @Flight_Id;
GO