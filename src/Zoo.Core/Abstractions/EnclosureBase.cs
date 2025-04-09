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
        public string Name { get; set; }
        public long Id { get; set; }

        /// <summary>
        /// животных в вольере
        /// </summary>
       IEnumerable<IAnimal> Animals { get; set; }
        public EnclosureBase(string name, int temperature, int humidity, long id, IEnumerable<IAnimal> animals)
        {
            Name = name;
            Temperature = temperature;
            Humidity = humidity;
            Id = id;
            IEnumerable<IAnimal> Animals = animals;
        }
        public abstract IEnumerable<IAnimal> GetAnimals();

        /// <summary>
        ///  найти животное по его ID
        /// </summary>
        public abstract IAnimal GetAnimalById(long id);

        /// <summary>
        /// Добавляет животное в вольер 
        /// </summary>
        public abstract long SetAnimal(IAnimal animal);

        /// <summary>
        ///  Удаляет животное из вольера по его ID
        /// </summary>
        public abstract long DeleteAnimalById(long id);

        /// <summary>
        ///  Удаляет всех животных из вольера
        /// </summary>
        public abstract IEnumerable<long> DeleteAllAnimals();          
    }
}
