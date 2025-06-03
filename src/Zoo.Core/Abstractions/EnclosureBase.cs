using Zoo.Core.Abstractions.Interfaces;

namespace Zoo.Core.Abstractions
{
    public abstract class EnclosureBase : IEnclosure
    {
        public int Temperature { get; set; }

        /// <summary>
        /// Влажность
        /// </summary>
        public int Humidity { get; set; }
        public string Name { get; set;}
        public long Id { get; set; }
        public int Capacity { get; set; }

       
        /// <summary>
        ///  Животных в вольере
        /// </summary>
        public IEnumerable<IAnimal> Animals { get; set; }

        public EnclosureBase (long id, string name, int temperature, int humidity, int capacity, IEnumerable<IAnimal> animals)
        {
            Id = id;
            Name = name;
            Temperature = temperature;
            Humidity = humidity;  
            Capacity = capacity;
            Animals = animals;
        }
        public EnclosureBase()
        { }
        /// <inheritdoc/>
        public abstract IEnumerable<IAnimal> GetAnimals();

        /// <inheritdoc/>
        public abstract IAnimal GetAnimalById(long id);

        /// <inheritdoc/>
        public abstract long AddAnimal(IAnimal animal);

        /// <inheritdoc/>
        public abstract long DeleteAnimalById(long id);

        /// <inheritdoc/>
        public abstract IEnumerable<long> DeleteAllAnimals();    
        
    }
}