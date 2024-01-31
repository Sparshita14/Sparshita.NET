/*
	CRUD (Create Read Update Delete)
*/
/*
CREATE Procedure addvalueUser
	as
	begin
	SELECT * FROM [User]
end
*/

/*
EXEC addvalueUser
*/

/*
CREATE Procedure insertValueUser
	as
	begin
	INSERT INTO [User] VALUES('01','sparshita_pal','sparshita@email.com','123456','01/01/2024')
end
*/

/*
EXEC insertValueUser
*/

/*
CREATE Procedure insertParameterValueUser(@userId INT, @userName NVARCHAR(100), @userEmail NVARCHAR(100), @userPassword NVARCHAR(100))
	as
	begin
	INSERT INTO [User] VALUES(@userId,@userName,@userEmail,@userPassword,'01/01/2024')
end
*/

/*
EXEC insertParameterValueUser '04',"sparshi","sparshi@email.com","123456"
*/

/*
CREATE Procedure updateUser
	as
	begin 
	UPDATE [User] SET Username='sparsh', Email='sparsh@email.com', PasswordHash='123456' WHERE Username='s'
	end
*/

/*
DROP Procedure updateUser
GO
*/

/*
CREATE Procedure updateUserWithNameS
	as
	begin 
	UPDATE [User] SET Username='sparsh', Email='sparsh@email.com', PasswordHash='123456' WHERE Username='s'
	end
*/

/*
EXEC updateUserWithNameS;
*/

/*
CREATE Procedure deleteUser(@userId INT)
	as
	begin
	DELETE FROM [User] WHERE UserId=@userId
	end
*/

/*
EXEC deleteUser '03'
*/

/*
EXEC sp_rename 'addvalueUser', 'getUsers';
*/

EXEC sp_rename 'deleteUser', 'deleteUserById';

SELECT * FROM [User];

SELECT 
  ROUTINE_SCHEMA,
  ROUTINE_NAME
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_TYPE = 'PROCEDURE';