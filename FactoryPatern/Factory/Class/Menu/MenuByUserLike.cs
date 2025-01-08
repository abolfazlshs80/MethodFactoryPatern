using FactoryPatern.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatern.Factory.Class.Menu
{

    public class MenuByUserLike : IMenu
    {
        public void ShowMenu(string menuName)
        {
            Console.WriteLine($"{menuName} (User)");
        }
    }
}
