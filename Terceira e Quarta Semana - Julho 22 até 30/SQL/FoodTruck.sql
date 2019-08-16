select
           Tipo,
           TotalVendas,
	      month (DataVenda) as 'MesDeVenda',
		   (SUM(TotalVendas) )as 'Media mensal'
		
		
from FoodTruck
where MONTH(DataVenda) between 7 and 11 --mostra a data somente dentro daquele periodo (posso usa para o ID também)
group by Tipo,TotalVendas,month(DataVenda)
Order by TotalVendas desc