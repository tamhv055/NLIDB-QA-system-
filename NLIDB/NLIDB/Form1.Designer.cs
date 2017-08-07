namespace NLIDB
{
    partial class Form1
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
            this.SQLquerry_Tb = new System.Windows.Forms.TextBox();
            this.NLquerry_Tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Resuft_Bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SQLquerry_Tb
            // 
            this.SQLquerry_Tb.Location = new System.Drawing.Point(12, 344);
            this.SQLquerry_Tb.Multiline = true;
            this.SQLquerry_Tb.Name = "SQLquerry_Tb";
            this.SQLquerry_Tb.Size = new System.Drawing.Size(864, 40);
            this.SQLquerry_Tb.TabIndex = 1;
            // 
            // NLquerry_Tb
            // 
            this.NLquerry_Tb.Location = new System.Drawing.Point(12, 403);
            this.NLquerry_Tb.Name = "NLquerry_Tb";
            this.NLquerry_Tb.Size = new System.Drawing.Size(864, 20);
            this.NLquerry_Tb.TabIndex = 2;
            this.NLquerry_Tb.Text = "liệt kê thông tin của người có tên là NGUYỄN HỮU THÀNH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Câu hỏi truy vấn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Câu SQL truy vấn :";
            // 
            // Resuft_Bt
            // 
            this.Resuft_Bt.Location = new System.Drawing.Point(365, 429);
            this.Resuft_Bt.Name = "Resuft_Bt";
            this.Resuft_Bt.Size = new System.Drawing.Size(94, 31);
            this.Resuft_Bt.TabIndex = 5;
            this.Resuft_Bt.Text = "Truy Vấn";
            this.Resuft_Bt.UseVisualStyleBackColor = true;
            this.Resuft_Bt.Click += new System.EventHandler(this.Resuft_Bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kết quả :";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 300);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resuft_Bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NLquerry_Tb);
            this.Controls.Add(this.SQLquerry_Tb);
            this.Name = "Form1";
            this.Text = "Hệ thống hỏi-đáp NLIDB [Huỳnh Văn Tâm -13520735 ; Lê Thành Đạt 13520199]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SQLquerry_Tb;
        private System.Windows.Forms.TextBox NLquerry_Tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Resuft_Bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

