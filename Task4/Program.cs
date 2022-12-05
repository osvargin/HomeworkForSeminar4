// Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
// 10 -> 4
// 20 -> 7
// 30 -> 8

Console.Clear();

Console.WriteLine("Введите радиус круга: ");
double r = Convert.ToDouble(Console.ReadLine());

double area = Math.PI * r * r;

int res = Convert.ToInt32(area);
int max = 0;

    while (res > 0)
    {
        max < res % 10;
        max = res % 10;
        res = res / 10;
    }
    Console.WriteLine(res);