/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return result;
}
int[,,] get2DDoubleArray(int x,
                        int y,
                        int z,
                        int start,
                        int finish)
{
    int[,,] array = new int[x,y,z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = new Random().Next(start, finish + 1);
            }
        }
    }
    return array;
}
string PrintArray(int [,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                Console.Write(Array[i,j,k]+"("+i+","+j+","+k+") ");
            }
            Console.WriteLine();
        }
    }
    return "Массив выведен";
}


int x = GetDataFromUser("Введите первое измерение массива");
int y = GetDataFromUser("Введите второе измерение массива");
int z = GetDataFromUser("Введите третье измерение массива");
int[,,] Array = get2DDoubleArray(x, y,z, 1, 15);
Console.Write(PrintArray(Array));

