CREATE PROCEDURE sp_I_Passengers
@Ticket_Id varchar(255) ,
@Passenger_Name varchar(255) ,
@Age int,
@Sex varchar(255) 
AS
INSERT INTO dbo.Passengers
           (Ticket_Id
           ,Passenger_Name
           ,age
           ,sex)
     VALUES
           (@Ticket_Id
           ,@Passenger_Name
           ,@Age
           ,@Sex)


GO