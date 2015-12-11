CREATE TABLE Passengers
(
Ticket_Id varchar(255) NOT NULL,
Passenger_Name varchar(255) NOT NULL,
age int NOT NULL ,
sex varchar(255) NOT NULL,
Passenger_id int not null identity(1,1) constraint pk_passenger_id primary key
);