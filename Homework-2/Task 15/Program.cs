Console.WriteLine("Input number 1-7");
int number = int.Parse(Console.ReadLine()); 
switch (number)
{
    case 1: Console.WriteLine("Not a weekend :C (Monday)"); break;
    case 2: Console.WriteLine("Not a weekend :C (Tuesday)"); break;
    case 3: Console.WriteLine("Not a weekend :C (Wednesday)"); break;
    case 4: Console.WriteLine("Not a weekend :C (Thuresday)"); break;
    case 5: Console.WriteLine("Not a weekend :C (Friday)"); break;
    case 6: Console.WriteLine("it's weekend! (Saturday)"); break;
    case 7: Console.WriteLine("it's weekend! (Sunday)"); break;
    default: Console.WriteLine("It's not a week day"); break;
    }