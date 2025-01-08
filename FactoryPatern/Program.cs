// See https://aka.ms/new-console-template for more information

using FactoryPatern.Factory.Abstract.Animal;
using FactoryPatern.Factory.Abstract.Menu;
using FactoryPatern.Factory.Class;
using FactoryPatern.Factory.Class.Animal.Dog;
using FactoryPatern.Factory.Class.Menu;
using FactoryPatern.Factory.Interface;

Console.WriteLine("Hello, World!");


AnimalFactor animalFactor=new DogFactory();
IAnimal animal= animalFactor.Initfactory();
animal.Speak();


MenuFactory  menuFactory=new MenuByUserLikeFactory();
IMenu user=menuFactory.InitFactory();
user.ShowMenu("File");


menuFactory = new MenuByAdminFactory();
user = menuFactory.InitFactory();
user.ShowMenu("File");