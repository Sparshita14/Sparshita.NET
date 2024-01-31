/*
SP_help Category
*/

/*
CREATE Procedure selectCategory
	as
	begin
	SELECT * FROM Category
	end
*/

/*
EXEC selectCategory
*/

/*
CREATE Procedure addCategory(@categoryId INT,@Name NVARCHAR(100),@Description TEXT)
	as
	begin
	INSERT INTO Category VALUES(@categoryId,@Name,@Description)
	end
*/

/*
EXEC addCategory '01','Sparshita','this is a description'
*/

/*
EXEC addCategory '02','Sparsh','this is a description22'
*/
/*
EXEC addCategory '03','Sparshi','Description3'
*/
/*
CREATE Procedure updateCategory
	as
	begin
	UPDATE Category SET Description='Second description' WHERE CategoryId='2'
	end
*/

/*
EXEC updateCategory
*/

/*
CREATE Procedure deleteCategory
	as
	begin
	DELETE FROM Category WHERE CategoryId='03'
	end
*/
/*
EXEC deleteCategory
*/

