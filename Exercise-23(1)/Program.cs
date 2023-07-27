Console.WriteLine("Введите число  ");
int a = Convert.ToInt32(Console.ReadLine());

if( a<1)
{
    Console.WriteLine(" Вы ввели некорректное число");
    return;
}
void Cube(int number)
{
    for (int i = 1; i<=number;i++)
    {
    double cube = Math.Pow(i,3);
    Console.WriteLine($"{i,3} {cube,7}" );
    } 
}
Cube(a);
