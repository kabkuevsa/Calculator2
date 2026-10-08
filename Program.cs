Console.WriteLine("Приветствую");
Console.WriteLine("Это калькулятор. Введите любое решение");
Console.Write("Введите решение: ");
string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '+')
    {
        string[] parts = input.Split('+');
        double num1 = double.Parse(parts[0]);
        double num2 = double.Parse(parts[1]);
        double result = num1 + num2;
        Console.WriteLine("Результат: " + result);
        return;
    }
    else if (input[i] == '-')
    {
        string[] parts = input.Split('-');
        double num1 = double.Parse(parts[0]);
        double num2 = double.Parse(parts[1]);
        double result = num1 - num2;
        Console.WriteLine("Результат: " + result);
        return;
    }
    else if (input[i] == '*')
    {
        string[] parts = input.Split('*');
        double num1 = double.Parse(parts[0]);
        double num2 = double.Parse(parts[1]);
        double result = num1 * num2;
        Console.WriteLine("Результат: " + result);
        return;
    }
    else if (input[i] == '/')
    {
        string[] parts = input.Split('/');
        double num1 = double.Parse(parts[0]);
        double num2 = double.Parse(parts[1]);
        if (num2 == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль");
            return;
        }
        double result = num1 / num2;
        Console.WriteLine("Результат: " + result);
        return;
    }
}