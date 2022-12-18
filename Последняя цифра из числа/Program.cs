Console.WriteLine("Enter 3-digit number");
if (int.TryParse(Console.ReadLine(),out int n))
        if (n >= 100 && n < 1000)
    {
           int x = n % 10;
           Console.Write($"Last number is {x}");
    }
    else {
        System.Console.WriteLine("NOT A 3-DIGIT NUMBER");
    }
   else
   {
    System.Console.WriteLine("NOT A NUMBER");
   }