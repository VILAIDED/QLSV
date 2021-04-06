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
    public partial class SVForm : Form
    { 
        private Main main;
        private SV sv;
        public void testDele(SV sv)
        {
            this.sv = sv;
        }
        public void setCBB()
        {
            if (sv.MSSV == null)
            {
                foreach(LSH lsh in CSDL_OOP.Instance.GetAllLSH())
                {
                    lsh_cbb.Items.Add(new CBBItem
                    {
                        Value = lsh.ID_Lop,
                        Text = lsh.NameLop
                    });
                }

            }
            else
            {
                LSH lsh = CSDL_OOP.Instance.GetLSHById(sv.ID_Lop);
                lsh_cbb.Items.Add(new CBBItem { Value = lsh.ID_Lop, Text = lsh.NameLop });
                
            }
            lsh_cbb.SelectedIndex = 0;

        }
        public SVForm(Main main) {
       
            InitializeComponent();
            this.main = main;
            
        }
        private void setData()
        {
            sv.MSSV = txt_MSSV.Text;
            sv.NameSV = txt_Name.Text;
            sv.NS = ns_picker.Value;
            CBBItem item = (CBBItem)lsh_cbb.SelectedItem;
            sv.ID_Lop = item.Value;
        }

        private void SVForm_Load(object sender, EventArgs e)
        {
            
            if (sv.MSSV != null) txt_MSSV.ReadOnly = true;
            txt_MSSV.Text = sv.MSSV;
            txt_Name.Text = sv.NameSV;
            ns_picker.Value = sv.NS;
            if (sv.Gender)
            {
                m_Radio.Checked = true;
            }
            else
            {
                f_Radio.Checked = true;
            }
            setCBB();
            
        }
        private bool validation()
        {
            bool check = false;
            if(!("".Equals(txt_Name.Text) || "".Equals(txt_MSSV.Text)))
            {
                return true;
               
            }
            else
            {
                MessageBox.Show("Dieu thong tin day du di ban oi");
            }
            return check;
        }
        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                setData();
                if (CSDL_OOP.Instance.svIsExist(sv.MSSV))
                {
                    CSDL_OOP.Instance.updateSV(sv);
                }
                else
                {
                    CSDL_OOP.Instance.insertSV(sv);
                }
                main.showListSV("");
                this.Close();
            }
           
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if(m_Radio.Checked == true)
            {
                sv.Gender = false;
            }
        }

        private void f_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if(f_Radio.Checked == true)
            {
                sv.Gender = true;
            }
        }
    }
}
