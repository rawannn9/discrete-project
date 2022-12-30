Console.WriteLine("Please enter the start : ");
int start = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the end : ");
int end = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = start; i <= end; i++)
{
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
            sum++;
    }

    if (sum == 2)
    {
        Console.WriteLine(i);
        sum = 0;

    }

    else
    {
        sum = 0;
        continue;
    }
}



