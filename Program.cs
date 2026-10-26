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
void PrintStudentCard(string name, int age, string group_n) {
    Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {group_n}");
}

PrintStudentCard("Егор", 18, "ИСП-251");
PrintStudentCard("Валерия", 17, "ИСП-255");

