USE MedDb

DECLARE EmployeeCursor CURSOR
GLOBAL
SCROLL
KEYSET
TYPE_WARNING
FOR

SELECT Id, Name
FROM dbo.Employees

GO

DECLARE PlotCursor CURSOR
KEYSET
TYPE_WARNING
FOR

SELECT *
FROM dbo.Plots

GO

DECLARE PositionCursor CURSOR
GLOBAL
SCROLL
KEYSET
FOR

SELECT Id, Title 
FROM dbo.Positions

GO

DECLARE WardCursor CURSOR
GLOBAL
SCROLL
KEYSET
TYPE_WARNING
FOR

SELECT *
FROM dbo.Wards

GO

DECLARE InspectionCursor CURSOR
FOR

SELECT Date
FROM dbo.Inspections

GO

DECLARE @name VARCHAR(50) -- database name 
DECLARE @path VARCHAR(256) -- path for backup files 
DECLARE @fileName VARCHAR(256) -- filename for backup 
DECLARE @fileDate VARCHAR(20) -- used for file name 

SET @path = 'C:\Backup\' 

SELECT @fileDate = CONVERT(VARCHAR(20),GETDATE(),112) 

DECLARE db_cursor CURSOR FOR 
SELECT name 
FROM MASTER.dbo.sysdatabases 
WHERE name NOT IN ('master','model','msdb','tempdb') 

OPEN db_cursor  
FETCH NEXT FROM db_cursor INTO @name  

WHILE @@FETCH_STATUS = 0  
BEGIN  
      SET @fileName = @path + @name + '_' + @fileDate + '.BAK' 
      BACKUP DATABASE @name TO DISK = @fileName 

      FETCH NEXT FROM db_cursor INTO @name 
END 

CLOSE db_cursor  
DEALLOCATE db_cursor

GO