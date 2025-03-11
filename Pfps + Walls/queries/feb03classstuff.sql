select avg(price*ytd_sales)
from titles
where type = 'business'
or year(pubdate) = 1991
select count(distinct au_id)
from titleauthor 
select state, count(au_id)
from authors
group by state

select country, city, count(pub_id)
from publishers 
where country = 'France'
group by country, city
having country= 'France'
order by 2 desc
