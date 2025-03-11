--select TrackID as 'ndogndogndog', Composer
--	from Track
declare @min int = 6

declare @max int = 7
select LEFT(cast(TrackId as varchar(10))+': ' + Name+' - ' + Coalesce(NULL,'N/A'),100) as 'HE CANT BE GETTING AWAY WITH IT'
from Track
where Milliseconds between 6*60000 and 7*60000
and UnitPrice < 0.69
order by TrackId
		
		
select 'Hello' + ' from' + ' the' + ' other' + ' side'

	
select rtrim(concat('Hello',' from', ' the', ' other', ' side'))

	
--select concatenate('Hello',' from', ' the', ' other', ' side')

	
select concat('Hello',' from', ' the', ' other', ' side')
select CONVERT(varchar(10), GETDATE(),2) as 'ANSI Date'
--select CONVERT(varchar(10),DateName() )
select DateName(year,GetDate())

	
select Year(GetDate())

	
select DateDiff(year,GetDate(),0)

	
select Convert(varchar(15),GetDate(),114)