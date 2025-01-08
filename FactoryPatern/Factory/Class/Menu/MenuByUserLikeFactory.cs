using FactoryPatern.Factory.Abstract.Menu;
using FactoryPatern.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatern.Factory.Class.Menu
{
    
    public class MenuByUserLikeFactory : MenuFactory
    {
        public override IMenu InitFactory() => new MenuByUserLike();
    }
}
