use CircleKDB;

CREATE TABLE City (
     PostalCode     INT PRIMARY KEY,
     Name           VARCHAR(40)
);

CREATE TABLE Employee(
     EmployeeNo     INT IDENTITY(1,1) PRIMARY KEY,
     Name           VARCHAR(70),
     Title          VARCHAR(20),
     Address        VARCHAR(70),
     PostalCode     INT NOT NULL,
     PhoneNo        VARCHAR(15),
     Mail           VARCHAR(255),
     IsActive       BIT NOT NULL,
     UserName       INT NOT NULL,
     UserPassword   VARCHAR(255) NOT NULL,
     AccessLevel    VARCHAR(20),

     FOREIGN KEY (PostalCode) REFERENCES City (PostalCode)
);

CREATE TABLE Station(
	 StationNo      INT IDENTITY(1,1) PRIMARY KEY,
     PhoneNo        VARCHAR(15),
     Address        VARCHAR(70),
     PostalCode     INT NOT NULL,

     FOREIGN KEY (PostalCode) REFERENCES City (PostalCode)
);

CREATE TABLE Master (
     MasterID       INT IDENTITY(1,1) PRIMARY KEY,
     EmployeeNo     INT NOT NULL,
     StationNo      INT NOT NULL,

     FOREIGN KEY (EmployeeNo) REFERENCES Employee (EmployeeNo),
     FOREIGN KEY (StationNo)  REFERENCES Station (StationNo)
);