create PROCEDURE sp_D_Passenger
@Ticket_Id varchar(255) ,
@Name varchar(255),
@age int
AS
DELETE from Passengers WHERE Ticket_Id = @Ticket_Id and Passenger_Name = @Name and age = @age;
GO