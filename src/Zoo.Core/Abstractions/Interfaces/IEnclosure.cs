namespace Zoo.Core.Abstractions.Interfaces
{
    public interface IEnclosure
    {
        /// <summary>
        /// Получить всех животных
        /// </summary>
        /// <returns>Список животных</returns>
        IEnumerable<IAnimal> GetAnimals(); 

        /// <summary>
        /// Получить животное по его id
        /// </summary>
        /// <returns>Животное</returns>
        IAnimal GetAnimalById(long id);
        
        /// <summary>
        /// Добавить животное в вольер 
        /// </summary>
        /// <returns>Id добавленного животного</returns>
        long AddAnimal(IAnimal animal);

        /// <summary>
        /// Удалить животное из вольера по его id
        /// </summary>
        /// <returns>Id удаленного животного</returns>
        long DeleteAnimalById(long id);

        /// <summary>
        /// Удалить всех животных из вольера
        /// </summary>
        /// <returns>Список id удаленных животных</returns>
        IEnumerable<long> DeleteAllAnimals();
    }
}