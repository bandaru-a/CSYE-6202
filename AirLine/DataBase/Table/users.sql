CREATE TABLE Users
(
Usr_Id varchar(255) NOT NULL,
pasword varchar(255) NOT NULL,
Name varchar(255) NOT NULL,
Age int NOT NULL,
Sex Varchar(255) Not Null,
email_Id varchar(255) NOT NULL unique,
Contact_No varchar(255) NOT NULL unique,
City varchar(255),
UState varchar(255), 
CONSTRAINT pk_UsrID PRIMARY KEY (Usr_Id),
CONSTRAINT uk_email_Id UNIQUE (email_Id),
CONSTRAINT uk_Contact_No UNIQUE (Contact_No)
)


