using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_MA_Converter
{
    public class WordsDB
    {
        public int ManaID;
        public string Word;

        public WordsDB(int i, string w)
        {
            ManaID = i;
            Word = w;
        }
    }
}
