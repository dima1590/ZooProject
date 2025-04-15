using Zoo.Core.Abstractions;
using Zoo.Core.Abstractions.Interfaces;

namespace Zoo.Core.Enclosers
{
    public class СoldEnclosure : EnclosureBase
    {
        public СoldEnclosure (string name, int temperature, int humidity, long id, IEnumerable<IAnimal> animals) : base(name, temperature, humidity, id, animals)
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

        public override long SetAnimal(IAnimal animal)
        {
            throw new NotImplementedException();
        }
    }
}
