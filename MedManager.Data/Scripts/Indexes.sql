USE [MedDb]
GO

CREATE 
INDEX PatientsIndex ON Patients(Id)
GO

CREATE UNIQUE NONCLUSTERED
INDEX EmployeesIndex ON Employees(Id)
GO

CREATE NONCLUSTERED
INDEX DiagnosesIndex ON Diagnoses([Group])
GO

CREATE CLUSTERED
INDEX InspectionsIndex ON Inspections([Date], InspectionsId) 
GO

CREATE NONCLUSTERED 
INDEX MedicationsIndex ON Medications([Name]) 
WHERE Cost > 10
