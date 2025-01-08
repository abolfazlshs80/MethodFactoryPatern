using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatern.Factory.Interface;

namespace FactoryPatern.Factory.Abstract.Animal
{
    public abstract class AnimalFactor
    {
        public abstract IAnimal Initfactory();

    }
}
