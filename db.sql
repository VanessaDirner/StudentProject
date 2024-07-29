create database project;

use project;
CREATE TABLE employee (
    personID UNIQUEIDENTIFIER NOT NULL,
    firstname varchar(25) NOT NULL,
    lastname varchar(25) NOT NULL,
    phonenumber INT,
    email varchar(30) NOT NULL UNIQUE,
    startdate date,
    enddate date,
    active bit, --set default to active
    createdby char(25) NOT NULL,
    createdate DATE NOT NULL,
    modifiedby varchar(25) NOT NULL,
    modifieddate date NOT NULL
    PRIMARY KEY (personID)
);

insert into employee (firstname, lastname, phonenumber, email, startdate, enddate, active)
values ('Joe', 'Smith', 4440942039, 'jsmith@project.ca', 7/22/2024, 8/1/2024, 1)

CREATE TABLE department (
    deptID UNIQUEIDENTIFIER NOT NULL,
    deptname varchar(25) NOT NULL,
    abbreviation varchar(5) NOT NULL UNIQUE,
    createdby char(25) NOT NULL,
    createdate DATE NOT NULL,
    modifiedby varchar(25) NOT NULL,
    modifieddate date NOT NULL
    PRIMARY KEY (deptID)
);

CREATE TABLE assignment (
    assignmentID UNIQUEIDENTIFIER NOT NULL,
    personID UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES employee(personID),
    deptID UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES department(deptID),
    createdby char(25) NOT NULL,
    createdate DATE NOT NULL,
    modifiedby varchar(25) NOT NULL,
    modifieddate date NOT NULL,
    PRIMARY KEY (assignmentID)
);

-- drop table employee;
-- drop table department;

