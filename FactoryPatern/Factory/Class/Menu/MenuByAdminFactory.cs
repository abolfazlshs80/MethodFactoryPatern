using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatern.Factory.Abstract.Menu;
using FactoryPatern.Factory.Interface;

namespace FactoryPatern.Factory.Class.Menu
{
    public class MenuByAdminFactory:MenuFactory
    {
        public override IMenu InitFactory() => new MenuByAdmin();
    }
}
