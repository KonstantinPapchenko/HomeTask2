Console.Clear();
Console.Write("Введите любое число от 1 до 999: ");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a / 100 % 10;
if(a1 > 0)
    Console.Write(a1);
else
    Console.Write("третьей цифры нет");    

