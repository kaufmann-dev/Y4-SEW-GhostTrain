using System;
using System.Threading;

namespace ConsoleUI {
    public class Customer {
        private static int _counter = 0;

        private int _id;

        public Customer() {
            _id = ++_counter;
            
        }
        
        public void Run() {
            BuyTicket();
            
            EnteringWaitningArea();
            
            EnteringTrain();
            
            LeavingTrain();
        }

        private void BuyTicket() {
            Console.WriteLine($"customer {_id}: Buying Ticket");
            Thread.Sleep(500);
        }

        private void EnteringWaitningArea() {
            Console.WriteLine($"customer {_id}: Entering Waiting Area");
            Thread.Sleep(100);
        }
        
        private void EnteringTrain() {
            Console.WriteLine($"customer {_id}: Entering Ghost Train");
            Thread.Sleep(200);
        }
        
        private void LeavingTrain() {
            Console.WriteLine($"customer {_id}: Leaving Ghost Train");
            Thread.Sleep(300);
        }
    }
}