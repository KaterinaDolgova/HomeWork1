Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.Write (number);
    Console.Write (" - четное");
}
else
{
     Console.Write (number);
    Console.Write (" - не четное");
}
