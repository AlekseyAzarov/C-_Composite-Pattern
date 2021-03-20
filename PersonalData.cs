using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Phonebook
{
    abstract class PersonalData
    {
        protected string typeOfData;

        public PersonalData(string typeOfData) => this.typeOfData = typeOfData;

        public abstract void Show();
        public abstract void Add(PersonalData data);
        public abstract void Remove(PersonalData data);
    }

    class Person : PersonalData
    {
        [Required, StringLength(50, MinimumLength = 3)]
        private string name;
        [Required, StringLength(50, MinimumLength = 3)]
        private string lastName;
        private string gender;
        [Required, Range(1, 100)]
        private uint age;

        List<PersonalData> personalDatas = new List<PersonalData>();

        public Person() : base("person") => SetData();

        private void SetData()
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            lastName = Console.ReadLine();
            Console.WriteLine("Введите пол");
            gender = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            age = Convert.ToUInt32(Console.ReadLine());
        }

        public override void Show()
        {
            Console.WriteLine("Имя " + name);
            Console.WriteLine("Фамилия " + lastName);
            Console.WriteLine("Пол " + gender);
            Console.WriteLine("Возраст " + age);

            foreach (PersonalData data in personalDatas)
                data.Show();
        }

        public override void Add(PersonalData data) => personalDatas.Add(data);

        public override void Remove(PersonalData data) => personalDatas.Remove(data);
    }

    class PhoneNumber : PersonalData
    {
        [Required]
        private int phoneCode;
        [Required, StringLength(15)]
        private string phone;
        [Required]
        private string provider;

        public PhoneNumber() : base("phone") => SetData();

        private void SetData()
        {
            Console.WriteLine("Введите телефонный код");
            phoneCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите телефон");
            phone = Console.ReadLine();
            Console.WriteLine("Введите оператора связи");
            provider = Console.ReadLine();
        }

        public override void Show()
        {
            Console.WriteLine("Код " + phoneCode);
            Console.WriteLine("Телефон " + phone);
            Console.WriteLine("Оператор " + provider);
        }

        public override void Add(PersonalData data) => throw new NotImplementedException();

        public override void Remove(PersonalData data) => throw new NotImplementedException();
    }

    class Address : PersonalData
    {
        [Required]
        private string country;
        [Required]
        private string city;
        private string street;
        private string house;
        private uint apartment;

        public Address() : base("address") => SetData();

        private void SetData()
        {
            Console.WriteLine("Введите страну");
            country = Console.ReadLine();
            Console.WriteLine("Введите город");
            city = Console.ReadLine();
            Console.WriteLine("Введите улицу");
            street = Console.ReadLine();
            Console.WriteLine("Введите дом");
            house = Console.ReadLine();
            Console.WriteLine("Введите квартиру");
            apartment = Convert.ToUInt32(Console.ReadLine());
        }

        public override void Show()
        {
            Console.WriteLine("Страна " + country);
            Console.WriteLine("Город " + city);
            Console.WriteLine("Улица " + street);
            Console.WriteLine("Дом " + house);
            Console.WriteLine("Квартира " + apartment);
        }

        public override void Add(PersonalData data) => throw new NotImplementedException();

        public override void Remove(PersonalData data) => throw new NotImplementedException();
    }
}
