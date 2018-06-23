using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFBattle
{
    public class TextBoxStreamWriter : System.IO.TextWriter
    {

        TextBox output;

        public TextBoxStreamWriter(TextBox txt)
        {
            output = txt; 
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8;  }
        }

        public override void Write(char value)
        {
            base.Write(value);
            output.Dispatcher.BeginInvoke(new Action(() =>
            {
                output.AppendText(value.ToString());
            })
            );
        }

    }
}
