-- ! Question 3
/* Writethe query that finds the number of parts(for each type)that were sold. */
select DISTINCT
    P.DESCRIPTION,
    P.PARTNUM
FROM
    part as P,
    orders as O
where
    P.PARTNUM = O.PARTNUM;
