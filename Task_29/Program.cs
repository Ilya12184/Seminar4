/*Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.*/

int[] arr = new int [8] ;

Random rand = new Random();
void PrintArray(int[] array)
{
    for(int i = 0; i<8; i++) 
    {
        arr[i] = rand.Next(1, 101);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);