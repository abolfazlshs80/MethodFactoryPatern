using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatern.Factory.Abstract.Animal;
using FactoryPatern.Factory.Interface;

namespace FactoryPatern.Factory.Class.Animal.Cat
{
    public class CatFactory : AnimalFactor
    {
        public override IAnimal Initfactory() => new Cat();
    }
}
