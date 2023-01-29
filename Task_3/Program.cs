void Show2dArray(int[,] arr){

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i,j] + "\t");
        Console.WriteLine();
    } 
    Console.WriteLine();
}

int[,] CreateRandom2dArray_One(){

    Console.Write("Input a number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());

	int[,] arr = new int[rows,rows];

	for(int i = 0; i < rows; i++){
		for(int j = 0; j < rows; j++){
			arr[i,j] = new Random().Next(0,10);
		}
	}
    return arr;
}

int[,] CreateRandom2dArray_Two(){

    Console.Write("Input a number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
	int columns = Convert.ToInt32(Console.ReadLine());

	int[,] arr = new int[rows,columns];

	for(int i = 0; i < rows; i++){
		for(int j = 0; j < columns; j++){
			arr[i,j] = new Random().Next(0,99);
		}
	}
    return arr;
}

int[,] MultiplyMatrices(int[,] array1,int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}

int[,] array1 = CreateRandom2dArray_One();
int[,] array2 = CreateRandom2dArray_Two();

Show2dArray(array1);
Show2dArray(array2);

Show2dArray(MultiplyMatrices(array1,array2));



