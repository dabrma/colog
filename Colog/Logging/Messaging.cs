using Colog.Logging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colog.Logging
{
    public class Messaging : IObservable
    {
        private static List<Message> Messages = new List<Message>();
        private static List<IObservator> Observators = new List<IObservator>();

        public void Register(IObservator self)
        {
            Observators.Add(self);
        }

        public static Messaging instance = null;
        private static object syncRoot = new object();
        private Messaging() { }
        public static Messaging GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Messaging();
                    }
                }
                return instance;
            }

        }

       public void AddMessage(Message msg)
        {
            foreach(IObservator observator in Observators)
            {
                observator.Log(msg);
            }
        }
    }
}
