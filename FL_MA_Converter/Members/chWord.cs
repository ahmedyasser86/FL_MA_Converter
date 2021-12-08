using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_MA_Converter
{
    class chWord
    {
        public string word;
        public string current;
        public List<WordsDB> words;
        int index = 0;

        public chWord(string w, List<WordsDB> wrds)
        {
            // Assign Data
            word = w; words = wrds;

            // Shuffle list
            Random rng = new Random();
            List<WordsDB> newlist = words.OrderBy(a => rng.Next()).ToList();
            words = newlist;
        }

        public chWord()
        {

        }

        public void Change_Word(ref string text)
        {
            if (index >= words.Count) index = 0;
            current = words[index].Word;
            index++;
            text = text.Replace(word, current);
        }

        public void GetCurrent(ref string text)
        {
            text = text.Replace(word, current);
        }

        public void ChangeManual(ref string text, string New)
        {
            text = text.Replace(current, New);
            current = New;
        }
    }
}
