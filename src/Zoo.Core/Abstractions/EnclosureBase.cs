using Zoo.Core.Abstractions.Interfaces;

namespace Zoo.Core.Abstractions
{
    public abstract class EnclosureBase : IEnclosure
    {
        protected int Temperature { get; set; }

        /// <summary>
        /// Влажность
        /// </summary>
        protected int Humidity { get; set; }
        protected string Name { get; set;}
        protected long Id { get; set; }

        /// <summary>
        /// Животных в вольере
        /// </summary>
        IEnumerable<IAnimal> Animals { get; set; }

        public EnclosureBase (long id, string name, int temperature, int humidity, IEnumerable<IAnimal> animals)
        {
            Name = name;
            Temperature = temperature;
            Humidity = humidity;
            Id = id;
            Animals = animals;
        }

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