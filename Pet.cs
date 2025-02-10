namespace NewWebApp;

// Represents a base class for all pets
// Provides common properties and behaviors that all pets share
public abstract class Pet(string name)
{
    // Gets the name of the pet
    // This is set once during construction and cannot be changed
    public string Name { get; } = name;

    // Makes the pet's characteristic sound
    // Each specific type of pet must implement their own sound
    public abstract string MakeSound();

    // Returns a string representation of the pet
    public override string ToString()
    {
        return $"Pet: {Name} and I am a {GetType().Name} and I say {MakeSound()}";
    }
}

// Represents a cat that makes a "Meow" sound
public class Cat(string name): Pet(name)
{
    public override string MakeSound() => "Meow";
}

// Represents a dog that makes a "Woof" sound
public class Dog(string name): Pet(name)
{
    public override string MakeSound() => "Woof";
}
