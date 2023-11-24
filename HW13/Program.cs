using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    class Program
    {
        static void Main()
        {
            BankSystem bankSystem = new BankSystem();

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Встать в очередь");
                Console.WriteLine("2. Обслужить следующего клиента");
                Console.WriteLine("3. Показать текущую очередь");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bankSystem.AddClientToQueue();
                        break;
                    case 2:
                        bankSystem.ServeNextClient();
                        break;
                    case 3:
                        bankSystem.DisplayQueue();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
    }

}
