using Zoo.Core.Abstractions.Interfaces;
using Zoo.Core.Enums;

namespace  Zoo.Core.Abstractions;

public abstract class AnimalBase : IAnimal
{
    long Id { get; set; }
    string Name { get; set; }
    int Age { get; set; }
    double Weight { get; set; }
    bool IsHungry { get; }
    bool IsSleeping { get; }
    AnimalType Kind { get; }
    public AnimalBase(long id,  string name, int age, double weight, AnimalType kind)
    {
        Id = id;
        Name = name;
        Age = age;
        Weight = weight;    
        IsHungry = true;
        IsSleeping = false;
        AnimalType Kind = kind;
    }
    /// <summary>
    /// Дата заселения в вольер 
    /// </summary>
    DateTime SettlementDate { get; set; }

    /// <summary>
    /// Дата переселения в вольер 
    /// </summary>
    DateTime ResettlementDate { get; set; }

    /// <summary>
    /// Покормить животное 
    /// </summary>
    public abstract void Feed();

    /// <summary>
    /// Подать голос
    /// </summary>
    public abstract void MakeSound();

    /// <summary>
    /// Поиграть с животным 
    /// </summary>
    public abstract void Play();

    /// <summary>
    /// Уложить спать
    /// </summary>
    public abstract void Sleep();
}
