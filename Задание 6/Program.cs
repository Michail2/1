int N = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;
while(startNumber <= N)
    {
        if(startNumber % 2 ==0)
        Console.Write(startNumber + ", ");
        startNumber ++;
    }