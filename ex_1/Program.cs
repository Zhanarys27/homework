Console.Clear();

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if(a > b)
{
    max=a;
    min=b;
    Console.WriteLine($"max number: {max}");
    Console.WriteLine($"min number: {min}");
}
else
{
    max=b;
    min=a;
    Console.WriteLine($"max number: {max}");
    Console.WriteLine($"min number: {min}");
}