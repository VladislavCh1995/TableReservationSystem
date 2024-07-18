using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tables = { 5, 6, 8, 9, 1, 5, 3, 4 };
            bool isOpen  = true;
            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < tables.Length; i++)
                {
                    Console.WriteLine("За столом " + (i + 1 ) + " свободно " + tables[i] + " мест.");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Система бронирования столиков.");
                Console.WriteLine("\n1 - забронировать место. \n\n2 - выход из программы.");
                Console.WriteLine("Введите номер команды");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userTable, userPlace;
                        Console.WriteLine("За каким столом вы хотите забронировать место? Введите номер.");
                        userTable = (Convert.ToInt32(Console.ReadLine()) - 1);
                        if (tables.Length <= userTable || userTable < 0)
                        {
                            Console.WriteLine("Неправильно введён номер столика.");
                            break;
                        }
                        Console.WriteLine("Сколько мест вы хотите забронировать.");
                        userPlace = Convert.ToInt32(Console.ReadLine());
                        if (tables[userTable] < userPlace || userPlace <= 0)
                        {
                            Console.WriteLine("Недостаточно мест!");
                            break;
                        }

                        tables[userTable] -= userPlace;
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
