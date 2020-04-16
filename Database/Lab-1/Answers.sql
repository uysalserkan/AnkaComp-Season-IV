CREATE DATABASE Lab1;

USE Lab1;

CREATE TABLE Programs(
    Rank int,
    Name varchar(25),
    Type varchar(25),
    Channel varchar(25),
    Rating float
);

INSERT INTO
    Programs
VALUES
(1, "COLD CASE1", "SERIAL1", "CNBC-E", 8.9),
(2, "COLD CASE2", "SERIAL2", "CNBC-E", 7.9),
(3, "COLD CASE3", "SERIAL1", "CNBC-E", 6.9),
(4, "COLD CASE4", "SERIAL2", "CNBC-E", 5.9),
(5, "COLD CASE5", "SERIAL1", "CNBC-E", 4.9),
(6, "COLD CASE6", "SERIAL1", "CNBC-E", 3.9),
(7, "COLD CASE7", "SERIAL2", "CNBC-E", 2.9),
(8, "COLD CASE8", "SERIAL1", "CNBC-E", 1.9),
(9, "COLD CASE9", "SERIAL"2, "CNBC-E", 12.9);

SELECT * FROM Programs;