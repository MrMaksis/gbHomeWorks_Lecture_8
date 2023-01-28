void Show2dArray(int[,] arr){

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i,j] + "\t");
        Console.WriteLine();
    } 
    Console.WriteLine();
}

int[,] CreateRandom2dArray(){

    Console.Write("Input a number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());

	Console.Write("Input a number of columns: ");
	int columns = Convert.ToInt32(Console.ReadLine());

	Console.Write("Input min: ");
	int minValue = Convert.ToInt32(Console.ReadLine());

	Console.Write("Input max: ");
	int maxValue = Convert.ToInt32(Console.ReadLine());

	int[,] arr = new int[rows,columns];

	for(int i = 0; i < rows; i++){
		for(int j = 0; j < columns; j++){
            if(maxValue < minValue){

            }
			arr[i,j] = new Random().Next(minValue,maxValue + 1);
		}
	}
    return arr;
}

void FindMinSummElementArray(int[,] array)
{
    int[] summArray = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++){
            summArray[i] += array[i,j];
        }
    }

    int minSum = summArray[0];
    int minIndex = 0;

    for(int i = 0; i < summArray.Length; i++)
    {
        if(summArray[i] <= minSum){

            minSum = summArray[i];
            minIndex = i;
        }
    }

    Console.WriteLine($"Минимальную сумму чисел имеет {minIndex + 1} строка.");
}

int[,] arr = CreateRandom2dArray();
Show2dArray(arr);
FindMinSummElementArray(arr);