-- ! Question 5
/* Find  the  names  of  faculty  members  
 who  teach  in  every  room  in which some class is taught. */
-- Tüm sınıflarda ders veren hocaların adını bul.

SELECT
    DISTINCT FA.fname
from
    faculty AS FA,
    class AS CL
WHERE
    FA.fid = CL.fid
    AND CL.fid IN (
        SELECT
            fid
        FROM
            class
        GROUP BY
            fid
        HAVING
            count(*) > 2
    );