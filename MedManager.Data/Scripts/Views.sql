USE MedDb

GO

CREATE VIEW vwCheapMedications
AS

SELECT Medications.[Name] AS MedicationTitle, Medications.Cost
FROM dbo.Medications
WHERE Medications.Cost<100

GO

CREATE VIEW vwDiagnoses
AS

SELECT [Name], [Group], Id
FROM dbo.Diagnoses

GO

CREATE VIEW vwEmployeesFromBelarus
AS

SELECT Id, [Name]
FROM dbo.Employees
WHERE Employees.ContactPhone LIKE '375%';

GO

CREATE VIEW vwCancerDiadnoses
AS

SELECT Id, [Name]
FROM dbo.Diagnoses
WHERE Diagnoses.[Group] LIKE '%cancer%';

GO

CREATE VIEW vwEmployeesNames
AS

SELECT [Name]
FROM dbo.Employees

GO

CREATE VIEW vwOldInspections
AS

SELECT *
FROM dbo.Inspections
WHERE Inspections.Date<GETDATE();

GO

CREATE VIEW vwAdultPatients
AS

SELECT [Patients].BornDate AS AdultBornDate, Patients.[Name] AS AdultName
FROM dbo.Patients
WHERE Patients.BornDate>DATEDIFF(YEAR,  DATEADD(YEAR, -18, '2013-03-13 00:00:00.000'), GETDATE())

GO

CREATE VIEW vwPateintsFromKutepova
AS

SELECT *
FROM dbo.Patients
WHERE Patients.Address LIKE 'Kutepova'

GO

CREATE VIEW vwPlotNames
AS

SELECT [Name]
FROM dbo.Plots

GO

CREATE VIEW vwPositionNames
AS

SELECT Title AS PositionName
FROM dbo.Positions

GO

CREATE VIEW vwWardNames
AS

SELECT [Name]
FROM dbo.Wards

GO

CREATE VIEW vwPlannedInspections
AS

SELECT [Date] AS InspectionDate
FROM dbo.Inspections
JOIN InspectionTypes ON InspectionTypes.Id=Inspections.InspectionId;

GO