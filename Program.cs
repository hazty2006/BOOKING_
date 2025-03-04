// Invoking a method that takes three numbers as input and returns the sum of the three numbers
Console.WriteLine("Enter your first number");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your second number");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your third number");
int num3 = int.Parse(Console.ReadLine());

int result = AddThreeNumbers(num1, num2, num3);
Console.WriteLine($"The sum of {num1}, {num2} and {num3} is {result}");


// Method of Adding three numbers
int AddThreeNumbers(int a, int b, int c)
{
    // Return the sum of the three numbers
    return a + b + c;
}