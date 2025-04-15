namespace Zoo.Core.Abstractions.Interfaces
{
    public interface IEnclosure
    {
        IEnumerable<IAnimal> GetAnimals(); 
        IAnimal GetAnimalById(long id);  
        long SetAnimal(IAnimal animal); 
        long DeleteAnimalById(long id);
        IEnumerable<long> DeleteAllAnimals();
    }
}
