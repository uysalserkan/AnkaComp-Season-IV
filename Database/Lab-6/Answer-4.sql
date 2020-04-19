-- ! Question 4
/* Write the query that find show much money 
 has been earned by selling mountain bikes. */
select
    ROUND(SUM(PRICE * QUANTITY)) AS "TOTAL EARNED"
from
    part as P,
    orders as O
where
    P.description = "Mountain Bike"
    AND P.PARTNUM = O.PARTNUM;