using Zoo.Core.Abstractions;
using Zoo.Core.Abstractions.Interfaces;

namespace Zoo.Core.Enclosers
{
    public class Aquarium : EnclosureBase
    {
        public Aquarium(long id, string name, int temperature, int capacity, int humidity, IEnumerable<IAnimal> animals)
            : base(id, name, temperature, humidity,capacity, animals)
        {
        }

        public Aquarium()
        {
        }

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