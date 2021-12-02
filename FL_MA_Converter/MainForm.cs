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
    public partial class MainForm : Form
    {
        string Clicked_Label = null;
        Font NormalFont;
        public MainForm()
        {
            InitializeComponent();

            // Navbar Mouse Hover Script
            lbl_Add.MouseEnter += (S, E) => { Nav_Hover(lbl_Add); };
            lbl_Show.MouseEnter += (S, E) => { Nav_Hover(lbl_Show); };
            lbl_Home.MouseEnter += (S, E) => { Nav_Hover(lbl_Home); };

            // Navbar Mouse leave Script
            lbl_Add.MouseLeave += (S, E) => { Nav_Leave(lbl_Add); };
            lbl_Show.MouseLeave += (S, E) => { Nav_Leave(lbl_Show); };
            lbl_Home.MouseLeave += (S, E) => { Nav_Leave(lbl_Home); };

            NormalFont = lbl_Add.Font;

            Nav_Click(lbl_Home, Forms.home);
        }

        private void Nav_Buttons(object sender, EventArgs e)
        {
            string name = (sender as Label).Name;

            switch (name)
            {
                case "lbl_Home":
                    Nav_Click(lbl_Home, Forms.home);
                    break;

                case "lbl_Add":
                    Nav_Click(lbl_Add, Forms.add);
                    break;

                case "lbl_Show":
                    Nav_Click(lbl_Show, Forms.show);
                    break;
            }
        }

        private void Nav_Click(Label lbl, Form frm)
        {
            Clicked_Label = lbl.Name;

            // Return All Labels for thier color
            lbl_Add.ForeColor = Color.White;
            lbl_Show.ForeColor = Color.White;
            lbl_Home.ForeColor = Color.White;

            // Return All Labels to thier Font
            lbl_Add.Font = NormalFont;
            lbl_Home.Font = NormalFont;
            lbl_Show.Font = NormalFont;

            // Changing Clicked Color
            lbl.ForeColor = Color.FromArgb(255, 200, 87);

            // Changing Clicked Font
            lbl.Font = new Font(lbl.Font, FontStyle.Bold);

            // Moving Clicked Panel
            int y = lbl.Location.Y + lbl.Size.Height + 4;
            pnl_Clicked.Location = new Point(lbl.Location.X, y);
            pnl_Clicked.Width = lbl.Width;
            pnl_Clicked.Visible = true;
            pnl_Clicked.BringToFront();

            // Open The Form
            ShowForm(frm);
        }

        private void ShowForm(Form frm)
        {
            pnl_Holder.Controls.Clear();
            pnl_Holder.Controls.Add(frm);
            frm.Show();
        }

        private void Nav_Hover(Label lbl)
        {
            if(Clicked_Label != lbl.Name)
            {
                // Moving Hover Panel
                int y = lbl.Location.Y + lbl.Size.Height + 4;
                pnl_Hover.Location = new Point(lbl.Location.X, y);
                pnl_Hover.Width = lbl.Width;
                pnl_Hover.Visible = true;

                // Changing Color
                lbl.ForeColor = Color.FromArgb(189, 217, 191);
            }
        }

        private void Nav_Leave (Label lbl)
        {
            if (Clicked_Label != lbl.Name)
            {
                // Hide Line
                pnl_Hover.Visible = false;

                // Changing Color
                lbl.ForeColor = Color.White;
            }
            else
            {
                // Hide Line
                pnl_Hover.Visible = false;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // Changing pnl_Clicked Loction on size change
            Label lbl = this.Controls.Find(Clicked_Label, true).FirstOrDefault() as Label;
            int y = lbl.Location.Y + lbl.Size.Height + 4;
            pnl_Clicked.Location = new Point(lbl.Location.X, y);
        }
    }
}
