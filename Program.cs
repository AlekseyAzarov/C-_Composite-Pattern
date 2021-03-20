using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            PhoneBook book = new PhoneBook();

            menu.StartMenu(book);
        }
    }
}
