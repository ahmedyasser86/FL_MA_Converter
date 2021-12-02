namespace FL_MA_Converter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pnl_Clicked = new System.Windows.Forms.Panel();
            this.pnl_Hover = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Add = new System.Windows.Forms.Label();
            this.lbl_Show = new System.Windows.Forms.Label();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.pnl_Holder = new System.Windows.Forms.Panel();
            this.pnl_Top.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("GE SS Two Medium", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(507, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 86);
            this.label1.TabIndex = 2;
            this.label1.Text = "إسم التطبيق";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.pnl_Top.Controls.Add(this.pnl_Clicked);
            this.pnl_Top.Controls.Add(this.pnl_Hover);
            this.pnl_Top.Controls.Add(this.tableLayoutPanel1);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.ForeColor = System.Drawing.Color.White;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(845, 86);
            this.pnl_Top.TabIndex = 3;
            // 
            // pnl_Clicked
            // 
            this.pnl_Clicked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Clicked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(87)))));
            this.pnl_Clicked.Location = new System.Drawing.Point(0, 0);
            this.pnl_Clicked.Name = "pnl_Clicked";
            this.pnl_Clicked.Size = new System.Drawing.Size(27, 2);
            this.pnl_Clicked.TabIndex = 5;
            this.pnl_Clicked.Visible = false;
            // 
            // pnl_Hover
            // 
            this.pnl_Hover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.pnl_Hover.Location = new System.Drawing.Point(474, 33);
            this.pnl_Hover.Name = "pnl_Hover";
            this.pnl_Hover.Size = new System.Drawing.Size(27, 2);
            this.pnl_Hover.TabIndex = 4;
            this.pnl_Hover.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Add, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Show, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Home, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 86);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbl_Add
            // 
            this.lbl_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Add.AutoSize = true;
            this.lbl_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Add.Font = new System.Drawing.Font("GE SS Two Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Add.Location = new System.Drawing.Point(218, 34);
            this.lbl_Add.Name = "lbl_Add";
            this.lbl_Add.Size = new System.Drawing.Size(76, 17);
            this.lbl_Add.TabIndex = 3;
            this.lbl_Add.Text = "إضافة معنى";
            this.lbl_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Add.Click += new System.EventHandler(this.Nav_Buttons);
            // 
            // lbl_Show
            // 
            this.lbl_Show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Show.AutoSize = true;
            this.lbl_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Show.Font = new System.Drawing.Font("GE SS Two Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Show.Location = new System.Drawing.Point(74, 34);
            this.lbl_Show.Name = "lbl_Show";
            this.lbl_Show.Size = new System.Drawing.Size(78, 17);
            this.lbl_Show.TabIndex = 3;
            this.lbl_Show.Text = "عرض المعاني";
            this.lbl_Show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Show.Click += new System.EventHandler(this.Nav_Buttons);
            // 
            // lbl_Home
            // 
            this.lbl_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Home.Font = new System.Drawing.Font("GE SS Two Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Home.Location = new System.Drawing.Point(374, 34);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(51, 17);
            this.lbl_Home.TabIndex = 3;
            this.lbl_Home.Text = "الرئيسية";
            this.lbl_Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Home.Click += new System.EventHandler(this.Nav_Buttons);
            // 
            // pnl_Holder
            // 
            this.pnl_Holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Holder.Location = new System.Drawing.Point(0, 86);
            this.pnl_Holder.Name = "pnl_Holder";
            this.pnl_Holder.Size = new System.Drawing.Size(845, 522);
            this.pnl_Holder.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 608);
            this.Controls.Add(this.pnl_Holder);
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("GE SS Two Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.pnl_Top.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_Home;
        private System.Windows.Forms.Label lbl_Add;
        private System.Windows.Forms.Label lbl_Show;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl_Hover;
        private System.Windows.Forms.Panel pnl_Clicked;
        private System.Windows.Forms.Panel pnl_Holder;
    }
}

