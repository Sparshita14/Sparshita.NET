/*
SP_help Article
*/

/*
CREATE Procedure selectArticle
	as
	begin
	SELECT * FROM Article
	end
*/

/*
EXEC selectArticle
*/

/*
CREATE Procedure addArticle(@articleId INT,@Title NVARCHAR(100),@Content TEXT,@AuthorId INT, @CategoryId INT)
	as
	begin
	INSERT INTO Article VALUES(@articleId,@Title,@Content,'01/02/2024','01/02/2024',@AuthorId,@CategoryId)
	end
*/

/*
EXEC addArticle '01','First','This is first','01','01'
*/
/*
EXEC addArticle '02','Second','This is second','01','02'
*/
/*
EXEC addArticle '03','Third','This is third','01','02'
*/

/*
CREATE Procedure updateArticle
	as
	begin
	UPDATE Article SET Content='Second Article' WHERE ArticleId='2'
	end
*/

/*
EXEC updateArticle
*/

/*
CREATE Procedure deleteArticle
	as
	begin
	DELETE FROM Article WHERE ArticleId='03'
	end
*/
/*
EXEC deleteArticle
*/
/*
EXEC sp_rename 'deleteArticle', 'deleteArticleById';
*/
/*
SELECT 
  ROUTINE_SCHEMA,
  ROUTINE_NAME
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_TYPE = 'PROCEDURE';
*/
