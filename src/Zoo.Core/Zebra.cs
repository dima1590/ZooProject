using Zoo.Core.Abstractions;
using Zoo.Core.Enums;

namespace Zoo.Core;

public class Zebra : AnimalBase
{
    public Zebra(long id, string name, int age, double weight, AnimalType kind)
        : base(id, name, age, weight, kind)
    {
    }
    /// <inheritdoc/>
    public override void Feed()
    {
        
    }

    /// <inheritdoc/>
    public override void MakeSound()
    {
        Console.WriteLine("ИГого!");
    }

    /// <inheritdoc/>
    public override void Play()
    {
        
    }

    /// <inheritdoc/>
    public override void Sleep()
    {
       
    }
}
