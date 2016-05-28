using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
   abstract class AbstractFactori
    {      
        public abstract AbstractProdactList CreateProductList();
        public abstract AbstractProdactLogger CreateProductLogger();

    }
}
