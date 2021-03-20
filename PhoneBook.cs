using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Phonebook
{
    class PhoneBook
    {
        private List<PhoneBookRecord> records = new List<PhoneBookRecord>();

        public void AddRecord()
        {
            records.Add(new PhoneBookRecord());
        }

        public void RemoveRecord(int index)
        {
            if (records.Count == 0)
            {
                Console.WriteLine("Нет записей для удаления");
            }
            else
            {
                records.RemoveAt(index);
            }
        }

        public void ChangeRecord(int index)
        {
            records.RemoveAt(index);
            records.Insert(index, new PhoneBookRecord());
        }

        public void FindRecord(int index)
        {
            records[index].Show();
        }

        public void ShowAll()
        {
            foreach (PhoneBookRecord record in records)
                record.Show();
        }

        public void ShowCountOfRecords()
        {
            Console.WriteLine($"Количество записей: {records.Count}");
        }
    }
}
