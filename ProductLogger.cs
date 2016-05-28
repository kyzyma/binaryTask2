using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AbstractFactory
{
    class ProductLogger : AbstractProdactLogger
    {
        public override void Info(string mes) // write in File
        {
            try
            {
                File.AppendAllText("C:\\Users\\Administrator\\Desktop\\log.txt", mes + " | " + DateTime.Now + '\n' + '\n'); // Append text in end file
            }
            catch(Exception ex)
            {
                Error(ex.Message);
            }
            
        }

        public override void Debug(string mes)  // write in Console
        {
            Console.WriteLine(mes + '\n');
        }

        public override void Warning(string mes)
        {
            Console.WriteLine("Warning: You need to make debug program. Program fell.  !!!");
        }

        public override void Error(string mes)
        {
            Info(mes);
            Debug(mes);
            Warning(mes);
        }
    }
}
