
namespace QLSV
{
    partial class Main
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
            this.lopSH_cbb = new System.Windows.Forms.ComboBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.show_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.sort_btn = new System.Windows.Forms.Button();
            this.sort_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lopSH_cbb
            // 
            this.lopSH_cbb.FormattingEnabled = true;
            this.lopSH_cbb.Location = new System.Drawing.Point(123, 37);
            this.lopSH_cbb.Name = "lopSH_cbb";
            this.lopSH_cbb.Size = new System.Drawing.Size(121, 24);
            this.lopSH_cbb.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(582, 41);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sach SV";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(749, 213);
            this.dataGridView1.TabIndex = 5;
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(63, 354);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(75, 23);
            this.show_btn.TabIndex = 6;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(192, 354);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(312, 353);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 8;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(421, 353);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 23);
            this.del_btn.TabIndex = 9;
            this.del_btn.Text = "Del";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // sort_btn
            // 
            this.sort_btn.Location = new System.Drawing.Point(534, 353);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(75, 23);
            this.sort_btn.TabIndex = 10;
            this.sort_btn.Text = "Sort";
            this.sort_btn.UseVisualStyleBackColor = true;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click);
            // 
            // sort_comboBox
            // 
            this.sort_comboBox.FormattingEnabled = true;
            this.sort_comboBox.Location = new System.Drawing.Point(661, 353);
            this.sort_comboBox.Name = "sort_comboBox";
            this.sort_comboBox.Size = new System.Drawing.Size(121, 24);
            this.sort_comboBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lop SH";
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(461, 42);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(100, 22);
            this.search_txt.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 430);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sort_comboBox);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.lopSH_cbb);
            this.Name = "Main";
            this.Text = "o";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lopSH_cbb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.ComboBox sort_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_txt;
    }
}

