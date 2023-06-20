int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите целое положительное число >");
int x =1;

while( x<=number)
{
    int res =x*x*x;
    x++;
    Console.WriteLine(res);
}
