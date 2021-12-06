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

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            txt_Input.Text = "";
            txt_Output.Text = "";
            txt_Input.Focus();
        }

        private void Txt_Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
