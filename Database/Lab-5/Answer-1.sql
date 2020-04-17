-- ! Answer 1
/* 1. Find the names of all juniors who are enrolled in 
 a class taught by faculty with the id of 45. */
/* Bugra H.'ın verdiği dersleri alan öğrenciler */
SELECT DISTINCT
    ST.sname
FROM
    class AS CL,
    student AS ST,
    enrolled AS EN
WHERE
    CL.fid = 45
    AND EN.cname = CL.name
    AND EN.snum = ST.snum;