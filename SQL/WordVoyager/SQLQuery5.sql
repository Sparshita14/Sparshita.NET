/*CREATE TABLE [User](
    UserId INT  NOT NULL,
	Username NVARCHAR(100) NOT NULL,
	Email NVARCHAR(100),
	PasswordHash NVARCHAR(100),
	RegistrationDate DATETIME,
	PRIMARY KEY (UserId)
);*/

/*ALTER TABLE [User] ALTER COLUMN Username NVARCHAR(100) NOT NULL;*/

/*

CREATE TABLE Category(
	CategoryId INT,
	Name NVARCHAR(100),
	Description TEXT,
	PRIMARY KEY (CategoryId)
);
*/

/*
ALTER TABLE [Category] ALTER COLUMN CategoryId INT NOT NULL;
*/

/*
CREATE TABLE Article(
    ArticleId INT  NOT NULL,
	Title NVARCHAR(100) NOT NULL,
	Content TEXT,
	PublishDate DATETIME,
	LastModifiedDate DATETIME,
	AuthorId INT,
	CategoryId INT,
	PRIMARY KEY (ArticleId),
	FOREIGN KEY(AuthorID) references [User](UserId),
	FOREIGN KEY(CategoryId) references Category(CategoryId)
);
*/

/*
CREATE TABLE Comment(
	CommentId INT NOT NULL,
	ArticleId INT NOT NULL,
	UserId INT NOT NULL,
	Content TEXT,
	CommentDate DATETIME,
	PRIMARY KEY (CommentId),
	FOREIGN KEY (ArticleId) REFERENCES Article(ArticleId),
	FOREIGN KEY (UserId) REFERENCES [User](UserId)
);
*/

/*
CREATE TABLE Tag(
	TagId INT NOT NULL,
	Name NVARCHAR(100) NOT NULL,
	PRIMARY KEY (TagId)
);
*/

/*
CREATE TABLE ArticleTag(
	ArticleId INT NOT NULL,
	TagId INT NOT NULL,
	FOREIGN KEY (ArticleId) REFERENCES Article(ArticleId),
	FOREIGN KEY (TagId) REFERENCES Tag(TagId)

);
*/

CREATE TABLE Attachment(
	AttachmentId INT NOT NULL,
	ArticleId INT NOT NULL,
	FileName NVARCHAR(100),
	FileType NVARCHAR(100),
	FilePath NVARCHAR(100),
	UploadDate DATETIME,
	PRIMARY KEY (AttachmentId),
	FOREIGN KEY (ArticleId) REFERENCES Article(ArticleId)
);



