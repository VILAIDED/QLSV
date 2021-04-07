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
        /*    public void sortList(Func<bool> checkSort )
        {
            List<SV> svList = dataGridView1.DataSource as List<SV>;
            for(int i = 0; i < svList.Count; i++)
            {
                for(int j = 0; j < svList.Count; j++)
                {
                    if (Convert.ToInt32(svList[i].MSSV) > Convert.ToInt32(svList[j].MSSV))
                    {
                        SV tmp = svList[i];
                        svList[i] = svList[j];
                        svList[j] = tmp;
                        
                    }
                }
             
            }
            dataGridView1.DataSource = svList;
        }*/
        public Main()
        {  
            InitializeComponent(); 
        }
        private void Main_Load(object sender, EventArgs e)
        {
            setCBBSort();
            setCBBLop();
            dataGridView1.DataSource = CSDL_OOP.Instance.GetAllSV();

        }
        // Sort
        public bool descending(int i, int j)
        {
            return i > j;
        }

        public bool ascending(int i, int j)
        {
            return i < j;
        }

        public List<SV> getListById(List<int> mssvList)
        {
            List<SV> svList = new List<SV>();
            foreach (int mssv in mssvList)
            {
                SV sv = CSDL_OOP.Instance.getSVById(mssv.ToString());
                svList.Add(sv);
            }
            return svList;

        }
        public void sortByMSSV(Func<int, int, bool> checkSort)
        {
            List<int> mssvList = new List<int>();
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                try
                {
                    int mssv = Convert.ToInt32(dr.Cells["MSSV"].Value);
                    mssvList.Add(mssv);
                }catch(Exception ex)
                {
                    continue;
                }
            }
            for (int i = 0; i < mssvList.Count; i++)
            {
                for (int j = 0; j < mssvList.Count; j++)
                {
                    if (checkSort(mssvList[i], mssvList[j]))
                    {
                        int tmp = mssvList[i];
                        mssvList[i] = mssvList[j];
                        mssvList[j] = tmp;

                    }
                }

            }
            dataGridView1.DataSource = getListById(mssvList);
        }
        public void setCBBLop (){
            lopSH_cbb.Items.Add(new CBBItem { Value = 0, Text = "All" });
            foreach(LSH lsh in CSDL_OOP.Instance.GetAllLSH())
            {
                lopSH_cbb.Items.Add(new CBBItem
                {
                    Value = lsh.ID_Lop,
                    Text = lsh.NameLop
                }) ;

            }
            lopSH_cbb.SelectedIndex = 0;
        }

        private void setCBBSort()
        {
            sort_comboBox.Items.AddRange(new CBBItem[]
           {
                new CBBItem {Value = 0,Text="ascending"},
                new CBBItem {Value = 1,Text="descending"},
           });
            sort_comboBox.SelectedIndex = 0;
        }

        public void showListSV(string name)
        {
            CBBItem cb = (CBBItem)lopSH_cbb.SelectedItem;
                dataGridView1.DataSource = CSDL_OOP.Instance.GetListSV(cb.Value, name);
            
            
        }
      
      
        //btn click
        private void show_btn_Click(object sender, EventArgs e)
        {
            showListSV("");
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            CBBItem cb = (CBBItem)lopSH_cbb.SelectedItem;
            showListSV(search_txt.Text);
         
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            SVForm svForm = new SVForm( this);
            passData pData = new passData(svForm.passData);
            pData(new SV());
            svForm.Show();

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
           SV sv = (SV) dataGridView1.CurrentRow.DataBoundItem;
           // SVForm svForm = new SVForm(sv, this);
            SVForm svForm = new SVForm( this);
            passData pData = new passData(svForm.passData);
            pData(sv);
            svForm.Show();

        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {

                
                string mssv;
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    mssv = row.Cells["MSSV"].Value.ToString();
                    // mssvList.Add(row.Cells["MSSV"].Value.ToString());
                    CSDL_OOP.Instance.deleteSV(mssv);
                }
                /*SV sv = (SV)dataGridView1.CurrentRow.DataBoundItem;
                CSDL_OOP.Instance.deleteSV(sv.MSSV);*/
                show_btn.PerformClick();
            }
            else
            {
                MessageBox.Show("Xoa chi nua ban oi");
            }
        }

        private void sort_btn_Click(object sender, EventArgs e)
        {
            CBBItem cb = (CBBItem)sort_comboBox.SelectedItem;
            if(cb.Value == 0)
            {
                sortByMSSV(ascending);
            }
            else
            {
                sortByMSSV(descending);
            }
            
        }

       
    }
}
