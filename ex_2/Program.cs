Console.Clear();

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int i = 0;
int max =a;

if(max >= b && max >= c)
{
    Console.WriteLine($"max number: {max}");

}
else if(b>= max && b>= c)
{
    max = b;
    Console.WriteLine($"max number: {max}");

}
else
{
    max = c;
    Console.WriteLine($"max number: {max}");
   
}
    

