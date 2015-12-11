CREATE TABLE Flight_details
(
Flight_Id varchar(255) NOT NULL,
Flight_Description varchar(255) NOT NULL,
Arrival_time datetime NOT NULL ,
Departure_time datetime NOT NULL ,
FSource varchar(255) NOT NULL,
FDestination varchar(255) NOT NULL,
CONSTRAINT pk_FlightId PRIMARY KEY (Flight_Id)
);

alter table Flight_details add constraint uk_Source_Destination
unique (FSource,FDestination);

alter table Flight_details add constraint uk_Arrival_Departure
unique (FSource,FDestination);