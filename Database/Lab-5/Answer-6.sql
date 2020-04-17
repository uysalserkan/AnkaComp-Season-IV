-- ! Question 6
/* Find the  names  of  faculty  members  for  
 whom  the  combined enrollment of the courses that they teach is less than five. */
-- 5 Öğrenciden az kişiye ders veren hocaların adını bul.

SELECT
    DISTINCT FA.fname
FROM
    faculty AS FA,
    enrolled AS EN,
    class AS CL
WHERE
    FA.fid in (
        SELECT
            distinct CL.fid
        FROM
            enrolled,
            class as CL
        WHERE
            enrolled.cname = CL.name
        GROUP BY
            CL.fid
        HAVING
            count(*) < 5
    );