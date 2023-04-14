// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int CheckNumber(int test)
{
    if (test < 0)
    {
        return test * -1;

    }
    else
    { return test; }
}
bool CheckLength(int length)
{
    if (length > 2)
    {
        return true;
    }
    else
    { return false; }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

number = CheckNumber(number);

string number_in_text = number.ToString();

bool more_than_two_symbols = CheckLength(number_in_text.Length);

if (more_than_two_symbols == true)
{
    Console.WriteLine("Третья цифра в введенной цифре: " + number_in_text[2]);
}
else
    Console.WriteLine(" => Третьей цифры нет");

