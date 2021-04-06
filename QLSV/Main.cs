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
        public delegate void passData(SV sv);
       
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
            SVForm svForm = new SVForm( this);
            svForm.Show();

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
           SV sv = (SV) dataGridView1.CurrentRow.DataBoundItem;
           // SVForm svForm = new SVForm(sv, this);
            SVForm svForm = new SVForm( this);
            passData pData = new passData(svForm.testDele);
            pData(sv);
            svForm.Show();

        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {

           
                SV sv = (SV)dataGridView1.CurrentRow.DataBoundItem;
                CSDL_OOP.Instance.deleteSV(sv.MSSV);
                show_btn.PerformClick();
            }
            else
            {
                MessageBox.Show("Xoa chi nua ban oi");
            }
        }
    }
}
