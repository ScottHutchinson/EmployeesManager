USE [C:\USERS\SCOTT\SOURCE\REPOS\EMPLOYEESMANAGER\EMPLOYEESMANAGER\EMPLOYEESDATABASE.MDF]
GO

CREATE OR ALTER PROCEDURE [dbo].[uspEmployeeUpdate]
	  @Id [int]
      ,@Name nvarchar(10)
      ,@Title nvarchar(9)
      ,@Manager int
      ,@HireDate date
      ,@Salary money
      ,@DepartmentId int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [dbo].[Employee]
	   SET [Id] = @Id
		  ,[Name] = @Name
		  ,[Title] = @Title
		  ,[Manager] = @Manager
		  ,[HireDate] = @HireDate
		  ,[Salary] = @Salary
		  ,[DepartmentId] = @DepartmentId
	 WHERE [Id] = @Id
END;
GO
	