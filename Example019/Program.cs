bool palindrom;
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int revertedNumber = 0;
    while(number > revertedNumber)
    {
        revertedNumber = revertedNumber * 10 + number % 10;
        number /= 10;
    }
        palindrom = number == revertedNumber || number == revertedNumber/10;
        if(palindrom) {
            Console.WriteLine("является палиндромом");
        } else {
            Console.WriteLine("не является палиндромом");
    }
