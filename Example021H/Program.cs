Console.Write($"Введите размерность:");
        int number =Convert.ToInt32(Console.ReadLine());
        int[] intVal = new int[number];
        int[] intVal2 = new int[number];
        double sum = 0;
        for(int i = 0; i < 2; i++){
            for(int j = 0; j < number; j++) {
                if(i == 0){
                    Console.Write($"Введите координату {j} точки A:");
                    intVal[j] = Convert.ToInt32(Console.ReadLine());
                    }
                else{
                    Console.Write($"Введите координату {j} точки B:");
                    intVal2[j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        for(int i = 0; i < number; i++) {
            sum += (intVal[i] - intVal2[i]) * (intVal[i] - intVal2[i]);
        }
        double result = Math.Sqrt(sum);
        Console.Write($"Длина отрезка {result}");
