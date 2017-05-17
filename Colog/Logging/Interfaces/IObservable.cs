using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colog.Logging.Interfaces
{
    public interface IObservable
    {
        void AddMessage(Message msg);
    }
}
