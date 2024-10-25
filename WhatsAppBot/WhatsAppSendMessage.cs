using EasyAutomationFramework;
using org.junit.experimental.theories.@internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WhatsAppBot
{
    public class WhatsAppSendMessage : Web
    {
        public void SendMessage(string message, string to)
        {
            try
            {
                //Colocar o caminho do cach do seu chrome para abrir no local certo
                StartBrowser(TypeDriver.GoogleChorme, "local");

                //URL do whatsApp
                Navigate("https://web.whatsapp.com/");

                //Necessário para aguardar o carregamento
                WaitForLoad();

                var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div[2]/div[2]/div/div/p", to);
                elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

                var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span/div/div[2]/div[1]/div/div[1]/p", message);
                elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);
            }

            catch
            {
                // Configura o processo para abrir o cmd e executar o comando de eco
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";   // Define que o cmd será aberto
                psi.Arguments = "/c echo Estou aqui";  // O argumento /c executa o comando e fecha
                psi.WindowStyle = ProcessWindowStyle.Normal;  // Define para abrir a janela normalmente
                // Inicia o processo
                Process.Start(psi);
                //Console.WriteLine($"ERRO: {ex.Message}");
            }

        }
    }
}
