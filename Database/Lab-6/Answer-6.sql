-- ! Question 6
/* Write thequery that gives the following output */
/* 
 ORDEREDON - NAME - PARTNUM - QUANTITY 
 2-SEP-96 - TRUE WHEEL - 10 - 1
 */
select
    orderedon,
    name,
    partnum,
    QUANTITY
from
    orders
where
    orderedon = "2-SEP-1996";