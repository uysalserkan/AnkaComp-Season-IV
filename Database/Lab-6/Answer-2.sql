-- ! Question 2
/*  Write  the  query  that  finds  the  amount  of  sale  to  each customer. */

select
    C.name as "Customer Name",
    SUM(QUANTITY) as "Total Order"
from
    customer as C,
    orders as O
WHERE
    C.name = O.name
    Group by C.name;