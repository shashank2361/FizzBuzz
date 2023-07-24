// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
IFizzBuzzService fizzBuzzService = new FizzBuzzService();

for (int i = 1; i <= 100; i++)
{
    string result = fizzBuzzService.GetFizzBuzz(i);
    Console.WriteLine(result);
}

Console.ReadLine();