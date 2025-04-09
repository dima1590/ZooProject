using Zoo.Core.Abstractions;
using Zoo.Core.Enums;

namespace Zoo.Core;

public class Giraffe : AnimalBase
{
    public Giraffe(long id, string name, int age, double weight, AnimalType kind) : base(id, name, age, weight, kind)
    {
    }

    /// <inheritdoc/>
    public override void Feed()
    {
        
    }

    /// <inheritdoc/>
    public override void MakeSound()
    {
        
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
