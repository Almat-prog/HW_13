using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    public class Client
    {
        public int Id { get; }
        public string Name { get; }
        public string ServiceType { get; }

        public Client(int id, string name, string serviceType)
        {
            Id = id;
            Name = name;
            ServiceType = serviceType;
        }
    }

    public class BankQueue
    {
        private Queue<Client> queue = new Queue<Client>();

        public void Enqueue(Client client)
        {
            queue.Enqueue(client);
            Console.WriteLine($"Клиент {client.Name} добавлен в очередь. Текущая длина очереди: {queue.Count}");
        }

        public Client Dequeue()
        {
            if (queue.Count > 0)
            {
                Client client = queue.Dequeue();
                Console.WriteLine($"Клиент {client.Name} обслужен. Текущая длина очереди: {queue.Count}");
                return client;
            }
            else
            {
                Console.WriteLine("Очередь пуста.");
                return null;
            }
        }

        public void DisplayQueue()
        {
            Console.WriteLine("Текущая очередь:");

            foreach (var client in queue)
            {
                Console.WriteLine($"Клиент {client.Name}, Услуга: {client.ServiceType}");
            }
        }
    }
}
