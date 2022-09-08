// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.WriteLine ("Введите число");
int num = Convert.ToInt32 (Console.ReadLine());
GetCubeNumber (num);

void GetCubeNumber(int num)

{
    int count = 1;
    while ( count <= Math.Abs (num) )
    {
        Console.WriteLine ( $"cube {count} = {Math.Pow (count, 3)}");
        count ++;
    }

}
GetCubeNumber (num);