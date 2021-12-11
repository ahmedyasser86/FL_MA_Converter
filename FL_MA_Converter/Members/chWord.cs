using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_MA_Converter
{
    class chWord
    {

        Random rng = new Random();

        public string word;
        public string current;
        public string Type;
        public List<WordsDB> words;
        public int SenIndex;
        int index = 0;

        public chWord(string w, List<WordsDB> wrds, string type, int i)
        {
            // Assign Data
            word = w; words = wrds; Type = type; SenIndex = i; current = word;
        }

        public chWord()
        {

        }

        public void Replace(List<string> sens)
        {

            if (words.Count > 1)
            {
                string newWord = words[rng.Next(0, words.Count)].Word;

                while (newWord == current)
                {
                    newWord = words[rng.Next(0, words.Count)].Word;
                }

                sens[SenIndex] = sens[SenIndex].Replace(current, newWord);

                current = newWord;
            }
            else
            {
                for(int i = 0; i < words.Count; i++)
                {
                    if(words[i].Word != current)
                    {
                        sens[SenIndex] = sens[SenIndex].Replace(current, words[i].Word);

                        current = words[i].Word;
                        break;
                    }
                }
            }
        }
    }
}
