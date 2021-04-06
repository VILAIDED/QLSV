
namespace QLSV
{
    partial class SVForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.f_Radio = new System.Windows.Forms.RadioButton();
            this.m_Radio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ns_picker = new System.Windows.Forms.DateTimePicker();
            this.lsh_cbb = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.ok_btn);
            this.panel1.Controls.Add(this.f_Radio);
            this.panel1.Controls.Add(this.m_Radio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ns_picker);
            this.panel1.Controls.Add(this.lsh_cbb);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.txt_MSSV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(453, 308);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 12;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(300, 308);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 11;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // f_Radio
            // 
            this.f_Radio.AutoSize = true;
            this.f_Radio.Location = new System.Drawing.Point(624, 129);
            this.f_Radio.Name = "f_Radio";
            this.f_Radio.Size = new System.Drawing.Size(75, 21);
            this.f_Radio.TabIndex = 10;
            this.f_Radio.TabStop = true;
            this.f_Radio.Text = "Female";
            this.f_Radio.UseVisualStyleBackColor = true;
            this.f_Radio.CheckedChanged += new System.EventHandler(this.f_Radio_CheckedChanged);
            // 
            // m_Radio
            // 
            this.m_Radio.AutoSize = true;
            this.m_Radio.Location = new System.Drawing.Point(508, 129);
            this.m_Radio.Name = "m_Radio";
            this.m_Radio.Size = new System.Drawing.Size(59, 21);
            this.m_Radio.TabIndex = 9;
            this.m_Radio.TabStop = true;
            this.m_Radio.Text = "Male";
            this.m_Radio.UseVisualStyleBackColor = true;
            this.m_Radio.CheckedChanged += new System.EventHandler(this.m_Radio_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // ns_picker
            // 
            this.ns_picker.Location = new System.Drawing.Point(440, 49);
            this.ns_picker.Name = "ns_picker";
            this.ns_picker.Size = new System.Drawing.Size(259, 22);
            this.ns_picker.TabIndex = 7;
            // 
            // lsh_cbb
            // 
            this.lsh_cbb.FormattingEnabled = true;
            this.lsh_cbb.Location = new System.Drawing.Point(107, 129);
            this.lsh_cbb.Name = "lsh_cbb";
            this.lsh_cbb.Size = new System.Drawing.Size(121, 24);
            this.lsh_cbb.TabIndex = 6;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(107, 89);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(121, 22);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(107, 49);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(121, 22);
            this.txt_MSSV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lop SH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thong tin SV";
            // 
            // SVForm
            // 
            this.AcceptButton = this.ok_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SVForm";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.SVForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.RadioButton f_Radio;
        private System.Windows.Forms.RadioButton m_Radio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ns_picker;
        private System.Windows.Forms.ComboBox lsh_cbb;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}