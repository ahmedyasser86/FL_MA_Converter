namespace FL_MA_Converter
{
    partial class Home
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Output = new System.Windows.Forms.RichTextBox();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.pnl_InputB = new System.Windows.Forms.Panel();
            this.pnl_Input = new System.Windows.Forms.Panel();
            this.txt_Input = new System.Windows.Forms.RichTextBox();
            this.btn_Past = new System.Windows.Forms.Button();
            this.pnl_Down = new System.Windows.Forms.Panel();
            this.pnl_Up = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_InputB.SuspendLayout();
            this.pnl_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_InputB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_Down, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnl_Up, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.542056F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.82046F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.63749F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_Copy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(43, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 421);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.panel2.Controls.Add(this.txt_Output);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(376, 375);
            this.panel2.TabIndex = 3;
            // 
            // txt_Output
            // 
            this.txt_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(87)))));
            this.txt_Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Output.Font = new System.Drawing.Font("GE SS Two Medium", 14F, System.Drawing.FontStyle.Bold);
            this.txt_Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.txt_Output.Location = new System.Drawing.Point(2, 2);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.ReadOnly = true;
            this.txt_Output.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txt_Output.Size = new System.Drawing.Size(372, 371);
            this.txt_Output.TabIndex = 1;
            this.txt_Output.Text = "";
            // 
            // btn_Copy
            // 
            this.btn_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.btn_Copy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Copy.FlatAppearance.BorderSize = 0;
            this.btn_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Copy.Font = new System.Drawing.Font("GE SS Two Medium", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Copy.Location = new System.Drawing.Point(0, 375);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(376, 46);
            this.btn_Copy.TabIndex = 4;
            this.btn_Copy.Text = "نسخ";
            this.btn_Copy.UseVisualStyleBackColor = false;
            // 
            // pnl_InputB
            // 
            this.pnl_InputB.Controls.Add(this.pnl_Input);
            this.pnl_InputB.Controls.Add(this.btn_Past);
            this.pnl_InputB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_InputB.Location = new System.Drawing.Point(425, 37);
            this.pnl_InputB.Name = "pnl_InputB";
            this.pnl_InputB.Size = new System.Drawing.Size(376, 421);
            this.pnl_InputB.TabIndex = 4;
            // 
            // pnl_Input
            // 
            this.pnl_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.pnl_Input.Controls.Add(this.txt_Input);
            this.pnl_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Input.Location = new System.Drawing.Point(0, 0);
            this.pnl_Input.Name = "pnl_Input";
            this.pnl_Input.Padding = new System.Windows.Forms.Padding(2);
            this.pnl_Input.Size = new System.Drawing.Size(376, 375);
            this.pnl_Input.TabIndex = 3;
            // 
            // txt_Input
            // 
            this.txt_Input.BackColor = System.Drawing.Color.White;
            this.txt_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Input.Font = new System.Drawing.Font("GE SS Two Medium", 14F, System.Drawing.FontStyle.Bold);
            this.txt_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.txt_Input.Location = new System.Drawing.Point(2, 2);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Input.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txt_Input.Size = new System.Drawing.Size(372, 371);
            this.txt_Input.TabIndex = 0;
            this.txt_Input.Text = "";
            // 
            // btn_Past
            // 
            this.btn_Past.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(217)))), ((int)(((byte)(191)))));
            this.btn_Past.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Past.FlatAppearance.BorderSize = 0;
            this.btn_Past.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Past.Font = new System.Drawing.Font("GE SS Two Medium", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Past.Location = new System.Drawing.Point(0, 375);
            this.btn_Past.Name = "btn_Past";
            this.btn_Past.Size = new System.Drawing.Size(376, 46);
            this.btn_Past.TabIndex = 4;
            this.btn_Past.Text = "لصق";
            this.btn_Past.UseVisualStyleBackColor = false;
            // 
            // pnl_Down
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pnl_Down, 2);
            this.pnl_Down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Down.Location = new System.Drawing.Point(43, 464);
            this.pnl_Down.Name = "pnl_Down";
            this.pnl_Down.Size = new System.Drawing.Size(758, 55);
            this.pnl_Down.TabIndex = 6;
            // 
            // pnl_Up
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pnl_Up, 2);
            this.pnl_Up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Up.Location = new System.Drawing.Point(43, 3);
            this.pnl_Up.Name = "pnl_Up";
            this.pnl_Up.Size = new System.Drawing.Size(758, 28);
            this.pnl_Up.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("GE SS Two Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_InputB.ResumeLayout(false);
            this.pnl_Input.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_InputB;
        private System.Windows.Forms.Button btn_Past;
        private System.Windows.Forms.Panel pnl_Input;
        private System.Windows.Forms.Panel pnl_Down;
        private System.Windows.Forms.RichTextBox txt_Input;
        private System.Windows.Forms.RichTextBox txt_Output;
        private System.Windows.Forms.Panel pnl_Up;
    }
}