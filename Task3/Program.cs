// Задача 46: Написать программу масштабирования фигуры

void GetCoordinates(string data, double k)
{
    int coordinate = 0;
    int digit = 0;
    bool isCoordinate = false;
    for (int i = 0; i < data.Length; i++)
    {
        if (Int32.TryParse(data[i].ToString(), out digit))
        {
            coordinate = 10*coordinate + digit;
            isCoordinate = true;   
        }
        else
        {
            if (isCoordinate)
                {
                    Console.Write(coordinate*k);
                    isCoordinate = false;
                    coordinate = 0;
                }
            Console.Write(data[i]);
        }
    }
}

string data = "(100,0) (2,0) (2,20) (0,20)";
Console.WriteLine("Исходные координаты: " + data);
Console.Write("при k = 2 получаем ");
GetCoordinates(data, 2);
Console.WriteLine();
Console.Write("при k = 4 получаем ");
GetCoordinates(data, 4);
Console.WriteLine();
Console.Write("при k = 0.5 получаем ");
GetCoordinates(data, 0.5);
