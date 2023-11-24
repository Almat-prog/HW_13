using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    public class BankSystem
    {
        private BankQueue bankQueue = new BankQueue();
        private int clientIdCounter = 1;

        public void AddClientToQueue()
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Выберите тип обслуживания (например, кредитование, открытие вклада, консультация):");
            string serviceType = Console.ReadLine();

            Client client = new Client(clientIdCounter++, name, serviceType);
            bankQueue.Enqueue(client);
        }

        public void ServeNextClient()
        {
            bankQueue.Dequeue();
        }

        public void DisplayQueue()
        {
            bankQueue.DisplayQueue();
        }
    }

}
