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
        public void sortDelegate(Func<SV,SV,int> checkSort) {
            List<SV> svList = (List<SV>)dataGridView1.DataSource;
            svList.Sort(delegate (SV sv1, SV sv2)
            {
                return (checkSort(sv1, sv2));
            });
            dataGridView1.DataSource = svList;
        }
        

        

        private void Main_Load(object sender, EventArgs e)
        {
            setCBBSort();
            setCBBLop();
            dataGridView1.DataSource = CSDL_OOP.Instance.GetAllSV();

        }
        private void HandleCloseRequest(object sender, EventArgs e)
        {
            show_btn.PerformClick();
        }
        // Sort
        private int byMSSV(SV sv1, SV sv2)
        {
            return sv1.MSSV.CompareTo(sv2.MSSV);
        }

        private int byName(SV sv1,SV sv2)
        {
            return sv1.NameSV.CompareTo(sv2.NameSV);
        }
        private int byDate(SV sv1,SV sv2)
        {
            return sv1.NS.CompareTo(sv2.NS);
        }

      /*  public List<SV> getListById(List<int> mssvList)
        {
            List<SV> svList = new List<SV>();
            foreach (int mssv in mssvList)
            {
                SV sv = CSDL_OOP.Instance.getSVById(mssv.ToString());
                svList.Add(sv);
            }
            return svList;

        }*/
     /*   public void sortByMSSV(Func<int, int, bool> checkSort)
        {
            List<int> mssvList = new List<int>();
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                try
                {
                    int mssv = Convert.ToInt32(dr.Cells["MSSV"].Value);
                    mssvList.Add(mssv);
                }catch
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
        }*/
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
                new CBBItem {Value = 0,Text="MSSV"},
                new CBBItem {Value = 1,Text="Name"},
                new CBBItem {Value = 2,Text="NS"},

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
            SVForm svForm = new SVForm();
            passData pData = new passData(svForm.passData);
            svForm.ClosePanel += HandleCloseRequest;
            pData(new SV());
            svForm.Show();

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
           SV sv = (SV) dataGridView1.CurrentRow.DataBoundItem;
           // SVForm svForm = new SVForm(sv, this);
            SVForm svForm = new SVForm();
            svForm.ClosePanel += HandleCloseRequest;
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
                sortDelegate(byMSSV);
                //sortByMSSV(ascending);
            }
            else if (cb.Value == 1)
            {
                sortDelegate(byName);
                // sortByMSSV(descending);
            }
            else
            {
                sortDelegate(byDate);
            }
            
        }

       
    }
}
