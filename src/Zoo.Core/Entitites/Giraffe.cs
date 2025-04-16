using Zoo.Core.Abstractions;
using Zoo.Core.Enums;

namespace Zoo.Core.Entitites;

public class Giraffe : AnimalBase
{
    public Giraffe(long id, string name, int age, double weight, AnimalType kind)
        : base(id, name, age, weight, kind, settlementDate: DateTime.UtcNow, resettlementDate: DateTime.UtcNow)
    {
    }

    public override void Feed()
    {
        throw new NotImplementedException();
    }

    public override void MakeSound()
    {
        throw new NotImplementedException();
    }

    public override void Play()
    {
        throw new NotImplementedException();
    }

    public override void Sleep()
    {
        throw new NotImplementedException();
    }
}