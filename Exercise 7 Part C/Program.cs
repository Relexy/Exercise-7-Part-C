/* Exercise 7 Part C */

Console.Write("Is Your Triangle A Right Angle?\n");

//User Input
Console.WriteLine("Enter Your Length a: ");
double lengthA = Convert.ToDouble(Console.ReadLine());

while (lengthA <= 0)
{
        Console.WriteLine("ERROR. \nPlease Enter Your Length a: ");
        lengthA = Convert.ToDouble(Console.ReadLine());
}

//User Input
Console.WriteLine("Enter Your Length b: ");
double lengthB = Convert.ToDouble(Console.ReadLine());

while (lengthB <= 0)
{
        Console.WriteLine("ERROR. \nPlease Enter Your Length b: ");
        lengthB = Convert.ToDouble(Console.ReadLine());
}

//User Input
Console.WriteLine("Enter Your Length c: ");
double lengthC = Convert.ToDouble(Console.ReadLine());

while (lengthC <= 0)
{
        Console.WriteLine("ERROR. \nPlease Enter Your Length c: ");
        lengthC = Convert.ToDouble(Console.ReadLine());
}


if (Math.Pow(lengthA, 2) + Math.Pow(lengthB, 2) == Math.Pow(lengthC, 2)) //
{
    Console.WriteLine("Your Triangle Is A Right Angled Triangle!");
}
else if (Math.Pow(lengthB, 2) + Math.Pow(lengthA, 2) == Math.Pow(lengthC, 2))
{
    Console.WriteLine("Your Triangle Is A Right Angled Triangle!");
}
else if (Math.Pow(lengthC, 2) + Math.Pow(lengthB, 2) == Math.Pow(lengthA, 2))
{
    Console.WriteLine("Your Triangle Is A Right Angled Triangle!");
}
else if (Math.Pow(lengthB, 2) + Math.Pow(lengthC, 2) == Math.Pow(lengthA, 2))
{
    Console.WriteLine("Your Triangle Is A Right Angled Triangle!");
}
else if (Math.Pow(lengthA, 2) + Math.Pow(lengthC, 2) == Math.Pow(lengthB, 2))
{
    Console.WriteLine("Your Triangle Is A Right Angled Triangle!");
}
else
{
    Console.WriteLine("Your Triangle Is Not A Right Angled Triangle!");
}

