// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

//1, 2, 3 
//4, 6, 1 
//2, 1, 6
//1 встречается 3 раза 
//2 встречается 2 раз 
//3 встречается 1 раз 
//4 встречается 1 раз 
//6 встречается 2 раза


// 
void SortArray(int[,] arr_l)
{
    int row_l = arr_l.GetLength(0);
    int col_l = arr_l.GetLength(1);
    int[] arr_1d = new int[row_l * col_l];
    int index = 0;

    for (int i = 0; i < row_l; i++)
    {
        for (int j = 0; j < col_l; j++)
        {
            arr_1d[index] = arr_l[i, j];
            index++;
        }
    }
    int[,] FillArrayRandom(int rows, int columns, int min, int max)
    {
        int[,] filledArray = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    }

    void PrintData(int[] inArray)
    {
        int el = inArray[0];
        int count = 1;
        for (int i = 1; i < inArray.Length; i++)
        {
            if (inArray[i] != el)
            {
                WriteLine($"{el} встречается {count}");
                el = inArray[i];
                count = 1;
            }
            else
            {
                count++;
            }
        }
        WriteLine($"{el} встречается {count}");
    }
    void SortArray(int[,] arr_l)
    {
        int row_l = arr_l.GetLength(0);
        int col_l = arr_l.GetLength(1);
        int[] arr_1d = new int[row_l * col_l];
        int index = 0;

        for (int i = 0; i < row_l; i++)
        {
            for (int j = 0; j < col_l; j++)
            {
                arr_1d[index] = arr_l[i, j];
                index++;
            }
        }
        Array.Sort(arr_1d);
        Console.WriteLine(string.Join(", ", arr_1d));

        PrintData(arr_1d);

    }
}
