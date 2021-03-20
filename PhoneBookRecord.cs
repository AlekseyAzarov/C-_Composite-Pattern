using System;
using System.Collections.Generic;
using System.Text;

namespace Phonebook
{
    class PhoneBookRecord
    {
        private PersonalData person, phoneNumber, addres;

        public PhoneBookRecord()
        {
            person = new Person();
            phoneNumber = new PhoneNumber();
            addres = new Address();
        }

        public void Show()
        {
            person.Show();
            phoneNumber.Show();
            addres.Show();
        }
    }
}
