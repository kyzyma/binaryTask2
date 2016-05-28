using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Client
    {        
        AbstractProdactList abstractProdactList = null;
        AbstractProdactLogger abstractProdactLogger = null;

        public Client(AbstractFactori abstractFactory)
        {
            this.abstractProdactList = abstractFactory.CreateProductList();
            this.abstractProdactLogger = abstractFactory.CreateProductLogger();

        }

        public void Input()
        {
            abstractProdactList.AddUser(abstractProdactLogger);                  
        }

        public void Remove(int index)
        {
            abstractProdactList.RemoveUser(index,abstractProdactLogger);
        }
    }
}
