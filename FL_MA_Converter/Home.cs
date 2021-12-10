using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_MA_Converter
{
    public partial class Home : Form
    {
        Timer errorShow = new Timer();

        List<string> Words = new List<string>();
        List<string> Sens = new List<string>();
        List<int> Para_Count = new List<int>();

        List<chWord> chwords = new List<chWord>();

        bool txtChanged = true;
        string OutPut = "";

        public Home()
        {
            InitializeComponent();

            errorShow.Interval = 3000;
            errorShow.Tick += (s, e) =>
            {
                lbl_Error.Hide();
                errorShow.Stop();
            };
        }

        public void AddTextColor(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        private void Btn_Past_Click(object sender, EventArgs e)
        {
            txt_Input.Text = Clipboard.GetText();
        }

        private void Btn_Copy_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txt_Output.Text))
            {
                Clipboard.SetText(txt_Output.Text);
            }
            else
            {
                ShowError("الحقل فارغ ، لا يوجد ما يتم نسخه");
            }
        }

        private void ShowError(string err)
        {
            lbl_Error.Text = err;
            lbl_Error.Show();
            errorShow.Start();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            txt_Input.Text = "";
            txt_Output.Text = "";
            txt_Input.Focus();
        }

        private void Check_Words(List<string> words)
        {
            List<WordsDB> w;

            foreach (string s in Words)
            {
                w = DBCommands.Get_WordsW(s);

                if (w.Count > 0)
                {
                    // chwords.Add(new chWord(s, w));
                }

                w.RemoveRange(0, w.Count);
            }
        }

        private void Remove_UnNeeded(List<string> arr)
        {
            List<int> ToDelete = new List<int>();
            for (int i = 0, n = arr.Count; i < n; i++)
            {
                try
                {
                    // Check Start
                    if (arr[i].Substring(0, 1) == "." || arr[i].Substring(0, 1) == "," || arr[i].Substring(0, 1) == " "
                        || arr[i].Substring(0, 1) == "،" || arr[i].Substring(0, 1) == "\n")
                    {
                        arr[i] = arr[i].Substring(1);
                    }

                    // Check End
                    if (arr[i].Substring(arr[i].Length - 1) == "." || arr[i].Substring(arr[i].Length - 1) == "," ||
                        arr[i].Substring(arr[i].Length - 1) == " " || arr[i].Substring(arr[i].Length - 1) == "،" ||
                        arr[i].Substring(arr[i].Length - 1) == "\n")
                    {
                        arr[i] = arr[i].Substring(0, arr[i].Length - 1);
                    }

                    if (arr[i] == "\n") throw new Exception();
                }
                catch
                {
                    ToDelete.Add(i);
                }
            }

            foreach(int i in ToDelete)
            {
                arr.RemoveAt(i);
            }
        }

        private void Check_Para()
        {
            string i = txt_Input.Text;
            if (i.Substring(i.Length) == ".") i = i.Substring(0, i.Length - 1);
            string[] p = i.Split('.');
            foreach(string s in p)
            {
                string[] S = s.Split('،', ',', ';');

                if (s.Length > 0) Para_Count.Add(S.Count());
            }
        }

        private void PreChange()
        {
            // Clear Lists
            // TODO..

            // Get Paragraphes details
            Check_Para();

            // Split Text to Sens
            Sens = txt_Input.Text.Split('،', ',', '.', ';').ToList();

            // Check Changeble Sens..
            Check_Sens(Sens);

            // Check Manual Words
            Check_ManWords();

            // Remove UnNeeded Spaces and chars
            Remove_UnNeeded(Sens);
            Remove_UnNeeded(Words);

            // Check Changable Words
            chwords.RemoveRange(0, chwords.Count);
            Check_Words(Words);


            OutPut = "";
        }

        private void Check_Sens(List<string> sens)
        {
            for(int x = 0; x < sens.Count; x++)
            {
                // Split Sens To Words
                string[] Words = sens[x].Split(' ');


                for(int i = Words.Length; i > 1; i--)
                {
                    List<WordsDB> wordsDBs;

                    for (int j = 0, L = Words.Length; j <= L - i; j++)
                    {
                        string Sen = "";

                        for(int k = j; k < i + j; k++)
                        {
                            Sen += Words[k] + " ";
                        }

                        Sen = Sen.Substring(0, Sen.Length - 1);

                        wordsDBs = DBCommands.Get_WordsW(Sen);

                        if(wordsDBs.Count > 0 && i > 1)
                        {
                            chwords.Add(new chWord(Sen, wordsDBs, "S", x));
                        }
                        else if(wordsDBs.Count > 0 && i == 1)
                        {
                            chwords.Add(new chWord(Sen, wordsDBs, "W", x));
                        }

                        wordsDBs.RemoveRange(0, wordsDBs.Count);
                    }
                }
            }
        }

        private void Check_ManWords()
        {
            foreach(chWord w in chwords)
            {
                if(w.Type == "L")
                {
                    foreach(chWord w2 in chwords)
                    {
                        if(w2.SenIndex == w.SenIndex)
                        {
                            if(w2.Type == "W")
                            {
                                foreach(string s in w.word.Split(' '))
                                {
                                    if (s == w2.word) w2.Type = "M";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ReArrange(bool sh = true)
        {
            // Shuffle Sens
            if (sh)
            {
                Random rng = new Random();
                List<string> newLest = Sens.OrderBy(a => rng.Next()).ToList();
                Sens = newLest;
            }

            // ReArrange
            for(int i = 0, n = Para_Count.Count, tmp = 0; i < n;i++)
            {
                tmp += Para_Count[i];
                for (int j = tmp - Para_Count[i]; j < tmp; j++)
                {
                    OutPut += Sens[j] + "، ";
                }
                OutPut = OutPut.Substring(0, OutPut.Length - 2);
                OutPut += ".\n";
            }
            OutPut = OutPut.Substring(0, OutPut.Length - 1);
        }

        private void Change(bool ch = true)
        {
            if (ch)
            {
                foreach (chWord w in chwords)
                {
                    w.Change_Word(ref OutPut);
                }
            }
            else
            {
                foreach(chWord w in chwords)
                {
                    w.GetCurrent(ref OutPut);
                }
            }
        }

        private void Btn_Change_Click(object sender, EventArgs e)
        {
            if (txtChanged && !String.IsNullOrEmpty(txt_Input.Text))
            {
                PreChange();
                ReArrange(ch_ReArrange.Checked);
                Change(ch_Replace.Checked);
                txt_Output.Text = OutPut;
                txtChanged = false;
            }

            else if (!txtChanged && !String.IsNullOrEmpty(txt_Input.Text))
            {
                OutPut = "";
                ReArrange(ch_ReArrange.Checked);
                Change(ch_Replace.Checked);
                txt_Output.Text = OutPut;
            }

            ChangeColor();
        }

        private void Txt_Input_TextChanged(object sender, EventArgs e)
        {
            txtChanged = true;
        }

        public void Find(RichTextBox rtb, string word, Color color)
        {
            if (word == "")
            {
                MessageBox.Show("1");
                return;
            }
            int s_start = rtb.SelectionStart, startIndex = 0, index;
            while ((index = rtb.Text.IndexOf(word, startIndex)) != -1)
            {
                rtb.Select(index, word.Length);
                rtb.SelectionColor = color;
                startIndex = index + word.Length;
            }
        }

        public void ChangeColor()
        {
            foreach(chWord w in chwords)
            {
                Find(txt_Output, w.current, Color.Red);
            }
        }

        private void Txt_Output_MouseDown(object sender, MouseEventArgs e)
        {
            if(txt_Output.SelectionLength >= 1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    CreateDropDownMenu(txt_Output.SelectedText, e.Location);
                }
            }
        }

        private void CreateDropDownMenu(string text, Point L)
        {
            List<WordsDB> words = new List<WordsDB>();
            chWord ch = new chWord();
            foreach (chWord c in chwords)
            {
                if(c.word == text)
                {
                    words = c.words;
                    ch = c;
                    break;
                }

                foreach(WordsDB db in c.words)
                {
                    if(db.Word == text)
                    {
                        words = c.words;
                        ch = c;
                        break;
                    }
                }
            }

            if(words.Count != 0)
            {
                pnl_Words.Show();
                pnl_Words.Location = new Point((L.X + 42), (L.Y + 52));

                foreach(WordsDB w in words)
                {
                    Button btn = new Button()
                    {
                        Name = w.Word,
                        Text = w.Word,
                        Font = new Font("GE SS Two Light", 12F),
                        Height = 30,
                        Dock = DockStyle.Top,
                        ForeColor = Color.FromArgb(46, 64, 82),
                        FlatStyle = FlatStyle.Flat,
                    };
                    pnl_Words.Controls.Add(btn);
                    btn.Click += (S, E) =>
                    {
                        /*
                        string tmp = txt_Output.Text;
                        ch.ChangeManual(ref tmp, btn.Name);
                        txt_Output.Text = tmp;
                        */
                        txt_Output.SelectedText = btn.Name;
                        ch.current = btn.Name;
                        ChangeColor();
                        pnl_Words.Controls.Clear();
                        pnl_Words.Hide();
                        txt_Output.SelectionStart = 0;
                        txt_Output.SelectionLength = 0;
                    };
                }

                Button btn_Cancel = new Button()
                {
                    Dock = DockStyle.Top,
                    Text = "إلغاء",
                    BackColor = Color.FromArgb(65, 34, 52),
                    ForeColor = Color.White,
                    Font = new Font("GE SS Two Light", 12F),
                    FlatStyle = FlatStyle.Flat,
                    Height = 25
                };
                pnl_Words.Controls.Add(btn_Cancel);
                btn_Cancel.SendToBack();
                btn_Cancel.FlatAppearance.BorderSize = 0;
                btn_Cancel.Click += (S, E) =>
                 {
                     pnl_Words.Controls.Clear();
                     pnl_Words.Hide();
                 };
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Check_Sens(new List<string>() { "انا أسمي احمد ياسر" });
        }
    }
}
