           //  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 
            Console.WriteLine("Введи 3 числа и мы тебе скажем какое из них больше");

            int a;
            int b;
            int c;

            Console.WriteLine("Введи свое первое число - ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи свое второе число - ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи свое третье число - ");
            c = Convert.ToInt32(Console.ReadLine());
            
            int winner = a;
            string winnerName = "Первое число";

            if (b > winner) {
                winner = b;
                winnerName = "Второе число";
            }
            if (c > winner) {
                winner = c;
                winnerName = "Третье число";
            }

            Console.WriteLine($"Самое большое число - {winnerName} его значение {winner}");
            
        