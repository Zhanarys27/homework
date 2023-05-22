Console.Clear();


int num = Convert.ToInt32(Console.ReadLine());

if (num /100 > 0)
{
    int i = num;
    while (i > 1000)
    {
        i/=10;
    }

    
    int result = i%10;
    System.Console.WriteLine(result);

    
}
else
System.Console.WriteLine("no");