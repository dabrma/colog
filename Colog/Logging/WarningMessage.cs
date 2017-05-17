using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colog.Logging
{
    public class WarningMessage : Message
    {
        public WarningMessage(string text)
        {
            this.Text = text;
            this.Color = ConsoleColor.Yellow;
        }

        public override void Write()
        {
            System.Console.ForegroundColor = Color;
            System.Console.WriteLine(Text);
        }
    }
}
