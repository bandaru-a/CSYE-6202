CREATE PROCEDURE sp_I_Ticket_Details
@Ticket_Id varchar(255) ,
@Flight_Id varchar(255) ,
@Booked_on datetime ,
@Booked_by varchar(255)  ,
@class varchar(255)  
AS
INSERT INTO dbo.Ticket_details
           (Ticket_Id
           ,Flight_Id
           ,Bokked_on
           ,Booked_by
           ,class)
     VALUES
           (@Ticket_Id
           ,@Flight_Id
           ,@Booked_on
           ,@Booked_by
           ,@class)

GO