/*//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
bool CheckPal(string input)
{
    int length = input.Length;
    for (int i = 0; i < length / 2; i++)
    {
        if (input[i] != input[length - i - 1])
        {
            return false;
        }
    }
    return true;
}
Console.Write("Введите число: ");
string input = Console.ReadLine();
{
    bool isPalindrome = CheckPal(input);

    if (isPalindrome)
    {
        Console.WriteLine("Число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом.");
    }
}
*/
//Задача 21
/*//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
double Distance (int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    return Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1));
}
Console.Write("Введите Х1: ");
int X1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y1: ");
int Y1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z1: ");
int Z1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Х2: ");
int X2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y2: ");
int Y2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z2: ");
int Z2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Round(Distance(X1,Y1,Z1,X2,Y2,Z2),2));
*/
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
void CubeNumber(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"Куб {num}={Math.Pow(i, 3)}");
    }
}
Console.Write("Введите целое число ");
int n = Convert.ToInt32(Console.ReadLine());
CubeNumber(n);