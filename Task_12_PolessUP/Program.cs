string str = "3-598-21507-X";
int sum = 0;
int a = 10;

foreach (char c in str)
{
    if (char.IsDigit(c))
    {
        sum += int.Parse(c.ToString()) * a;
        a--;
    }
    else if (c == 'X' && a == 1) // если последний символ - X и остался только один шаг
    {
        sum += 10;
    }
}

if (sum % 11 == 0)
{
    Console.WriteLine("Правильно");

}
else Console.WriteLine("Nope");