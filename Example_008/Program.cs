GetMaxNumberRandomValue();


void GetMaxNumberRandomValue()
{
    int randomValue = new Random().Next(100, 1000);

    Console.WriteLine($"Random value - {randomValue}");

    int lastNumber = randomValue % 10;
    int firstNumber = randomValue / 100;
    Console.WriteLine($"{firstNumber}{lastNumber}");
}