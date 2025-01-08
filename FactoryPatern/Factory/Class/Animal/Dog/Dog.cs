using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatern.Factory.Interface;

namespace FactoryPatern.Factory.Class.Animal.Dog
{
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog");
        }
    }
}
