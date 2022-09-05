void Stepen()
{
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a;
int i=0;
if (b>1)
{
    while (i < b-1)
    {
        a = a*c;
        i++;
    }
    Console.WriteLine(a);
}
else Console.WriteLine(a);
}
Stepen();
