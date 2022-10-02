int a = Convert.ToInt32(Console.ReadLine());
int max = 0;
int b;
if (a >= 10 & a <= 99)
{
while (a>0)
	{
		b = a % 10;
		if (b > max) 
        max = b;
		a /= 10;	
	}
Console.WriteLine(max);
}
else 
{
Console.WriteLine("Число не находится в нужном диапазоне"); 
}