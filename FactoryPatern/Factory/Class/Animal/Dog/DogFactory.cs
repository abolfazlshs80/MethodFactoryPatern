using FactoryPatern.Factory.Abstract.Animal;
using FactoryPatern.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatern.Factory.Class.Animal.Dog
{

    public class DogFactory : AnimalFactor
    {
        public override IAnimal Initfactory() => new Dog();
    }
}
