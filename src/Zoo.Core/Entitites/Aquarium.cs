using Zoo.Core.Abstractions;
using Zoo.Core.Abstractions.Interfaces;

namespace Zoo.Core.Enclosers
{
    public class Aquarium : EnclosureBase
    {
        public Aquarium() : base() // Значения по умолчанию
        { }

        public override IEnumerable <long> DeleteAllAnimals()
        {
            throw new NotImplementedException();
        }

        public override long DeleteAnimalById(long id)
        {
            throw new NotImplementedException();
        }

        public override IAnimal GetAnimalById(long id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable <IAnimal> GetAnimals()
        {
            throw new NotImplementedException();
        }

        public override long AddAnimal(IAnimal animal)
        {
            throw new NotImplementedException();
        }
    }
}