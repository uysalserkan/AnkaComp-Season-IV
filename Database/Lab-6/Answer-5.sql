-- ! Question 5
/* Write thequery that gives the following output */

/* 
 (14 x 4)
 NAME - Adress - Total - Describtion
 AAA Bike - 10 Oldtown - 213.50 - tires
 */
select
    O.name as "Customer Name",
    C.address as "Customer Address",
    ROUND(PRICE * QUANTITY) as "Total",
    P.DESCRIPTION as "Describtion"
from
    orders as O,
    customer as C,
    part as P
where
    O.name = C.name
    and P.partnum = O.partnum
order by C.name ASC;