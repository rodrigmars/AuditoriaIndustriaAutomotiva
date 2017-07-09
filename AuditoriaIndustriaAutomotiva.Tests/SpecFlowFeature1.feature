Funcionalidade: Valida um total de aço consumido

@mytag
Cenário: SimulaConsumoDeAço
	Dado que a fábrica recebe 50 lotes de aço para consumo diário
	E foram cosnumidos 10% destes lotes na data 15/05/2017
	Quando a fábrica for validar a quantidade de aço usado nesta data
	Então á quantidade esperada será de 5 lotes consumidos
