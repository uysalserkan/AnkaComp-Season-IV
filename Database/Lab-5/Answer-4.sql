-- ! Question 4
/* Find the names of all students who are enrolled in 
 two classes that meet at the same time. */
-- 2 Öğrenci eğer aynı anda 2 sınıfta da karşılaşırsa bunları bastır.

SELECT
    ST.sname
FROM
    student AS ST
WHERE
    ST.snum IN (
        SELECT
            EN.snum
        FROM
            enrolled AS EN
        WHERE
            EN.cname IN (
                SELECT
                    CL.name
                FROM
                    class AS CL
                where
                    CL.meetsat =(
                        SELECT
                            CL.meetsat
                        FROM
                            class AS CL
                        GROUP BY
                            CL.meetsat
                        HAVING
                            count(CL.meetsat) = 2
                    )
            )
        GROUP BY
            EN.snum
        HAVING
            count(EN.snum) > 1
    );