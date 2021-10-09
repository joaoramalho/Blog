USE master
GO
CREATE DATABASE Blog
GO
USE Blog
GO
CREATE TABLE [User]
(
    user_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [name] NVARCHAR(50) NOT NULL,
    surname NVARCHAR(50) NULL,
    mobile NVARCHAR(15) NULL,
    email NVARCHAR(30) NOT NULL,
    password_hash NVARCHAR(50) NOT NULL,
    last_login DATETIME NOT NULL,
    user_create NVARCHAR(30) NOT NULL,
    date_create DATETIME NOT NULL,
    user_change NVARCHAR(30) NOT NULL,
    date_change DATETIME NOT NULL
)
GO
CREATE TABLE Posts
(
    post_id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    title NVARCHAR(80) NOT NULL,
    summary NVARCHAR(20) NOT NULL,
    published DATETIME NOT NULL,
    content NVARCHAR(max),
    user_create NVARCHAR(30) NOT NULL,
    date_create DATETIME NOT NULL,
    user_change NVARCHAR(30) NOT NULL,
    date_change DATETIME NOT NULL
)
GO
ALTER TABLE Posts
ADD CONSTRAINT fk_user_id
FOREIGN KEY (user_id)
REFERENCES [User](user_id)
GO
CREATE TABLE Comments
(
    [comment_id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    post_id INT NOT NULL,
    user_id INT NOT NULL,
    content NVARCHAR(max) NOT NULL,
    published DATETIME NOT NULL,
    user_create NVARCHAR(30) NOT NULL,
    date_create DATETIME NOT NULL,
    user_change NVARCHAR(30) NOT NULL,
    date_change DATETIME NOT NULL
)
GO
ALTER TABLE Comments
ADD CONSTRAINT fk_post_id
FOREIGN KEY (post_id)
REFERENCES Posts(post_id)
GO
ALTER TABLE Comments
ADD CONSTRAINT fk_posts_user_id
FOREIGN KEY (user_id)
REFERENCES [User](user_id)
GO