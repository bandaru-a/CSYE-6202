CREATE TABLE UserGroup
(
grp_Id varchar(255) NOT NULL,
Grp_Desc varchar(255) NOT NULL unique,
CONSTRAINT pk_GrpID PRIMARY KEY (grp_Id)
)


