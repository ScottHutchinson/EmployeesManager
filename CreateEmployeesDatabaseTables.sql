-- Department table.
create table Department (
	Id int primary key,
	Name nvarchar(14),
	Location nvarchar(13)
)

-- Employee Table
create table Employee (
	Id int primary key,
	[Name] nvarchar(10),
	Title nvarchar(9),
	Manager int null,
	HireDate date,
	Salary money,
	DepartmentId int FOREIGN KEY REFERENCES Department(Id)
)

CREATE INDEX [IX_DepartmentId] ON [Employee]([DepartmentId])

insert into Department values
	(1, 'ACCOUNTING','LOS ANGELES'),
	(2, 'RESEARCH','NEW YORK'),
	(3, 'SALES','ATLANTA'),
	(4, 'OPERATIONS','SEATTLE')

insert into Employee values
	(1,'JOHNSON','ADMIN',6,'12-17-2000',18000,4),
	(2,'HARDING','MANAGER',9,'02-02-2008',52000,3),
	(3,'TAFT','SALES I',2,'01-02-2006',25000,3),
	(4,'HOOVER','SALES I',2,'04-02-2000',27000,3),
	(5,'LINCOLN','TECH',6,'06-23-2004',22500,4),
	(6,'GARFIELD','MANAGER',9,'05-01-2003',54000,4),
	(7,'POLK','TECH',6,'09-22-2007',25000,4),
	(8,'GRANT','ENGINEER',10,'03-30-2007',32000,2),
	(9,'JACKSON','CEO',NULL,'01-01-2000',75000,4),
	(10,'FILLMORE','MANAGER',9,'08-09-2004',56000,2),
	(11,'ADAMS','ENGINEER',10,'03-15-2006',34000,2),
	(12,'WASHINGTON','ADMIN',6,'04-16-2008',18000,4),
	(13,'MONROE','ENGINEER',10,'12-03-2010',30000,2),
	(14,'ROOSEVELT','CPA',9,'10-12-2015',35000,1),
	(15,'HAMMOND','ENGINEER',10,'11-11-2016',45000,1)
