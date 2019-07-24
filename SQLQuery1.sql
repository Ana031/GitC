--1--select Nome 'Marcas que Felipe Cadastrou'
--     from Marcas
--	where UsuInc = 1
--
--select Nome 'Marcas que Giomar Cadastrou'
--     from Marcas
--	where UsuInc = 2
--
GO

--2--select count(*) as 'Quantidade de Marcas Felipe'
--     from Marcas
--	where UsuInc = 1
--order by 'Quantidade de Marcas Felipe' desc
--
--select count(*) as 'Quantidade de Marcas Giomar'
--     from Marcas
--	where UsuInc = 2
--order by 'Quantidade de Marcas Giomar' asc

GO

--3--select count(*) as 'Quantidade Ambos'
--     from Marcas
--	where UsuInc = 1 or UsuInc = 2
--order by 'Quantidade Ambos' asc

GO

--4--select Modelo as 'Cadastro de Carros Felipe'
--     from Carros
--	where UsuInc = 1
--
-- select Modelo as 'Cadastro de Carros Giomar'
--     from Carros
--	where UsuInc = 2

GO

--5--select count(*) as 'Quantidade de Carros Felipe'
--     from Carros
--	where UsuInc = 1
--order by 'Quantidade de Carros Felipe' desc
--
--select count(*) as 'Quantidade de Carros Giomar'
--     from Carros
--	where UsuInc = 2
--order by 'Quantidade de Carros Giomar' asc

GO

--6--select count(*) as 'Quantidade de Carros Ambos'
--     from Carros
--	where UsuInc = 1 or UsuInc =2
--

GO

--7--select Carros.Modelo as 'Carros e Marcas Felipe'   --  Eu quero tal coisa da tabela tal
--       											    
--     from Carros                                      --  Tabela que eu quero
--	inner join Marcas on Marcas.Id = Carros.Marca       --  eu quero a tabela marcas 
--	                                                    --  tenho marcas id dentro da tabela carros
--	                                                    --  = vai me retornar o nome da marca dentro da tabela 
--	                                                    --  carro que tem somente o id
--	where Marcas.UsuInc = 1
--
--select Carros.Modelo as 'Carros e Marcas Giomar'
--       
--     from Carros
--	inner join Marcas on Marcas.Id = Carros.Marca
--	where Marcas.UsuInc = 2

GO

--8--select count(Carros.Modelo) as 'Carros e Marcas Felipe'
--       
--     from Carros
--	inner join Marcas on Marcas.Id = Carros.Marca
--	where Marcas.UsuInc = 1
--order by 'Carros e Marcas Felipe' desc
--
--select count(Carros.Modelo) as 'Carros e Marcas Giomar'
--       
--     from Carros
--	inner join Marcas on Marcas.Id = Carros.Marca
--	where Marcas.UsuInc = 2
--order by 'Carros e Marcas Giomar' asc

GO

--9--select 
--	
--	SUM(Quantidade * Valor) as 'Valor Total de Vendas',
--	YEAR (DatInc) as 'Ano'
--	From Vendas
--
--	where YEAR (DatInc) = 2019
--	group by YEAR (DatInc)

GO

--10--select 
--	
--	SUM(Quantidade) as 'Quantidade Total de Vendas',
--	YEAR (DatInc) as 'Ano'
--	From Vendas
--
--	where YEAR (DatInc) = 2019
--	group by YEAR (DatInc)

GO

--11--select 
--	
--	SUM(Quantidade * Valor) as 'Total de Vendas',
--	YEAR (DatInc) as 'Ano'
--	From Vendas
--
--	group by YEAR (DatInc)
--	order by 'Valor Total de Vendas' desc

GO

--12--select 
--	
--	SUM(Quantidade) as 'Quantidade de Vendas',
--	YEAR (DatInc) as 'Ano'
--	From Vendas
--
--	group by YEAR (DatInc)
--	order by 'Quantidade Total de Vendas' desc

GO

--13--select
--	sum(Vendas.Quantidade) as 'Qtde Vendas',
--	month(Vendas.DatInc) as 'Mês',
--	year(Vendas.DatInc) as 'Ano'
--
--from Vendas
--
--group by month(Vendas.DatInc), year(Vendas.DatInc)
--order by 'Mês' desc 

GO

--14--select
--	sum(Vendas.Valor) as 'Valor Vendas',
--	month(Vendas.DatInc) as 'Mês',
--	year(Vendas.DatInc) as 'Ano'
--
--from Vendas
--
--group by month(Vendas.DatInc), year(Vendas.DatInc)
--order by 'Mês' desc 


GO

--15--select
--	sum(Vendas.Valor* Vendas.Quantidade) as 'Valor total de vendas do Felipe'
--from Vendas
--where UsuInc = 1
--
--select
--	sum(Vendas.Valor* Vendas.Quantidade) as 'Valor total de vendas do Giomar'
--from Vendas
--where UsuInc = 2


GO

--16--select
--	sum(Vendas.Quantidade) as 'Qtd total de vendas do Felipe'
--from Vendas
--where UsuInc = 1
--
--select
--	sum(Vendas.Quantidade) as 'Qtd total de vendas do Giomar'
--from Vendas
--where UsuInc = 2

GO 

--17--select
--	sum(Vendas.Quantidade) as 'Qtd total de vendas de Ambos'
--from Vendas
--order by sum(Vendas.Quantidade) desc

GO

--18--select
--	sum(Vendas.Valor) as 'Valor total de vendas de Ambos'
--from Vendas
--order by sum(Vendas.Valor) desc

GO
                                      --  inner join --tabela que eu quero
                                      --  on as duas tabelas que tem FK, que se interligam entre si
                                      --  = de queal ID que eu quero pegar 

--19--select
--      Marcas.Nome as 'Marcas',
--	  SUM(Vendas.Quantidade) as 'Total de Vendas',
--	  YEAR(Vendas.DatInc) as 'Ano'
--
--	  from Vendas 
--	  inner join Carros on Carros.Id = Vendas.Carro
--	  inner join Marcas on Carros.Marca = Marcas.Id
--
--group by YEAR(Vendas.DatInc), Marcas.Nome
--order by 'Total de Vendas' desc

GO

--20--select
--      Marcas.Nome as 'Marcas',
--	  SUM(Vendas.Quantidade*Valor) as 'Total de Vendas',
--	  YEAR(Vendas.DatInc) as 'Ano'
--
--	  from Vendas 
--	  inner join Carros on Carros.Id = Vendas.Carro
--	  inner join Marcas on Carros.Marca = Marcas.Id
--
--group by YEAR(Vendas.DatInc), Marcas.Nome
--

GO

--21--select 
--    Carros.Modelo as 'Carro',
--	SUM(Vendas.Quantidade) as 'Qtd Carros',
--	YEAR(Vendas.DatInc) as 'Ano'
--	
--from Vendas
--    inner join Carros on Carros.Id = Vendas.Carro
--
--group by YEAR(Vendas.DatInc), Carros.Modelo
--order by 'Qtd Carros' desc
     

GO

--22--select 
--    Carros.Modelo as 'Carro',
--	SUM(Vendas.Quantidade*Valor) as 'Valor Carros',
--	YEAR(Vendas.DatInc) as 'Ano'
--	
--from Vendas
--    inner join Carros on Carros.Id = Vendas.Carro
--
--group by YEAR(Vendas.DatInc), Carros.Modelo
--order by 'Valor Carros' desc


