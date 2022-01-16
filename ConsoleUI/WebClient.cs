using System.Threading;

namespace ConsoleUI {
    public class WebClient {

        // Die Methode braucht nicht adaptiert zu werden
        // Bei Wunsch ist es möglich die Methode für 
        // asyncronen Zugriff zu adaptieren
        public string DownloadHTML(string url) {
            Thread.Sleep(500);
            return $"webclient: {url} downloading data ... ";
        }
        
        
    }
}