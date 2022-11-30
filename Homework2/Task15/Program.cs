Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n <= 5)
    Console.Write("рабочие будни");
else if(n > 5 && n <= 7)
    Console.Write("Выходной день");
else if(n <= 8)
    Console.Write("В неделе только 7 дней");
