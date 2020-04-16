CREATE DATABASE Lab3;

USE Lab3;

CREATE TABLE Student(
    StudentID INT,
    StudentName VARCHAR(25),
    GPA FLOAT,
    AGE INT
);

DESCRIBE Student;

INSERT INTO
    Student
VALUES
(--INSERT VALUES WILL BE HERE
);

SELECT
    StudentName,
    AGE
FROM
    Student;

SELECT
    StudentName,
    StudentID
FROM
    Student
WHERE
    GPA > 3;

SELECT
    AVG(GPA)
FROM
    Student
WHERE
    GPA > 2.50;

SELECT
    MAX(AGE)
FROM
    Student;

SELECT
    AV(AGE),
    AV(GPA)
FROM
    Student;

SELECT
    AVG(AGE)
FROM
    Student
WHERE
    StudentName LIKE "M%";

SELECT
    *
FROM
    Student
ORDER BY
    AGE DESC;