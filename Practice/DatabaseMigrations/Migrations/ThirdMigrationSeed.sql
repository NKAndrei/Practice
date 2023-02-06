BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AuthorId', N'AuthorName') AND [object_id] = OBJECT_ID(N'[Authors]'))
    SET IDENTITY_INSERT [Authors] ON;
INSERT INTO [Authors] ([AuthorId], [AuthorName])
VALUES (1, N'Pablo Eskobar'),
(2, N'Scooby Doo'),
(3, N'Rick Sanchez');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'AuthorId', N'AuthorName') AND [object_id] = OBJECT_ID(N'[Authors]'))
    SET IDENTITY_INSERT [Authors] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'BookId', N'DateTime', N'Title') AND [object_id] = OBJECT_ID(N'[Books]'))
    SET IDENTITY_INSERT [Books] ON;
INSERT INTO [Books] ([BookId], [DateTime], [Title])
VALUES (1, '0001-01-01T00:00:00.0000000', N'Cooking Meth'),
(2, '0001-01-01T00:00:00.0000000', N'Breaking Bad'),
(3, '0001-01-01T00:00:00.0000000', N'DIY');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'BookId', N'DateTime', N'Title') AND [object_id] = OBJECT_ID(N'[Books]'))
    SET IDENTITY_INSERT [Books] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230103092935_thirdmigrationseed', N'7.0.1');
GO

COMMIT;
GO

