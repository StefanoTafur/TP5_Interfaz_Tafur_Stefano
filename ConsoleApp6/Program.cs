interface IAnimal
{
    void AnimalSound();
    void AnimalType();
    void sleep();
}

class Pig : IAnimal
{
    public void AnimalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee weee");
    }

    public void AnimalType()
    {
        Console.WriteLine("The pig is a mammal");
    }

    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}
class Dog : IAnimal
{
    public void AnimalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The dog says: wau");
    }

    public void AnimalType()
    {
        Console.WriteLine("The dog is a mammal");
    }

    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}
class Cat : IAnimal
{
    public void AnimalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The cat says: miau");
    }

    public void AnimalType()
    {
        Console.WriteLine("The cat is a mammal");
    }

    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();  // Create a Pig object
        myPig.AnimalSound();
        myPig.AnimalType();
        myPig.sleep();

        Dog myDog = new Dog();
        myDog.AnimalSound();
        myDog.AnimalType();
        myDog.sleep();

        Cat myCat = new Cat();
        myCat.AnimalSound();
        myCat.AnimalType();
    }
}
