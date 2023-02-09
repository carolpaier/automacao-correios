using desafio_b3.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace desafio_b3.Steps
{
    [Binding]
    public class AutomacaoDeConsultasDeCEPERastreamentoDeEncomendas_StepDefinitions
    {
        CorreiosPage correios;

        public AutomacaoDeConsultasDeCEPERastreamentoDeEncomendas_StepDefinitions()
        {
                correios= new CorreiosPage();
        }

        [Given(@"que estou na página inicial de busca cep dos correios")]
        public void GivenQueEstouNaPaginaInicialDeBuscaCepDosCorreios()
        {
            correios.NavigateToSiteBuscaCep();
        }

        [When(@"eu informo um cep invalido e clico para pesquisar")]
        public void WhenEuInformoUmCepInvalidoEClicoParaPesquisar()
        {
            correios.FillCep("80700000");
            correios.ClickBuscarCep();
        }

        [Then(@"a página irá retornar o texto ""(.*)""")]
        public void ThenAPaginaIraRetornarOTexto(string text)
        {
            Thread.Sleep(5000);
            Assert.That(text, Is.EqualTo(correios.ResultSearch()));
            correios.EndTest();
        }

        [Given(@"que retorno na página de busca cep dos correios")]
        public void GivenQueRetornoNaPaginaDeBuscaCepDosCorreios()
        {
            correios.NavigateToSiteBuscaCep();
        }

        [When(@"eu digito um cep válido e clico para pesquisar")]
        public void WhenEuDigitoUmCepValidoEClicoParaPesquisar()
        {
            correios.FillCep("01013001");
            correios.ClickBuscarCep();
        }

        [Then(@"a página deve retornar o texto ""(.*)""")]
        public void ThenAPaginaDeveRetornarOTexto(string text)
        {
            Thread.Sleep(5000);
            Assert.That(text, Is.EqualTo(correios.ReturnSearch()));
            correios.EndTest();
        }

        [Given(@"que estou na página inicial do site dos correios")]
        public void GivenQueEstouNaPaginaInicialDoSiteDosCorreios()
        {
            correios.NavigateToSiteCorreios();
            
        }

        [When(@"eu informo o código de rastreamento inválido e clico para pesquisar")]
        public void WhenEuInformoOCodigoDeRastreamentoInvalidoEClicoParaPesquisar()
        {
            correios.FillRastreamento("SS987654321BR");
            correios.Scroll();
            correios.ClickRastreamento();
        }

        [When(@"informo o captcha para confirmar a consulta na nova página")]
        public void WhenInformoOCaptchaParaConfirmarAConsultaNaNovaPagina()
        {
            //estudando uma forma de confirmar o captcha
        }

        [Then(@"o sistema deve retornar a mensagem Objeto não encontrado na base de dados dos Correios")]
        public void ThenOSistemaDeveRetornarAMensagemObjetoNaoEncontradoNaBaseDeDadosDosCorreios()
        {
            //devido a falta de confirmação do captcha não é possível realizar esta etapa do teste
        }

        [Then(@"fechar o navegador")]
        public void ThenFecharONavegador()
        {
            correios.EndTest();
        }
    }
}
