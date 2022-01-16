using System;
using System.Threading;

namespace ConsoleUI {
    public class GhostTrain {

        public void Run() {
            while (true) {
                
                Departe();
                
                
                Arrive();
                
            }
        }

        private void Departe() {
            Console.WriteLine("ghost train: departing");
            Thread.Sleep(100);
        }

        private void Arrive() {
            Thread.Sleep(1000);
            Console.WriteLine("ghost train: ending ride");
        }
        
        
    }
}