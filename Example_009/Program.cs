Ostatok();

void Ostatok()
{
    int numberA = Convert.ToInt32(Console.ReadLine());
    int numberB = Convert.ToInt32(Console.ReadLine());

    if (numberB % numberA != 0)
    {
        double ostatok = numberB % numberA;
        Console.WriteLine(ostatok);
    }
}