/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/
Console.Write("Введите возводимое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень для возведения: ");
int B = int.Parse(Console.ReadLine()!);

int multiplication = 1;
for (int i = 0; i < B; i++)
{
    multiplication *= A;
}
Console.WriteLine(multiplication);