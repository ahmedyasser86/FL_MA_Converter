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

        private void Btn_Replace_Click(object sender, EventArgs e)
        {
            ShowError("هذا الجزء لم يتم برمجته بعد");
        }

        private void Btn_ReArrange_Click(object sender, EventArgs e)
        {
            // Get Last Character of the string
            string s = txt_Input.Text.Substring(txt_Input.Text.Length - 1);

            if (s != ".")
            {
                if (s == "," || s == "،")
                {
                    txt_Input.Text = txt_Input.Text.Substring(0, txt_Input.Text.Length - 1) + ".";
                }
                else
                {
                    txt_Input.Text = txt_Input.Text + ".";
                }
            }
            ReArrange();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            txt_Input.Text = "";
            txt_Output.Text = "";
            txt_Input.Focus();
        }

        private void Txt_Input_TextChanged(object sender, EventArgs e)
        {
            bool End = false;
            Calc(ref End);

            // Replace Words
            if (ch_Replace.Checked)
            {
                Replace();
            }
            else txt_Output.Text = txt_Input.Text;

            // ReArrange
            if(End && ch_ReArrange.Checked)
            {
                ReArrange();
            }
        }

        private void Calc(ref bool End)
        {
            int Words = 0;
            int Letters = 0;
            int Lines = 0;
            foreach (char c in txt_Input.Text)
            {
                // Words
                if(c == ' ')
                {
                    Words++;
                }
                // Lines
                else if(c == ',' || c == '.' || c == '،')
                {
                    Lines++;
                    if (c == '.') End = true;
                }
                // Letters
                else
                {
                    Letters++;
                }
            }

            lbl_Letters.Text = Letters.ToString();
            lbl_Lines.Text = Lines.ToString();
            lbl_Words.Text = Words.ToString();
        }

        private void Replace()
        {
            string[] Input = txt_Input.Text.Split(' ', ',');
            string Output = "";
            foreach(string s in Input)
            {
                if (false)
                {
                    // TODO
                }
                else
                {
                    Output += s + " ";
                }
            }
            txt_Output.Text = Output.Substring(0, Output.Length - 1);
        }

        private void ReArrange()
        {
            Random ran = new Random();
            List<string> Input = txt_Input.Text.Split(',', '،').ToList();
            Input[Input.Count - 1] =
                Input[Input.Count - 1].Substring(0, Input[Input.Count - 1].Length - 1);
            Input[0] = " " + Input[0];
            var Output = Input.OrderBy(a => ran.Next()).ToList();
            Output[0] = Output[0].Substring(1);

            string Outtxt = "";
            foreach(string s in Output)
            {
                Outtxt += s + '،';
            }

            Outtxt = Outtxt.Substring(0, Outtxt.Length - 1) + '.';

            txt_Output.Text = Outtxt;
        }
    }
}
