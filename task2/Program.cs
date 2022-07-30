Console.WriteLine("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());  
int max = numberA;
if(numberA > numberB)
{max = numberA;
Console.Write ("max = ");
Console.Write (max);
}
else
{
    max = numberB;
    Console.Write ("max = ");
    Console.WriteLine (max);
}
