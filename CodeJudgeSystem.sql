CREATE TABLE [Users] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [name] nvarchar(255) NOT NULL,
  [address] nvarchar(255) NOT NULL,
  [email] nvarchar(255) UNIQUE,
  [password] nvarchar(255) NOT NULL,
  [role] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [Problems] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [title] nvarchar(255) NOT NULL,
  [body] nvarchar(255) NOT NULL,
  [testinput] nvarchar(255),
  [testoutput] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [InputOutput] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [input] nvarchar(255),
  [output] nvarchar(255) NOT NULL,
  [problem_id] int NOT NULL
)
GO

CREATE TABLE [Submissions] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [problem_id] int NOT NULL,
  [user_id] int NOT NULL,
  [code] nvarchar(255) NOT NULL,
  [result] int NOT NULL,
  [time] datetime NOT NULL
)
GO

ALTER TABLE [InputOutput] ADD FOREIGN KEY ([problem_id]) REFERENCES [Problems] ([id])
GO

ALTER TABLE [Submissions] ADD FOREIGN KEY ([problem_id]) REFERENCES [Problems] ([id])
GO

ALTER TABLE [Submissions] ADD FOREIGN KEY ([user_id]) REFERENCES [Users] ([id])
GO
