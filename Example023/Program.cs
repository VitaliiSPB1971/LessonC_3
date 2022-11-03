Console.Write("Введите число: ");
    int cube = Convert.ToInt32(Console.ReadLine());
    int[] arry = new int[cube];
    int counter = 0;
    int length = arry.Length;
    while (counter <  length){
        arry[counter] = Convert.ToInt32(Math.Pow(counter+1, 3));
        counter++;
    }
    int count = arry.Length;
    int index = 0;
    while(index < count){
        Console.Write(arry[index]+ " ");
        index++;
    }
    