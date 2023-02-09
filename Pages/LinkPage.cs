using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_b3.Pages
{
    public class LinkPage
    {
        Page page;

        public string UrlLinkCorreios = "https://www.linkcorreios.com.br/";
        public string IdFieldRastreamento = "id";
        public string XPathRastreamento = "//*[@id=\'page\']/main/section/div/div/form/div/div[2]/input";
        public string Resultado = "//*[@id=\'page\']/main/div[4]/div/div/p";

        public LinkPage()
        {
            page = new Page();
        }

        public void NavigateToSiteLink()
        {
            page.NavigateToUrl(UrlLinkCorreios);
        }

        public void FillRastreamento(string rastreamento)
        {
            page.FillField(By.Id(IdFieldRastreamento), rastreamento);
        }

        public void ClickRastreamento()
        {
            Page.ClickElement(By.XPath(XPathRastreamento));
        }

        public string ResultRastreamento()
        {
            return page.GetText(By.XPath(Resultado));
         }

        public void EndTest()
        {
            page.EndTest();
        }
    }
}
