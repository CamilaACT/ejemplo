using FactoryMethod;

int ParkAnimalLimit = 10;
GeneratePark();


void GeneratePark()
{
    Console.WriteLine("Generating park!");
    Random r = new Random();
    
    var numAnimals = 0;
    while (numAnimals < ParkAnimalLimit)
    {
        IAnimal animal;
        var rInt = r.Next(0, 2);

        switch (rInt)
        {
            case 0:
                animal = new Cow();
                break;
            case 1:
                animal = new Bird();
                break;
            case 2:
                animal = new Snake();
                break;
            default:
                animal = new Cow();
                break;
        }

        numAnimals++;
        Console.WriteLine(animal.Render());
    }
}
