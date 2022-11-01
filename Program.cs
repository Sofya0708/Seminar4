/*Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до (А)


Console.WriteLine("Введи число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {a} = {GetSum(a)}");

int GetSum (int limit){
    int sum = 0;
    for (int i = 0; i <= limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}*/

/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в числе {CountNumber(number)}");

int CountNumber(int number){
    int count = 1;
do
{
    number = number / 10;
    count++;
} while (number > 10);
return count;
}*/

//Напишите программу, которая принимает на вход число (n) и выдает произведение чисел от 1 до (n)
/*
Console.WriteLine("Введи число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел от 1 до {n} = {MultiplyN(n)}");

int MultiplyN(int limit)
{
    int result = 1;
    for (int i = 1; i <= limit; i++)
    {
        result = result * i;
    }
    return result;
}*/

//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

/*int[] arr = new int[8];
FillArray(arr.Length);
Console.WriteLine(String.Join(",", arr));

void FillArray(int size)
{

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0,2); 
    }
}*/







// ДОМАШНЕЕ ЗАДАНИЕ ------------------------------------------------------------------------------------------------------







//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{GetPower(b)} это {a} в степени {b}");

int GetPower (int b) {
int result = 1;
for(int i = 1; i <= b; i++){
result = result * a; 
}
return result; 
}*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{GetSum(a)} это сумма цифр в числе {a}"); 

int GetSum(int a){
    int sum = 0;
do
{
  sum = sum + a % 10;
  a = a / 10;
} while (a > 0);
return sum;
}*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*int[] arr = new int[8];
FillArray(arr.Length);
Console.WriteLine(String.Join(",", arr));

void FillArray(int size)
{

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0,77); 
    }
}*/
