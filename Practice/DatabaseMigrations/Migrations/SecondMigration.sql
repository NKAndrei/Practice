BEGIN TRANSACTION;
GO

ALTER TABLE [Books] ADD [DateTime] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230103091038_secondmigration', N'7.0.1');
GO

COMMIT;
GO
