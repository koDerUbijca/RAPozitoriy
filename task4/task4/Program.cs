using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
//1.створити функцію сей хелоу  
/*void SayHello()
{
    Console.WriteLine("Hello, world"); 
}

SayHello();*/

/*void Greed(string name)
{
    Console.WriteLine("Hello " + name + " XD");
}

//2.Функція повинна:приймати ім'я користувача;виводити повідомлення:Привіт, <ім'я>!

Console.WriteLine("Enter your name");
string name = Console.ReadLine();
Greed(name);*/


//3.Сума двох чисел Створи функцію int Sum(int a, int b) яка: приймає два цілі числа; повертає їх суму; сама нічого не виводить.

/*void Sum(int a, int b)
{
    int sum = a + b;
    Console.WriteLine("The sum is" + sum);
}


Console.WriteLine("Enter the first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
int b = int.Parse(Console.ReadLine());
Sum(a, b);*/

//4.Створи функцію int Max(int a, int b) Функція повинна: приймати два числа; повернути більше з них; якщо числа рівні — повернути будь-яке з них.

/* int Max(int a, int b)
{
    if (a >= b)
    {
        Console.WriteLine("The biggest number is " + a);
        return a;
    }
    else
    {
        Console.WriteLine("The biggest number is " + b);
        return b;
    }
}

Console.WriteLine("Enter the first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
int b = int.Parse(Console.ReadLine());
Max(a,b);*/


//5.Перевірка на парність
//Створи функцію bool IsEven(int number)
//Функція повинна:
//приймати ціле число;
//повертати true, якщо число парне;
//повертати false, якщо непарне. 
//Число парне або Число непарне

/*bool IsEven(int number)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Number " + number + " is even");
        return true;
    }

    else
    {
        Console.WriteLine("Number " + number + " is odd");
        return false;
    }
}

Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine());
IsEven(number);*/




//6. чотири окремі функції користувач вводить два числа і дію якшо ділить на ноль то шоб помилку викидало
/*double Add(double a, double b)
{
    double sum = a + b;
    Console.WriteLine( a + " + " + b + " = " + sum);
    return sum;
}
double Subtract(double a, double b)
{
    double sum = a - b;
    Console.WriteLine(a + " - " + b + " = " + sum);
    return sum;
}
double Multiply(double a, double b)
{
    double sum = a * b;
    Console.WriteLine(a + " * " + b + " = " + sum);
    return sum;
}
double Divide(double a, double b)
{
    double sum = a / b;
    if (b != 0)
    {
        Console.WriteLine(a + " / " + b + " = " + sum);
    }
    else
    {
        Console.WriteLine("Division by zero is not allowed.");
    }
    return sum;
}

Console.WriteLine("Enter number a");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number b");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("What operation do you want to perform? ( + , - , * , / )");
string op = Console.ReadLine();
if (op == "+")
{
    Add(a, b);
}
else if (op == "-")
{
    Subtract(a, b);
}
else if (op == "*")
{
    Multiply(a, b);
}
else if (op == "/")
{
    Divide(a, b);*/


//7.Створити функцію long Factorial(int n) Функція повинна: приймати невід'ємне число; обчислювати факторіал за допомогою циклу; повертати результат

/*long Factorial(int n)
{
    long fact = 1;
    for (int i = 1; i <= n; i++)
    {
        fact *= i;  
    }
    Console.WriteLine (n + "! = " + fact);
    return fact;    
}
Console.WriteLine("Enter the number ");
int n = int.Parse(Console.ReadLine());
Factorial(n); */


//8.Підрахувати кількість голосних букв укр мови в рядку створити функцію int CountVowels(string text)
/*
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
int CountVowels(string text)
{
    char[] vovels = { 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' };
    int count = 0;
    text = text.ToLower();
    foreach (char ch in text)
    {
        if (    .Contains(ch))
        {
            count++;
        }
    }
    Console.WriteLine(count);   
    return count;
}

Console.WriteLine("Введіть речення");
string text = Console.ReadLine();
CountVowels(text); */

//9.Середнє арифметичне масиву Створи функцію double Average(int[] numbers), ввести кількість, ввести елементи масиву, перердати у функцію, вивести середнє арифметичне


double Average(int[] numbers)
{
    int sum = 0;    
    foreach (int number in numbers)
    {
        sum += number;
    }
    sum /= numbers.Length;
    Console.WriteLine("The average of the array is " + sum);
    return sum;
   }

Console.WriteLine("Enter the number of values");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter " + n + " values, press Enter to confirm each value");
int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
Average(numbers);