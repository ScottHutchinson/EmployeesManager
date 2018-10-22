USE [C:\USERS\SCOTT\SOURCE\REPOS\EMPLOYEESMANAGER\EMPLOYEESMANAGER\EMPLOYEESDATABASE.MDF]
GO

DECLARE @RC int
DECLARE @Id int
DECLARE @Name nvarchar(10)
DECLARE @Title nvarchar(9)
DECLARE @Manager int
DECLARE @HireDate date
DECLARE @Salary money
DECLARE @DepartmentId int

-- TODO: Set parameter values here.
SET @Id = 2
SET @Name = N'HARDINGS'
SET @Title = N'BOSS'
SET @Manager = 9
SET @HireDate = N'2008-02-02'
SET @Salary = 75000.00
SET @DepartmentId = 3

EXECUTE @RC = [dbo].[uspEmployeeUpdate] 
   @Id
  ,@Name
  ,@Title
  ,@Manager
  ,@HireDate
  ,@Salary
  ,@DepartmentId
GO

--SELECT @RC AS 'RESULT'
