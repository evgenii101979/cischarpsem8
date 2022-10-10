// Задача 55: Задайте двумерный массив. Напишите программу, 
/*которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.
Исходный массив:		Результат замены:
9 2 3          			9 4 2			
4 2 4          			2 2 6
2 6 7 				        3 4 7*/

Console.Clear();
int arrayRangeMin = -10;
int arrayRangeMax = 10;

Console.WriteLine("Создаем новый массив.");
int rows = UserInput("\nВведите количество строк: ");
int columns = UserInput("Введите количество столбцов: ");

int[,] array = new int[rows, columns];

CreateArray(array);
WriteArray(array);

int[,] arrayTrans = new int[columns, rows];


try
{
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            arrayTrans[i, j] = array[j, i];
        }
    }
    Console.WriteLine("\n Создаем транспонированый массив: \n");

    WriteArray(arrayTrans);
}

catch
{
    Console.WriteLine("\n Невозможно транспонировать массив. \n");
}
