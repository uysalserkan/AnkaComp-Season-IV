-- ! Question 1
/* Write the query that finds the total amount of money earned. */
/*
 select * from customer;
 select * from orders;
 select * from part;
 */
select
    ROUND(SUM(PRICE * QUANTITY)) as "Total Price"
from
    part as P,
    orders as O
where
    P.PARTNUM = O.PARTNUM;