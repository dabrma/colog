using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colog.Logging
{
    public class ErrorMessage : Message
    {

        public ErrorMessage(string text)
        {
            this.Text = text;
            this.Color = ConsoleColor.Red;
        }

        public override void Write()
        {
            System.Console.ForegroundColor = Color;
            System.Console.WriteLine(Text);
        }
    }
}
