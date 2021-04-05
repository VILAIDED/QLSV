using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Main : Form
    {
        private CSDL test;
        public Main()
        {
            InitializeComponent();
        }
        public void setCBB (){
            lopSH_cbb.Items.Add(new CBBItem { Value = 0, Text = "All" });
            foreach(LSH lsh in CSDL_OOP.Instance.GetAllLSH())
            {
                lopSH_cbb.Items.Add(new CBBItem
                {
                    Value = lsh.ID_Lop,
                    Text = lsh.NameLop
                }) ;

            }
        }
        public void showListSV(int ID_Lop,string Name)
        {
            dataGridView1.DataSource = CSDL_OOP.Instance.GetListSV(ID_Lop, Name);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CSDL_OOP.Instance.GetAllSV();
            setCBB();
            lopSH_cbb.SelectedIndex = 0;
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            CBBItem cb = (CBBItem)lopSH_cbb.SelectedItem;
            if(cb.Value == 0)
            {
                dataGridView1.DataSource = CSDL_OOP.Instance.GetAllSV();
            }
            else
            {
                showListSV(cb.Value, "");
            }
            
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            CBBItem cb = (CBBItem)lopSH_cbb.SelectedItem;
            if ("".Equals(search_txt.Text) && cb.Value == 0)
            {
                dataGridView1.DataSource = CSDL_OOP.Instance.GetAllSV();
            }else
            showListSV(cb.Value, search_txt.Text);
         
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
           SV sv = (SV) dataGridView1.CurrentRow.DataBoundItem;
            MessageBox.Show(sv.ToString());
        }
    }
}
