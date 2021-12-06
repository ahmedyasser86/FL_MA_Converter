using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_MA_Converter
{
    public class Words
    {
        public string Text;
        public char Type;

        public Words()
        {

        }

        public Words(string text, char type)
        {
            Text = text;
            Type = type;
        }
    }
}
