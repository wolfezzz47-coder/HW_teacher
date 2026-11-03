using System;
using System.Collections.Generic;
using System.Text;

namespace HW_teacher
{
    public class Teacher : Person
    {
        private string _department;     // Кафедра
        private string _academicTitle;  // Вчене звання (доцент, професор)
        private int _experience;     // Стаж роботи (років)
        private double _salary;         // Зарплата

        public Teacher() : base()
        {
            _department = string.Empty;
            _academicTitle = string.Empty;
            _experience = 0;
            _salary = 0.0;
        }

        public Teacher(string name, string phone, 
            string department, string academicTitle, 
            int experience, double salary)
            : base(name, phone)
        {
            _department = department;
            _academicTitle = academicTitle;
            _experience = experience;
            _salary = salary;
        }

        public override string ToString()
        {
            string str = base.ToString();
            str += "\n";
            str += $"Department: {_department}\n";
            str += $"Academic Title: {_academicTitle}\n";
            str += $"Experience: {_experience} years\n";
            str += $"Salary: {_salary:C}";
            return str;
        }

        public string Department
        {
            get { return _department; }
            set {
                if (value.Length < 2)
                    Console.WriteLine("Помилка: Кафедра повинна " +
                        "містити не менше 2 символів :(");
                else
                {
                    _department = value;
                }                    
            }
        }

        public string AcademicTitle
        {
            get { return _academicTitle; }
            set
            {
                if (value.Length < 2)
                    Console.WriteLine("Помилка: Вчене звання повинно " +
                        "містити не менше 2 символів " +
                        "(доцент, професор) :(");
                else
                {
                    _academicTitle = value;
                }
            }
        }

        public int Experience
        {
            get { return _experience; }
            set
            {
                if (value < 0 || value > 100)
                    Console.WriteLine("Помилка: Стаж роботи не може " +
                        "бути від'ємним або більшим за 100 років :(");
                else
                {
                    _experience = value;
                }
            }
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Помилка: Зарплата не може " +
                        "бути як у дрища :(");
                else
                {
                    _salary = value;
                }
            }
        }


    }
}
