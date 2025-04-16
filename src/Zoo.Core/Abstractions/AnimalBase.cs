using Zoo.Core.Abstractions.Interfaces;
using Zoo.Core.Enums;

namespace  Zoo.Core.Abstractions;

public abstract class AnimalBase : IAnimal
{
    protected long Id { get; set; }
    protected string Name { get; set; }
    protected int Age { get; set; }
    protected double Weight { get; set; }
    protected bool IsHungry { get; } 
    protected bool IsSleeping { get; }
    protected AnimalType Kind { get; }

    /// <summary>
    /// Дата заселения в вольер 
    /// </summary>
    protected DateTime SettlementDate { get; set; }

    /// <summary>
    /// Дата переселения в вольер 
    /// </summary>
    protected DateTime ResettlementDate { get; set; }

    public AnimalBase (long id, string name, int age, double weight, AnimalType kind, DateTime settlementDate, DateTime resettlementDate)
    {
        Id = id;
        Name = name;
        Age = age;
        Weight = weight;    
        IsHungry = true;
        IsSleeping = false;
        Kind = kind;
        SettlementDate = settlementDate;
        ResettlementDate = resettlementDate;
    }

    /// <inheritdoc/>
    public abstract void Feed();

    /// <inheritdoc/>
    public abstract void MakeSound();

    /// <inheritdoc/>
    public abstract void Play();

    /// <inheritdoc/>
    public abstract void Sleep();
}