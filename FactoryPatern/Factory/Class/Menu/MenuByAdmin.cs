using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatern.Factory.Interface;

namespace FactoryPatern.Factory.Class.Menu
{
    public class MenuByAdmin:IMenu
    {
        public void ShowMenu(string menuName)
        {
            Console.WriteLine($"{menuName} (Admin)");
        }
    }
}
