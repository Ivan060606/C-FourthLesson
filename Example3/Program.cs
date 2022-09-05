// See https://aka.ms/new-console-template for more information
Console.Write("Новый массив: ");
void Random()
{
    int[] array = new int[8];
    Console.Write("[");
    for (int i = 0; i < 7; i++)
        {
            array[i]=new Random().Next(1, 100);
            Console.Write($"{array[i]}, ");
        }
    array[7]=new Random().Next(1, 100);
    Console.WriteLine($"{array[7]}]");
}
Random();