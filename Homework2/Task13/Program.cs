Console.Clear();
Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a < 100)
    Console.WriteLine("третьей цифры нет");
else 
{
    while (a > 1000)
       a = a / 10;

    Console.WriteLine(a % 10);    

}