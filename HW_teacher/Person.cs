using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HW_teacher
{
    public class Person
    {
        private string _id;
        private string _name;
        private string _phone;
        public Person()
        {
            _id = Guid.NewGuid().ToString(); // унікальний ідентифікатор
            _name = _phone = string.Empty; // ініціалізація порожніми рядками
        }
        public Person(string name, string phone)
            : this() // виклик конструктора за замовчуванням
        {
            //_name = name;
            //_phone = phone;
            Name = name; // використання властивості Name
            Phone = phone; // використання властивості Phone
        }

        public override string ToString()
        {
            string str = $"ID: {_id}\n" +
                $"Name: {_name}\n" +
                $"Phone: {_phone}";
            return str;
        }

        public string Id
        {
            get { return _id; } // тільки для читання
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length < 2)
                    Console.WriteLine("Помилка: ім'я повинно " +
                        "містити не менше 2 символів :(");
                else
                {
                    _name = value;
                }
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                // у програмуванні придумали Regex -
                // регулярні вирази, які дозволяють
                // перевіряти рядки на відповідність
                // певним шаблонам
                string regex = @"^\+?[0-9]{12}$";
                // шаблон для перевірки номера телефону
                // ? - означає, що символ "+" може бути
                // присутнім або відсутнім
                if (!Regex.IsMatch(value, regex))
                    Console.WriteLine("Помилка: телефон" +
                        "вказано неправильно " +
                        "(+38 xxx xxx xx xx) :(");
                else
                {
                    _phone = value;
                }
            }
        }
    }
}
