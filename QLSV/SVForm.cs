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

        public event ClosePanelHandler ClosePanel;
        public delegate void ClosePanelHandler(object sender, EventArgs e);
        private SV sv;
        public void passData(SV sv)
        {
            this.sv = sv;
        }
        public SVForm()
        {

            InitializeComponent();
           
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
        public void setCBB()
        {
            foreach (LSH lsh in CSDL_OOP.Instance.GetAllLSH())
            {
                lsh_cbb.Items.Add(new CBBItem
                {
                    Value = lsh.ID_Lop,
                    Text = lsh.NameLop
                });
            }
            if (sv.MSSV == null)
            {
                lsh_cbb.SelectedIndex = 0;

            }
            else
            {
                for(int i = 0; i < lsh_cbb.Items.Count; i++)
                {
                    CBBItem cb = (CBBItem)lsh_cbb.Items[i];
                    if(cb.Value == sv.ID_Lop)
                    {
                        lsh_cbb.SelectedIndex = i;
                        break;
                    }
                }
            }
            
        }
        
        private void setData()
        {
            
            sv.MSSV = txt_MSSV.Text;
            sv.NameSV = txt_Name.Text;
            sv.NS = ns_picker.Value;
            CBBItem item = (CBBItem)lsh_cbb.SelectedItem;
            sv.ID_Lop = item.Value;
        }

        
        private bool validation()
        {
            bool check = false;
            if("".Equals(txt_Name.Text) || "".Equals(txt_MSSV.Text))
            {
                MessageBox.Show("Dieu thong tin day du di ban oi");

            }
            else if(!(int.TryParse(sv.MSSV,out int m)))
            {
                MessageBox.Show("MSSV chi nhan so thoi");
            }
            else
            {
                check = true; 
            }
            return check;
        }
        private void ok_btn_Click(object sender, EventArgs e)
        {
            setData();
            if (validation())
            {
                
                if (CSDL_OOP.Instance.svIsExist(sv.MSSV))
                {
                    CSDL_OOP.Instance.updateSV(sv);
                }
                else
                {
                    CSDL_OOP.Instance.insertSV(sv);
                }
                if (ClosePanel != null)
                {
                    ClosePanel(this, new EventArgs());
                }
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
