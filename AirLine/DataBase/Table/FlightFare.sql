CREATE TABLE Flight_Fare
(
Flight_Id varchar(255) NOT NULL,
Cost money Not null,
class  varchar(255) NOT NULL,
Flight_Fare_id int not null identity(1,1) constraint pk_FF_id primary key
);


alter table Flight_Fare add constraint uk_Flight_class
unique (Flight_Id,class);
