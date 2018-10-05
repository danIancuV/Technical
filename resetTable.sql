/****** Script for SelectTopNRows command from SSMS  ******/
use filedb

SELECT TOP (1000) [Id]
      ,[Name]
      ,[FileContent]
      ,[Extension]
  FROM [filedb].[dbo].[SerializedFile]
  
DELETE FROM SerializedFile;
DBCC CHECKIDENT (SerializedFile, RESEED, 0);