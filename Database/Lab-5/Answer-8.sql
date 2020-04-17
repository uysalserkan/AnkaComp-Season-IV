-- ! Question 8
/* For all levels except juniors, print the level and 
 the average age of students for that level. */
SELECT
    ST.level,
    AVG(ST.age)
FROM
    student as ST
WHERE
    ST.level != "Junior"
GROUP BY
    ST.level;