using System;
using System.Collections.Generic;
using System.Text;

namespace Phonebook
{
    class Menu
    {
        public void StartMenu(PhoneBook phoneBook)
        {
            int ans = 0;

            while (ans != 7)
            {
                Console.WriteLine("Меню\n" 
                    + "1. Добавить запись\n"
                    + "2. Удалить запись\n"
                    + "3. Изменить запись\n"
                    + "4. Поиск записи\n"
                    + "5. Вывод на экран\n"
                    + "6. Вывод количества записей\n"
                    + "7. Выход\n");

                ans = Convert.ToInt32(Console.ReadLine());

                switch (ans)
                {
                    case 1:
                        phoneBook.AddRecord();
                        break;
                    case 2:
                        Console.WriteLine("Выберите индекс записи для удаления");
                        int localAns = Convert.ToInt32(Console.ReadLine());
                        phoneBook.RemoveRecord(localAns);
                        break;
                    case 3:
                        Console.WriteLine("Выберите индекс записи для изменения");
                        int localAns2 = Convert.ToInt32(Console.ReadLine());
                        phoneBook.ChangeRecord(localAns2);
                        break;
                    case 4:
                        Console.WriteLine("Выберите индекс записи для поиска");
                        int localAns3 = Convert.ToInt32(Console.ReadLine());
                        phoneBook.FindRecord(localAns3);
                        break;
                    case 5:
                        phoneBook.ShowAll();
                        break;
                    case 6:
                        phoneBook.ShowCountOfRecords();
                        break;
                }
            }
        }
    }
}
