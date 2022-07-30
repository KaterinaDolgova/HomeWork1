Console.WriteLine("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if(numberB > max)
{
    max = numberB;
}
else
{
    max = numberA;
}
if (numberC > max)
{
    max = numberC; 
}
Console.Write ("max = ");
Console.Write (max);
