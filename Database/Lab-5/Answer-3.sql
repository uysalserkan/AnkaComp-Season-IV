-- ! Answer 3
/* Find  the  names  of  all  classes  that  either  meet  in  room  R128  
 or have three or more students enrolled. */
-- Dersi R128 de olan veya 3 veya daha falza öğrencisi bulunan dersler
SELECT
    DISTINCT CL.name
FROM
    class AS CL,
    faculty as FL,
    enrolled as EN
WHERE
    CL.room = "R128"
    OR CL.name IN(
        select
            distinct cname
        from
            enrolled
        group by
            cname
        having
            count(*) >= 3
    );
