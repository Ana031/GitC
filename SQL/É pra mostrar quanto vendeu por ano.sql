 select 'Carros' as 'Carros',
 SUM(Temp.Media) as 'Vendas',
 Temp.[Data de Vendas]
 from(select
	    Ano,
		Modelo,
		(SUM([Numero de Vendas]) / COUNT(*)) as 'Media de vendas',
		year([Data da Venda]) as 'Ano'
    from Carros                                     
	GROUP BY Ano,Modelo,year([Data da Venda])) Temp
	group by Temp.[Data de Vendas]
	