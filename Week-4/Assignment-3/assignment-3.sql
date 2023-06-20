CREATE TABLE Article (
    id INT PRIMARY KEY IDENTITY(1,1),
    title NVARCHAR(100) NOT NULL,
    content NVARCHAR(MAX) NOT NULL,
    authorId INT NOT NULL,
    CONSTRAINT FK_Article_User FOREIGN KEY (authorId) REFERENCES [User](id)
);


SELECT a.*, u.email AS authorEmail FROM Article a JOIN [User] u ON a.authorId = u.id;

SELECT Id,Title,Content,AuthorId
FROM (
    SELECT *, ROW_NUMBER() OVER (ORDER BY id) AS RowNumber
    FROM Article
) AS numberedArticles
WHERE RowNumber BETWEEN 7 AND 12;