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

double result;

if (IsEligibleForBonus(4.7)) {
    result = CalculateScholarship(2000, 15);
} else {
    result = CalculateScholarship(2000, 0);
}

Console.WriteLine(result);



double CalculateScholarship(double baseAmount, double bonusPercent) {
    return baseAmount + baseAmount * bonusPercent / 100;
}

bool IsEligibleForBonus(double averageGrade) {
    return averageGrade >= 4.5;
}

double CalculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}
int CountFives(int[] grades)
{   int c = 0;
    foreach (int i in grades)
    {
        if (i == 5)
        {
            c += 1;
        }
    }
    return c;
}
int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int averages = CountFives(grades);
Console.WriteLine(averages);
Console.WriteLine(average);







