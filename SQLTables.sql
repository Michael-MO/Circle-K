use CircleKDB;

CREATE TABLE Employee(
	EmployeeNo		INT(20)        NOT NULL PRIMARY KEY,
	Name			VARCHAR(70),
	Title			VARCHAR(20),
	Address			VARCHAR(70),
	PostalCode		INT(4)         NOT NULL,
	PhoneNo			VARCHAR(15),
	Mail			VARCHAR(255),
	IsActive		BIT            NOT NULL,
	Username		INT(20)        NOT NULL,
	Password		VARCHAR(255)   NOT NULL,
	AccessLevel		VARCHAR(20),

	FOREIGN KEY (PostalCode) REFERENCES City (PostalCode)
);

CREATE TABLE Station(
	StationNo		INT            NOT NULL PRIMARY KEY,
	PhoneNo			VARCHAR(15),
	Address			VARCHAR(70),
	PostalCode		INT(4)         NOT NULL,

	FOREIGN KEY (PostalCode) REFERENCES City (PostalCode)
);

CREATE TABLE Master (
	MasterID		INT            NOT NULL PRIMARY KEY,
	EmployeeNo		INT(20)
	StationNo		INT

	FOREIGN KEY (EmployeeNo) REFERENCES Employee (EmployeeNo)
	FOREIGN KEY (StationNo)  REFERENCES Station (StationNo)
);

CREATE TABLE City (
	PostalCode		INT(4)         NOT NULL PRIMARY KEY,
	City			VARCHAR(40)
);
