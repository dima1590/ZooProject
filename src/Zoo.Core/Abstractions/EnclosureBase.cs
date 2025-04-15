using Zoo.Core.Abstractions.Interfaces;

namespace Zoo.Core.Abstractions
{
    public abstract class EnclosureBase : IEnclosure
    {
        protected int Temperature { get;set; }

        /// <summary>
        /// Влажность
        /// </summary>
        protected int Humidity { get;set; }
        protected string Name { get;set ;}
        protected long Id { get;set; }

        /// <summary>
        /// Животных в вольере
        /// </summary>
       IEnumerable <IAnimal> Animals { get;set; }

        public EnclosureBase (string name, int temperature, int humidity, long id, IEnumerable<IAnimal> animals)
        {
            Name = name;
            Temperature = temperature;
            Humidity = humidity;
            Id = id;
            Animals = animals;
        }
        public abstract IEnumerable <IAnimal> GetAnimals();

        /// <summary>
        ///  Найти животное по его ID
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
        public abstract IEnumerable <long> DeleteAllAnimals();          
    }
}
