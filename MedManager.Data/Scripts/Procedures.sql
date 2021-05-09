USE MedDb

GO

CREATE PROCEDURE CheapMedications
AS

SELECT Medications.[Name] AS MedicationTitle, Medications.Cost
FROM dbo.Medications
WHERE Medications.Cost<100

GO

CREATE PROCEDURE prDiagnoses
AS

SELECT [Name], [Group], Id
FROM dbo.Diagnoses

GO

CREATE PROCEDURE EmployeesFromBelarus
AS

SELECT Id, [Name]
FROM dbo.Employees
WHERE Employees.ContactPhone LIKE '375%';

GO

CREATE PROCEDURE CancerDiadnoses
AS

SELECT Id, [Name]
FROM dbo.Diagnoses
WHERE Diagnoses.[Group] LIKE '%cancer%';

GO

CREATE PROCEDURE EmployeesNames
AS

SELECT [Name]
FROM dbo.Employees

GO

CREATE PROCEDURE OldInspections
AS

SELECT *
FROM dbo.Inspections
WHERE Inspections.Date<GETDATE();

GO

CREATE PROCEDURE AdultPatients
AS

SELECT [Patients].BornDate AS AdultBornDate, Patients.[Name] AS AdultName
FROM dbo.Patients
WHERE Patients.BornDate>DATEDIFF(YEAR,  DATEADD(YEAR, -18, '2013-03-13 00:00:00.000'), GETDATE())

GO

CREATE PROCEDURE PateintsFromKutepova
AS

SELECT *
FROM dbo.Patients
WHERE Patients.Address LIKE 'Kutepova'

GO

CREATE PROCEDURE PlotNames
AS

SELECT [Name]
FROM dbo.Plots

GO

CREATE PROCEDURE PositionNames
AS

SELECT Title AS PositionName
FROM dbo.Positions

GO

CREATE PROCEDURE WardNames
AS

SELECT [Name]
FROM dbo.Wards

GO

CREATE PROCEDURE PlannedInspections
AS

SELECT [Date] AS InspectionDate
FROM dbo.Inspections
JOIN InspectionTypes ON InspectionTypes.Id=Inspections.InspectionId;

GO