-- ! Question 2
/* Find the age of the oldest student who is either a History major 
 or enrolled in a course taught by faculty with the id of 45. */
SELECT
    MAX(ST.age)
FROM
    student AS ST,
    enrolled AS EN,
    class AS CL
WHERE
    ST.major = "History"
    or (
        CL.fid = 45
        AND EN.cname = CL.name
        AND EN.snum = ST.snum
    );