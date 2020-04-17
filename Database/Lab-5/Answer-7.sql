-- ! Question 7
/* For  each level,  print the  level  and  
the  average  age  of  students for that level. */
-- Her level için leveli ve ortalama yaşını bastır.

SELECT ST.level,AVG(ST.age) FROM student as ST GROUP BY ST.level;