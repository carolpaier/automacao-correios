Feature: Automação de consultas de CEP e rastreamento de encomendas.
		Como usuário do site dos correios
		Eu quero poder validar código de endereçamento postal e rastreamento de encomendas

A short summary of the feature

@tag1
Scenario: consulta cep invalido
	Given que estou na página inicial de busca cep dos correios
	When eu informo um cep invalido e clico para pesquisar
	Then a página irá retornar o texto "Dados não encontrado"

@tag2
Scenario: consulta cep valido
	Given que retorno na página de busca cep dos correios
	When eu digito um cep válido e clico para pesquisar
	Then a página deve retornar o texto "Rua Quinze de Novembro - lado ímpar"

@tag3
Scenario: consulta rastreamento
	Given que estou na página inicial do site dos correios
	When eu informo o código de rastreamento inválido e clico para pesquisar
	And informo o captcha para confirmar a consulta na nova página
	Then o sistema deve retornar a mensagem Objeto não encontrado na base de dados dos Correios
	And fechar o navegador