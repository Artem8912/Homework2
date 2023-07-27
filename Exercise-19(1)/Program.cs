Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99999 || a < 10000)
{
    Console.WriteLine("Вы ввели некорректное число");
}
else
{
    bool Palindrome(int number)
    {
        int digit1 = number / 10000;
        int digit2 = number / 1000 - digit1 * 10;
        int digit4 = (number % 100) / 10;
        int digit5 = number % 10;
        return (digit1 == digit5) && (digit2 == digit4);
    }
    bool result = Palindrome(a);
    Console.WriteLine(result ? "Число является палиндромом": "Число не является палиндромом");

}
