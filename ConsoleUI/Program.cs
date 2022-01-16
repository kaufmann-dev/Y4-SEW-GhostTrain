using System;
using System.Collections.Generic;

namespace ConsoleUI {
    class Program {
        static void Main(string[] args) {
            // 1.Schritt: Starten Sie eine Stopwatch zur Zeitmessung.
            
            
            // 2.Schritt: Instanzieren Sie einen WebClient
            
            // 3.Schritt: Für folgende URL sollen mit der Hilfe des Webclients
            //            Daten heruntergeladen werden. Das Herungerladen der
            //            Daten hat parallel mit Tasks zu erfolgen. Rufen Sie
            //            dazu die folgende Methode auf: WebClient->DownloadHTML
            var urls = new List<string>() {
                "http://www.orf.at", "http://www.news.at"
            };
            
            // 4.Schritt: Beenden Sie die Zeitmessung. Geben Sie Daten der Downloads
            //            aus.

        }
    }
}