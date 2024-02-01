CREATE TABLE Employee(
	EmployeeId INT NOT NULL,
	FirstName NVARCHAR(100),
	LastName NVARCHAR(100),
	Salary INT
	PRIMARY KEY(EmployeeId)
	)

INSERT INTO Employee VALUES
('10','Employee1','E1Lastname','500000'),
('11','Employee2','E2Lastname','700000'),
('12','Employee3','E3Lastname','300000'),
('13','Employee4','E4Lastname','500000'),
('14','Employee5','E5Lastname','400000');

SELECT * FROM Employee;

SELECT COUNT(*) FROM Employee;