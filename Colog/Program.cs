using Colog.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console t = new Console();
            Messaging.GetInstance.Register(t);
            for( int i = 0; i < 10; i++)
            {
                if(i > 5)
                {
                    Messaging.GetInstance.AddMessage(new ErrorMessage($"ERROR: {i} is too large"));
                }

                else { Messaging.GetInstance.AddMessage(new PassedMessage("OK")); }
            }

            System.Console.Read();
        }
    }
}
