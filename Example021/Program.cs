Console.Write($"Введите координату x точки A: ");
    int x1 =Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату y точки A: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату z точки A: ");
    int z1 =Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату x точки B: ");
    int x2 =Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату y точки B: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите координату z точки B: ");
    int z2 = Convert.ToInt32(Console.ReadLine());
    
    double Distance(double x1, double x2, 
                    double y1, double y2, 
                    double z1, double z2){
      return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                       Math.Pow((y2-y1), 2) + 
                       Math.Pow((z2-z1), 2));
    }
    double distanceResult =  Math.Round (Distance(x1, x2, y1, y2, z1, z2), 2 );
    Console.WriteLine($"Длина отрезка  {distanceResult}");
