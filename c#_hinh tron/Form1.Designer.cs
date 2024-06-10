namespace c__hinh_tron
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
            this.btndt = new System.Windows.Forms.Button();
            this.chkdt2 = new System.Windows.Forms.CheckBox();
            this.chkcv2 = new System.Windows.Forms.CheckBox();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.lblBK = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbcv1 = new System.Windows.Forms.RadioButton();
            this.rdbdt1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntinh1 = new System.Windows.Forms.Button();
            this.btntinh2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndt
            // 
            this.btndt.Location = new System.Drawing.Point(12, 248);
            this.btndt.Name = "btndt";
            this.btndt.Size = new System.Drawing.Size(75, 23);
            this.btndt.TabIndex = 0;
            this.btndt.Text = "diện tích";
            this.btndt.UseVisualStyleBackColor = true;
            this.btndt.Click += new System.EventHandler(this.btndt_Click);
            // 
            // chkdt2
            // 
            this.chkdt2.AutoSize = true;
            this.chkdt2.Location = new System.Drawing.Point(6, 22);
            this.chkdt2.Name = "chkdt2";
            this.chkdt2.Size = new System.Drawing.Size(68, 17);
            this.chkdt2.TabIndex = 1;
            this.chkdt2.Text = "diện tích";
            this.chkdt2.UseVisualStyleBackColor = true;
            // 
            // chkcv2
            // 
            this.chkcv2.AutoSize = true;
            this.chkcv2.Location = new System.Drawing.Point(6, 61);
            this.chkcv2.Name = "chkcv2";
            this.chkcv2.Size = new System.Drawing.Size(55, 17);
            this.chkcv2.TabIndex = 2;
            this.chkcv2.Text = "chu vi";
            this.chkcv2.UseVisualStyleBackColor = true;
            // 
            // btnchuvi
            // 
            this.btnchuvi.Location = new System.Drawing.Point(150, 248);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(75, 23);
            this.btnchuvi.TabIndex = 3;
            this.btnchuvi.Text = "chu vi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // lblBK
            // 
            this.lblBK.AutoSize = true;
            this.lblBK.Location = new System.Drawing.Point(9, 48);
            this.lblBK.Name = "lblBK";
            this.lblBK.Size = new System.Drawing.Size(77, 13);
            this.lblBK.TabIndex = 4;
            this.lblBK.Text = "nhập bán kính";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(111, 41);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 5;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(29, 126);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(43, 13);
            this.lblKQ.TabIndex = 6;
            this.lblKQ.Text = "kết quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(111, 123);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbcv1);
            this.groupBox1.Controls.Add(this.rdbdt1);
            this.groupBox1.Location = new System.Drawing.Point(360, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn chắc năng";
            // 
            // rdbcv1
            // 
            this.rdbcv1.AutoSize = true;
            this.rdbcv1.Location = new System.Drawing.Point(6, 57);
            this.rdbcv1.Name = "rdbcv1";
            this.rdbcv1.Size = new System.Drawing.Size(54, 17);
            this.rdbcv1.TabIndex = 0;
            this.rdbcv1.TabStop = true;
            this.rdbcv1.Text = "chu vi";
            this.rdbcv1.UseVisualStyleBackColor = true;
            // 
            // rdbdt1
            // 
            this.rdbdt1.AutoSize = true;
            this.rdbdt1.Location = new System.Drawing.Point(6, 19);
            this.rdbdt1.Name = "rdbdt1";
            this.rdbdt1.Size = new System.Drawing.Size(70, 17);
            this.rdbdt1.TabIndex = 0;
            this.rdbdt1.TabStop = true;
            this.rdbdt1.Text = "diện tích ";
            this.rdbdt1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkcv2);
            this.groupBox2.Controls.Add(this.chkdt2);
            this.groupBox2.Location = new System.Drawing.Point(588, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "chọn chắc năng";
            // 
            // btntinh1
            // 
            this.btntinh1.Location = new System.Drawing.Point(401, 248);
            this.btntinh1.Name = "btntinh1";
            this.btntinh1.Size = new System.Drawing.Size(75, 23);
            this.btntinh1.TabIndex = 10;
            this.btntinh1.Text = "tính 1";
            this.btntinh1.UseVisualStyleBackColor = true;
            this.btntinh1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntinh2
            // 
            this.btntinh2.Location = new System.Drawing.Point(645, 248);
            this.btntinh2.Name = "btntinh2";
            this.btntinh2.Size = new System.Drawing.Size(75, 23);
            this.btntinh2.TabIndex = 10;
            this.btntinh2.Text = "tính 2";
            this.btntinh2.UseVisualStyleBackColor = true;
            this.btntinh2.Click += new System.EventHandler(this.btntinh2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinh2);
            this.Controls.Add(this.btntinh1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblBK);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.btndt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndt;
        private System.Windows.Forms.CheckBox chkdt2;
        private System.Windows.Forms.CheckBox chkcv2;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Label lblBK;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbcv1;
        private System.Windows.Forms.RadioButton rdbdt1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntinh1;
        private System.Windows.Forms.Button btntinh2;
    }
}

