﻿using Zoo.Core.Abstractions;
using Zoo.Core.Abstractions.Interfaces;

namespace Zoo.Core.Enclosers
{
    public class СoldEnclosure : EnclosureBase
    {
        public СoldEnclosure (long id, string name, int temperature, int humidity, IEnumerable<IAnimal> animals)
            : base(id, name, temperature, humidity, animals)
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