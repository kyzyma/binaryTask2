using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
  abstract  class AbstractProdactLogger
    {
      public abstract void Info(string mes);
      public abstract void Warning(string mes);
      public abstract void Error(string mes);
      public abstract void Debug( string mes);
    }
}
