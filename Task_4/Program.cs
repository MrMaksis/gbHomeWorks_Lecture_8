void Show2dArray(int[,,] arr){
    for(int i = 0; i < arr.GetLength(0); i++)
        for(int j = 0; j < arr.GetLength(1); j++)
            for(int k = 0; k < arr.GetLength(2); k++)
                if(k > 2)
                    Console.WriteLine();
                else
                    Console.Write(arr[i,j,k] + $"({i},{j},{k}) \t");            
}

int[,,] CreateRandom3dArray(){
    Console.Write("Input a number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());

	int[,,] arr = new int[rows,rows,rows];

	for(int i = 0; i < rows; i++)
		for(int j = 0; j < rows; j++)
            for(int k = 0; k < rows; k++)
               arr[i,j,k] = new Random().Next(100); 
    return arr;
}

Show2dArray(CreateRandom3dArray());