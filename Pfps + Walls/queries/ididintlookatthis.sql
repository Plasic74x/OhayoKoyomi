select title_id 'Title_ID',
 left(title, 50) 'Title',
 coalesce(royalty, 0) 'Royalty',
 Coalesce (price,0) 'Price',
 coalesce(cast(royalty*price/100 as varchar), 'N/A') 'Per Copy Royalty'
 from titles
 where royalty*price/100 <=2
 or royalty* price/100 is null	