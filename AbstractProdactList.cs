using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
   abstract class AbstractProdactList
    {      
       abstract public void AddUser(AbstractProdactLogger l);
       abstract public void RemoveUser(int i, AbstractProdactLogger l);
    }

}
