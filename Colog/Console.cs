using Colog.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colog.Logging.Interfaces;
using System.Runtime.InteropServices;


namespace Colog
{
   public class Console : IObservator
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Console()
        {
            AllocConsole();
        }
        public void Log(Message msg)
        {
            msg.Write();
        }
    }
}
