using Colog.Logging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colog.Logging
{
    public abstract class Message : IWritable
    {
        protected string Text;
        protected ConsoleColor Color;

        public virtual void Write() { }
    }
}
