using desafio_b3.Pages;
using System;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace desafio_b3.Steps
{
    [Binding]
    public class ConsultaAlternativaDeRastreamentoStepDefinitions
    {
        LinkPage link;

        public ConsultaAlternativaDeRastreamentoStepDefinitions()
        {
                link= new LinkPage();
        }

    [Given(@"que estou no site de rastreamento de encomendas")]
        public void GivenQueEstouNoSiteDeRastreamentoDeEncomendas()
        {
            link.NavigateToSiteLink();
        }

        [When(@"informar o código de rastreamento")]
        public void WhenInformarOCodigoDeRastreamento()
        {
            link.FillRastreamento("SS987654321BR");
        }

        [When(@"clicar em enviar")]
        public void WhenClicarEmEnviar()
        {
            Thread.Sleep(3000);
            link.ClickRastreamento();
        }

        [Then(@"a página deve retornar a mensagem:")]
        public void ThenAPaginaDeveRetornarAMensagem(string multilineText)
        {
            Assert.That(multilineText, Is.EqualTo(link.ResultRastreamento()));
        }

        [Then(@"fechar o navegador do site")]
        public void ThenFecharONavegadorDoSite()
        {
            link.EndTest();
        }
    }
}
