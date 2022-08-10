VychislitKvadrat ();

void VychislitKvadrat() {
    int numberA = Convert.ToInt32(Console.ReadLine());
    int numberB = Convert.ToInt32(Console.ReadLine());
    if (numberA == numberB * numberB){
        Console.WriteLine("да");
    }
    if (numberB == numberA * numberA) {
        Console.WriteLine("да");
    }
    else {
        Console.WriteLine("нет");
    }  
}
