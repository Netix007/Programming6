// Задача 42: Определить сколько чисел больше 0 введено с клавиатуры


int[] Input()
{
    int[] numbers = new int[10];
    for (int i = 0; i < 10; i++)
    { 
        bool isError = true;
        string text = "";
        while (isError)
        {
            Console.Write($"{i+1}: ");
            text = Console.ReadLine();
            if (Int32.TryParse(text, out numbers[i]))
                isError = false;   
        }
    }
    return numbers;
}

Console.WriteLine("Введите десять целых чисел");
int[] numbers = Input();
int count = 0;
foreach (int item in numbers)
{
    if (item > 0)
        count++;
}
Console.WriteLine($"Вы ввели {count} чисел больше 0");
