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
    public partial class Add : Form
    {
        public bool mAdded = false;

        public bool Edit = false;

        Timer errorWShow = new Timer();
        Timer errorMShow = new Timer();

        public List<Words> words = new List<Words>();

        public Add()
        {
            InitializeComponent();

            errorWShow.Interval = 3000;
            errorWShow.Tick += (s, e) =>
            {
                lbl_ErrorW.Hide();
                errorWShow.Stop();
            };

            errorMShow.Interval = 3000;
            errorMShow.Tick += (s, e) =>
            {
                lbl_ErrorM.Hide();
                errorMShow.Stop();
            };

            Enter_Clicks();

            lbl_McodeM.Text = (DBCommands.Get_Max_ID() + 1).ToString();

            Refresh_Words();
        }

        private void Enter_Clicks()
        {
            txt_MDes.KeyDown += (S, E) =>
            {
                if (!String.IsNullOrEmpty(txt_MDes.Text) && E.KeyCode == Keys.Enter)
                {
                    btn_AddM.PerformClick();
                    E.Handled = true;
                }
                else if(E.KeyCode == Keys.F10)
                {
                    ShowErrorM("قم بإضافة بعض الوصف أولا");
                }
            };

            txt_Word.KeyDown += (S, E) =>
            {
                if (!String.IsNullOrEmpty(txt_Word.Text) && E.KeyCode == Keys.Enter)
                {
                    btn_AddWord.PerformClick();
                }
            };
        }

        public void Show_Word(string Text)
        {
            Panel pnl = new Panel()
            {
                Dock = DockStyle.Top,
                Padding = new Padding(10, 2, 4, 2),
                Height = 40,
            };

            Label lbl = new Label()
            {
                Text = Text,
                Font = new Font("GE SS Two Light", 12F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.FromArgb(46, 64, 82),
                Dock = DockStyle.Right,
                RightToLeft = RightToLeft.Yes
            };

            Button btn = new Button()
            {
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(65, 34, 52),
                ForeColor = Color.White,
                Font = new Font("GE SS Two Light", 12F),
                Height = lbl.Height,
                Width = 100,
                Text = "حذف",
                Dock = DockStyle.Left,
                TabIndex = 5
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += (S, E) =>
            {
                string txt = lbl.Text;

                foreach(Words w in words)
                {
                    if(w.Text == txt)
                    {
                        if(w.Type == 'N')
                        {
                            words.Remove(w);
                        }
                        else if(w.Type == 'V')
                        {
                            w.Type = 'D';
                        }
                        break;
                    }
                }

                Refresh_Words();

                txt_Word.Focus();
            };

            Panel Line = new Panel()
            {
                BackColor = Color.FromArgb(255, 200, 87),
                Height = 2,
                Dock = DockStyle.Bottom
            };

            pnl.Controls.Add(lbl);
            lbl.SendToBack();
            pnl.Controls.Add(btn);
            btn.SendToBack();
            pnl.Controls.Add(Line);
            Line.SendToBack();

            pnl_Words.Controls.Add(pnl);

            pnl.SendToBack();
        }
        public void Show_Word()
        {
            Label lbl = new Label()
            {
                Text = "لا يوجد كلمات ليتم عرضها",
                ForeColor = Color.FromArgb(46, 64, 82),
                Font = new Font("GE SS Two Light", 14F),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            pnl_Words.Controls.Add(lbl);
        }

        private void Btn_AddWord_Click(object sender, EventArgs e)
        {
            if (mAdded && !String.IsNullOrEmpty(txt_Word.Text))
            {
                bool Exists = false, Undo = false;

                foreach (Words w in words)
                {
                    if (w.Text == txt_Word.Text)
                    {
                        if (w.Type == 'N' || w.Type == 'V') Exists = true;
                        else Undo = true;
                        break;
                    }
                }

                if (!Exists && !Undo)
                {
                    words.Add(new Words(txt_Word.Text, 'N'));
                    Refresh_Words();

                    txt_Word.Text = "";
                    txt_Word.Focus();
                }
                else if (Undo)
                {
                    foreach (Words w in words)
                    {
                        if (w.Text == txt_Word.Text)
                        {
                            w.Type = 'V';

                            txt_Word.Text = "";
                            txt_Word.Focus();
                            break;
                        }
                    }
                }
                else
                {
                    ShowErrorW("هذه الكلمة موجودة بالفعل");
                }
            }
            else if (String.IsNullOrEmpty(txt_Word.Text))
            {
                ShowErrorW("لا يمكن وضع نص فارغ");
                txt_Word.Focus();
            }
            else
            {
                ShowErrorW("قم بإضافة معنى أولا");
                txt_MDes.Focus();
            }
        }

        private void ShowErrorW(string err)
        {
            errorWShow.Stop();
            lbl_ErrorW.Text = err;
            lbl_ErrorW.Show();
            errorWShow.Start();
        }

        private void ShowErrorM(string err)
        {
            errorMShow.Stop();
            lbl_ErrorM.Text = err;
            lbl_ErrorM.Show();
            errorMShow.Start();
        }

        public void Refresh_Words()
        {
            pnl_Words.Controls.Clear();

            foreach(Words obj in words)
            {
                if(obj.Type != 'D')
                {
                    Show_Word(obj.Text);
                }
            }

            if(pnl_Words.Controls.Count == 0)
            {
                Show_Word();
            }
        }

        private void Btn_AddM_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_MDes.Text))
            {
                mAdded = true;
                txt_Word.Focus();
                ShowErrorM("تم إضافة المعنى ، قم بإضافة الكلمات الأن");
            }

            else
            {
                ShowErrorM("قم بإضافة بعض الوصف أولا");
                txt_MDes.Focus();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            mAdded = false;
            Edit = false;

            words.RemoveRange(0, words.Count);

            lbl_McodeM.Text = (DBCommands.Get_Max_ID() + 1).ToString();

            Refresh_Words();

            txt_Word.Text = "";
            txt_MDes.Text = "";
            txt_MDes.Focus();

            ShowErrorM("تم الإلغاء");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            #region Validation
            if (!mAdded)
            {
                ShowErrorM("قم بإضافة معنى أولا");
                txt_MDes.Focus();
                return;
            }
            if(words.Count == 0)
            {
                ShowErrorW("لا يمكن حفظ معنى بدون كلمات");
                txt_Word.Focus();
                return;
            }
            #endregion Validation

            if (!Edit)
            {
                string[] w = new string[words.Count];
                for(int i = 0, n = words.Count; i < n; i++)
                {
                    w[i] = words[i].Text;
                }

                int Resault = DBCommands.SaveInsert(txt_MDes.Text, w);
                if (Resault == 0)
                {
                    mAdded = false;
                    Edit = false;

                    words.RemoveRange(0, words.Count);

                    lbl_McodeM.Text = (DBCommands.Get_Max_ID() + 1).ToString();

                    Refresh_Words();

                    txt_Word.Text = "";
                    txt_MDes.Text = "";
                    txt_MDes.Focus();

                    ShowErrorM("تم الحفظ بنجاح");
                    ShowErrorW("تم الحفظ بنجاح");

                    Forms.show.ShowData();
                }
                else if(Resault == 1)
                {
                    MessageBox.Show("حدث خطأ أثناء الحفظ\nكود الخطأ : 1", "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء الحفظ\nكود الخطأ : 2", "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                int r = DBCommands.SaveUpdate(Convert.ToInt32(lbl_McodeM.Text), txt_MDes.Text, words);

                if(r == 0)
                {
                    mAdded = false;
                    Edit = false;

                    words.RemoveRange(0, words.Count);

                    lbl_McodeM.Text = (DBCommands.Get_Max_ID() + 1).ToString();

                    Refresh_Words();

                    txt_Word.Text = "";
                    txt_MDes.Text = "";
                    txt_MDes.Focus();

                    ShowErrorM("تم الحفظ بنجاح");
                    ShowErrorW("تم الحفظ بنجاح");

                    Forms.show.ShowData();
                    Program.frm.Nav_Click(Program.frm.lbl_Show, Forms.show);
                    Forms.show.ShowError("تم التعديل بنجاح");
                }
            }
        }
    }
}
