using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_b3.Pages
{
    public class CorreiosPage
    {
        Page page;

        public string IdBtnBuscarCep = "btn_pesquisar";
        public string IdBtnNovaBusca = "btn_nbusca";
        public string XPathRastreamento = "//*[@id=\'content\']/div[3]/div/div[2]/div[1]/form/div[2]/button/i";
        public string UrlCepCorreios = "https://buscacepinter.correios.com.br/app/endereco/index.php";
        public string UrlCorreios = "https://www.correios.com.br/";
        public string IdFieldCep = "endereco";
        public string IdFieldRastreamento = "objetos";
        public string XPathResult = "//h6";
        public string Css = "#resultado-DNEC > tbody > tr > td:nth-child(1)";

        public CorreiosPage()
        {
            page = new Page();
        }

        public void NavigateToSiteBuscaCep()
        {
            page.NavigateToUrl(UrlCepCorreios);
        }

        public void NavigateToSiteCorreios()
        {
            page.NavigateToUrl(UrlCorreios);
        }
        public void ClickBuscarCep()
        {
            Page.ClickElement(By.Id(IdBtnBuscarCep));
        }

        public void ClickRastreamento()
        {
            Page.ClickElement(By.XPath(XPathRastreamento));
        }

        public void ClickNovaBusca()
        {
            Page.ClickElement(By.Id(IdBtnNovaBusca));
        }
        public void FillCep(string cep)
        {
            page.FillField(By.Id(IdFieldCep), cep);
        }

        public void FillRastreamento(string rastreamento)
        {
            page.FillField(By.Id(IdFieldRastreamento), rastreamento);
        }

        public string ResultSearch()
        {
            return page.GetText(By.XPath(XPathResult));
        }

        public string ReturnSearch()
        {
            return page.GetText(By.CssSelector(Css));
        }

        public void EndTest()
        {
            page.EndTest(); 
        }

        public void Scroll()
        {
            page.Scroll();
        }
    }
}
