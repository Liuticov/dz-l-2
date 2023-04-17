
bool CheckNumber(int number)
{
    if (number >= 100 && number <= 999)
    {
        int first = number / 10;
        int second = first % 10;
        Console.WriteLine("Вторая цифра в введенном числе: " + second);
        return true;
    }
    else
    { return false; }
}

Console.WriteLine("Введите трехзначное число : ");
int a = int.Parse(Console.ReadLine());
bool result = CheckNumber(a);
Console.WriteLine(result);
