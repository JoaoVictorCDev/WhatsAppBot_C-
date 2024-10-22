using EasyAutomationFramework;
using org.junit.experimental.theories.@internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppBot
{
    public class WhatsAppSendMessage : Web
    {
        public void SendMessage(string message, string to)
        {
            try
            {
                StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\jaovi\\AppData\\Local\\Google\\Chrome\\User Data");

                Navigate("https://web.whatsapp.com/");

                WaitForLoad();

                var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div[2]/div[2]/div/div/p", to);
                elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

                var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span/div/div[2]/div[1]/div/div[1]/p", message);
                elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);
            }

            catch {
                Console.WriteLine("ERRO DE EXECUÇÃO");
            }

        }
    }
}
