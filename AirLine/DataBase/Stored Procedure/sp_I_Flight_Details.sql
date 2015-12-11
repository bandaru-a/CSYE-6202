CREATE PROCEDURE sp_I_Flight_Details
@Flight_Id varchar(255) ,
@Flight_Description varchar(255) ,
@Arrival_time datetime ,
@Departure_time datetime ,
@FSource varchar(255)  ,
@FDestination varchar(255) 
AS
INSERT INTO dbo.Flight_details
           (Flight_Id
           ,Flight_Description
           ,Arrival_time
           ,Departure_time
           ,FSource
           ,FDestination
           )
     VALUES
           (@Flight_Id
           ,@Flight_Description
           ,@Arrival_time
           ,@Departure_time
           ,@FSource
           ,@FDestination);

GO