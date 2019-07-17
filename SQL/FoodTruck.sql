select
           Tipo,
           TotalVendas,
	      month (DataVenda),
		   (SUM(TotalVendas) )as 'Media mensal',
		month(DataVenda) as 'Mes'
		
from FoodTruck
group by Tipo,TotalVendas,month(DataVenda)
Order by TotalVendas desc