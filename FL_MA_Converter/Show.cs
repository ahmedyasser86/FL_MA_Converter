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
    public partial class Show : Form
    {
        Timer errorShow = new Timer();

        public Show()
        {
            InitializeComponent();

            ShowData();

            errorShow.Interval = 3000;
            errorShow.Tick += (s, e) =>
            {
                lbl_Error.Hide();
                errorShow.Stop();
            };
        }

        public void ShowError(string err)
        {
            lbl_Error.Text = err;
            lbl_Error.Show();
            errorShow.Start();
        }

        public void ShowData()
        {
            pnl_Holder.Controls.Clear();

            List<int> IDs = DBCommands.GetIDs();

            foreach (int id in IDs)
            {
                try
                {
                    // Get Words Of this ID
                    string words = "";

                    List<WordsDB> w = DBCommands.Get_WordsI(id);

                    foreach (WordsDB d in w)
                    {
                        words += d.Word + " - ";
                    }

                    words = words.Substring(0, words.Length - 3);

                    // Get Description of this ID
                    string Des = DBCommands.GetDes(id);

                    // Creating View

                    // Panel
                    Panel pnl = new Panel()
                    {
                        Dock = DockStyle.Top,
                        Padding = new Padding(5, 5, 5, 0),
                        AutoSize = true
                    };
                    pnl_Holder.Controls.Add(pnl);
                    pnl.BringToFront();

                    // lbl Words
                    Label lbl_Words = new Label()
                    {
                        Font = new Font("GE SS Two Light", 12F, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.FromArgb(46, 64, 82),
                        Dock = DockStyle.Top,
                        Text = words
                    };
                    pnl.Controls.Add(lbl_Words);
                    lbl_Words.BringToFront();

                    TableLayoutPanel pnl_Down = new TableLayoutPanel()
                    {
                        Dock = DockStyle.Bottom,
                        Padding = new Padding(10),
                        RowCount = 1,
                        ColumnCount = 2,
                        Height = 50,
                    };
                    pnl_Down.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    pnl_Down.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    pnl.Controls.Add(pnl_Down);
                    pnl_Down.BringToFront();

                    Button btn_Delete = new Button()
                    {
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.FromArgb(65, 34, 52),
                        ForeColor = Color.White,
                        Font = new Font("GE SS Two Light", 14F),
                        Height = 131,
                        Width = 150,
                        Text = "حذف",
                        TextAlign = ContentAlignment.TopCenter,
                        Anchor = AnchorStyles.None
                    };
                    btn_Delete.FlatAppearance.BorderSize = 0;
                    pnl_Down.Controls.Add(btn_Delete, 0, 0);

                    Button btn_Edit = new Button()
                    {
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.FromArgb(189, 217, 191),
                        ForeColor = Color.FromArgb(46, 64, 82),
                        Font = new Font("GE SS Two Light", 14F),
                        Height = 131,
                        Width = 150,
                        Text = "تعديل",
                        TextAlign = ContentAlignment.TopCenter,
                        Anchor = AnchorStyles.None
                    };
                    btn_Edit.Click += (S, E) => { Go_Edit(w, Des); };
                    btn_Edit.FlatAppearance.BorderSize = 0;
                    pnl_Down.Controls.Add(btn_Edit, 1, 0);

                    TableLayoutPanel pnl_Med = new TableLayoutPanel()
                    {
                        Dock = DockStyle.Bottom,
                        Padding = new Padding(5),
                        RowCount = 1,
                        ColumnCount = 2,
                    };
                    pnl_Med.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                    pnl_Med.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    pnl_Med.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    pnl.Controls.Add(pnl_Med);
                    pnl_Med.BringToFront();

                    Panel pnl_Code = new Panel()
                    {
                        Dock = DockStyle.Fill,
                        AutoSize = true,
                    };
                    pnl_Med.Controls.Add(pnl_Code, 1, 0);
                    pnl_Code.BringToFront();

                    Label lbl_CodeL = new Label()
                    {
                        Font = new Font("GE SS Two Light", 11F),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Right,
                        Text = "رقم المعنى: ",
                        RightToLeft = RightToLeft.Yes,
                        ForeColor = Color.FromArgb(255, 200, 87),
                        AutoSize = true
                    };
                    pnl_Code.Controls.Add(lbl_CodeL);
                    lbl_CodeL.BringToFront();

                    Label lbl_ID = new Label()
                    {
                        Font = new Font("GE SS Two Light", 11F),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.FromArgb(46, 64, 82),
                        Dock = DockStyle.Right,
                        RightToLeft = RightToLeft.Yes,
                        Text = id.ToString(),
                        AutoSize = true
                    };
                    pnl_Code.Controls.Add(lbl_ID);
                    lbl_ID.BringToFront();

                    btn_Delete.Click += (S, E) =>
                    {
                        DBCommands.DeleteMana(Convert.ToInt32(lbl_ID.Text));
                        Forms.show.ShowData();
                        ShowError("تم مسح المعنى بنجاح");
                    };

                    Panel pnl_Des = new Panel()
                    {
                        Dock = DockStyle.Fill,
                        AutoSize = true
                    };
                    pnl_Med.Controls.Add(pnl_Des, 0, 0);
                    pnl_Med.BringToFront();

                    Label lbl_DesL = new Label()
                    {
                        Font = new Font("GE SS Two Light", 11F),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Right,
                        Text = "وصف المعنى: ",
                        RightToLeft = RightToLeft.Yes,
                        ForeColor = Color.FromArgb(255, 200, 87),
                        AutoSize = true
                    };
                    pnl_Des.Controls.Add(lbl_DesL);
                    lbl_DesL.BringToFront();

                    Label lbl_Des = new Label()
                    {
                        Font = new Font("GE SS Two Light", 11F),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.FromArgb(46, 64, 82),
                        Dock = DockStyle.Right,
                        RightToLeft = RightToLeft.Yes,
                        Text = Des.ToString(),

                        AutoSize = true
                    };
                    pnl_Des.Controls.Add(lbl_Des);
                    lbl_Des.BringToFront();

                    pnl_Med.Height = lbl_Des.Height + 15;

                    Panel Space = new Panel()
                    {
                        BackColor = Color.White,
                        Dock = DockStyle.Bottom,
                        Height = 5
                    };
                    pnl.Controls.Add(Space);
                    pnl.SendToBack();

                    Panel line = new Panel()
                    {
                        BackColor = Color.FromArgb(255, 200, 87),
                        Dock = DockStyle.Bottom,
                        Height = 2
                    };
                    pnl.Controls.Add(line);
                    pnl.SendToBack();
                }
                catch
                {
                    MessageBox.Show("حدث خطأ ما ، تأكد من عدم وجود معنى خالي من الكلمات"
                        , "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Go_Edit(List<WordsDB> words, string Des)
        {
            Forms.add.words.RemoveRange(0, Forms.add.words.Count);
            Forms.add.Refresh_Words();

            Forms.add.Edit = true;
            Forms.add.lbl_McodeM.Text = words[0].ManaID.ToString();
            Forms.add.mAdded = true;
            Forms.add.txt_MDes.Text = Des;

            foreach (WordsDB w in words)
            {
                Forms.add.words.Add(new Words(w.Word, 'V'));
            }

            Forms.add.Refresh_Words();

            Program.frm.Nav_Click(Program.frm.lbl_Add, Forms.add);
        }
    }
}
