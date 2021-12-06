namespace FL_MA_Converter
{
    partial class Show
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
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pnl_Holder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_Error
            // 
            this.lbl_Error.BackColor = System.Drawing.Color.White;
            this.lbl_Error.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Error.Font = new System.Drawing.Font("GE SS Two Light", 11F);
            this.lbl_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(34)))), ((int)(((byte)(52)))));
            this.lbl_Error.Location = new System.Drawing.Point(2, 2);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(841, 22);
            this.lbl_Error.TabIndex = 0;
            this.lbl_Error.Text = "خطأ هنا";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Error.Visible = false;
            // 
            // pnl_Holder
            // 
            this.pnl_Holder.AutoScroll = true;
            this.pnl_Holder.BackColor = System.Drawing.Color.White;
            this.pnl_Holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Holder.Location = new System.Drawing.Point(2, 24);
            this.pnl_Holder.Name = "pnl_Holder";
            this.pnl_Holder.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_Holder.Size = new System.Drawing.Size(841, 496);
            this.pnl_Holder.TabIndex = 1;
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(845, 522);
            this.Controls.Add(this.pnl_Holder);
            this.Controls.Add(this.lbl_Error);
            this.Font = new System.Drawing.Font("GE SS Two Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Show";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Show";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Panel pnl_Holder;
    }
}