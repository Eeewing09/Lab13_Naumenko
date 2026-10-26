// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("Дата: 20.10.26");
//     Console.WriteLine("0_0");
// }

// void PrintFooter() {
//     Console.WriteLine(">_<");
//     Console.WriteLine("  Конец программы");
//     Console.WriteLine("X_X");
// }
// void PrintStudentCard(string name, int age, string group_n) {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {group_n}");
// }

// PrintStudentCard("Егор", 18, "ИСП-251");
// PrintStudentCard("Валерия", 17, "ИСП-255");

// Задача Б
// void PrintPerson(string name, int age)
// {
//     Console.WriteLine($"Имя: {name}");
//     Console.WriteLine($"Возраст: {age}");
// }
// PrintPerson("Семён", 17);
// PrintPerson("Иван", 18);
// PrintPerson("Леонид", 16);
// // Задача B
// bool IsEven(int number)
// {
//     if (number % 2 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// int testNumber = 2;

// if (IsEven(testNumber))
// {
//     Console.WriteLine($"Число {testNumber} — чётное");
// }
// else
// {
//     Console.WriteLine($"Число {testNumber} — нечётное");
// }
// 2
double CalculateArea(double width, double height)
{
    return width * height;
}
double area = CalculateArea(4, 7);
Console.WriteLine(area);
// 5
double CalculateBmi(double weight, double heightMeters)
{
    return weight / (heightMeters * heightMeters);
}
double w = CalculateBmi(80, 1.8);
Console.WriteLine(w);




