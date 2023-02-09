Feature: Consulta Alternativa de Rastreamento
		Como usuário do site de rastreamento de encomendas
		Eu quero poder  validar um código de rastreamento

@tag1
Scenario: rastreamento alternativo
	Given que estou no site de rastreamento de encomendas
	When informar o código de rastreamento
	And clicar em enviar
	Then a página deve retornar a mensagem:
	"""
	O rastreamento não está disponível no momento:
	
	- Verifique se o código do objeto está correto;
	- O objeto pode demorar até 24 horas (após postagem) para ser rastreado no sistema do Correios.
	"""
	And fechar o navegador do site
	
