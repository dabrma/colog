using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colog.Logging
{
    public class PassedMessage : Message
    {
        public PassedMessage(string text)
        {
            this.Text = text;
            this.Color = ConsoleColor.Green;
        }

        public override void Write()
        {
            System.Console.ForegroundColor = Color;
            System.Console.WriteLine(Text);
        }
    }
}
