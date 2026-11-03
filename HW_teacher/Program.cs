using HW_teacher;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine(">>> Hello, imitation World!");

Teacher pincher = new Teacher();

Console.WriteLine("\n>>> Вкажіть дані про Teacher: ");

Console.WriteLine("Введіть ім'я: ");
pincher.Name = Console.ReadLine();
Console.WriteLine("Введіть телефон: ");
pincher.Phone = Console.ReadLine();
Console.WriteLine("Введіть кафедру: ");
pincher.Department = Console.ReadLine();
Console.WriteLine("Введіть вчене звання: ");
pincher.AcademicTitle = Console.ReadLine();
Console.WriteLine("Введіть стаж роботи: ");
pincher.Experience = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть зарплату: ");
pincher.Salary = double.Parse(Console.ReadLine());

Console.WriteLine(">>> Teacher: " + pincher);