int num1, num2;
string operation;

int result;

Console.WriteLine("Hello, welcome to the calculator program!");

Console.Write("Please enter your first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("What type of operation would you like to do?");
Console.Write("Please enter a for addition, s for subtraction, m for multiplication or d for division: ");

operation = Console.ReadLine()!;

if (operation == "a")
{
    result = num1 + num2;
}
else if (operation == "s")
{
    result = num1 - num2;
}
else if (operation == "m")
{
    result = num1 * num2;
}
else
{
    result = num1 / num2;
}

Console.WriteLine("The result is " + result);
Console.WriteLine("Thank you for using the calculator program!");

Console.ReadLine();