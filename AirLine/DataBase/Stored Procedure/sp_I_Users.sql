CREATE PROCEDURE sp_I_Users 
@Usr_Id varchar(255) ,
@pasword varchar(255) ,
@Name varchar(255) ,
@Age int,
@Sex varchar(255) ,
@email_Id varchar(255)  ,
@Contact_No varchar(255) ,
@City varchar(255),
@UState varchar(255),
@grpId varchar(255)
AS
INSERT INTO [Users]
           ([Usr_Id]
           ,[Name]
		   ,[Age]
		   ,[Sex]
           ,[email_Id]
           ,[Contact_No]
           ,[City]
           ,[UState]
           ,[pasword])
     VALUES
           (@Usr_Id
           ,@Name
           ,@Age
		   ,@Sex
           ,@email_Id
           ,@Contact_No
           ,@City
           ,@UState
           ,@pasword);

INSERT INTO [User_Group_link]
           ([grp_Id]
           ,[usr_id])
     VALUES
           (@grpId
           ,@Usr_Id)


GO