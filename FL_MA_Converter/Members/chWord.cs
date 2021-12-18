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

        public string word;
        public string current;
        public string Type;
        public List<WordsDB> words;
        public int SenIndex;

        public chWord(string w, List<WordsDB> wrds, string type, int i)
        {
            // Assign Data
            word = w; words = wrds; Type = type; SenIndex = i; current = word;

            
            foreach(WordsDB wrd in words)
            {
                if((wrd.Word.Split(' ')).Length > 1)
                {
                    Type = "S";
                    break;
                }
            }
        }

        public chWord()
        {

        }

        public void Replace(List<string> sens, ref Random rng)
        {
            if (words.Count > 1)
            {
                string newWord = words[rng.Next(0, words.Count)].Word;

                string[] tmp = current.Split(' ');

                if (Type == "S" && tmp.Length > 1)
                {

                    sens[SenIndex] = sens[SenIndex].Replace(current, newWord);
                }
                else
                {
                    string[] arr = sens[SenIndex].Split(' ');

                    sens[SenIndex] = "";

                    for (int i = 0, n = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == current && n == 0)
                        {
                            arr[i] = newWord;
                            n++;
                        }

                        sens[SenIndex] += arr[i] + " ";
                    }

                    sens[SenIndex] = sens[SenIndex].Substring(0, sens[SenIndex].Length - 1);
                }

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
