// Задача 44: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Random randomizer = new Random();
float k1 = randomizer.Next(-100,101);
float k2 = randomizer.Next(-100,101);
float b1 = randomizer.Next(-100,101);;
float b2 = randomizer.Next(-100,101);

if (k1 != k2)
{
    float x = (b1 - b2) / (k2 - k1);
    float y = k1 * x + b1;
    Console.WriteLine($"Прямые, заданные уравнениями: y = {k1} * x + {b1} и y = {k2} * x + {b2}");
    Console.WriteLine($"пересекаются в точке с координатами ({x}; {y})");
}
else {Console.WriteLine($"Прямые, заданные уравнениями: y = {k1} * x + {b1} и y = {k2} * x + {b2} не пересекаются");}

