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
    { private Main main;
        private SV sv;
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
        public SVForm(SV sv,Main main) {
            this.sv = sv;
            InitializeComponent();
            this.main = main;
            
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

        private void ok_btn_Click(object sender, EventArgs e)
        {
            sv.MSSV = txt_MSSV.Text;
            sv.NameSV = txt_Name.Text;
            sv.NS = ns_picker.Value;
            CBBItem item = (CBBItem)lsh_cbb.SelectedItem;
            sv.ID_Lop = item.Value;
           
            if (CSDL_OOP.Instance.svIsExist(sv.MSSV))
            {
                CSDL_OOP.Instance.updateSV(sv);
            }
            else
            {
                CSDL_OOP.Instance.insertSV(sv);
            }
            main.Refresh();
            this.Close();
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
