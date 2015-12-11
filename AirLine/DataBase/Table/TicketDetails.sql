CREATE TABLE Ticket_details
(
Ticket_Id varchar(255) NOT NULL,
Flight_Id varchar(255) NOT NULL,
Bokked_on datetime NOT NULL ,
Booked_by Varchar(255) NOT NULL, 
class Varchar(255) Not NUll
CONSTRAINT pk_TicketId PRIMARY KEY (Ticket_Id)
);