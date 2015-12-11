create PROCEDURE sp_D_Ticket
@Ticket_Id varchar(255) 
AS
DELETE from Ticket_details WHERE Ticket_Id = @Ticket_Id;
GO