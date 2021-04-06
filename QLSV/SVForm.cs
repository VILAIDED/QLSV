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
        private SV sv;
        public void setCBB()
        {
            if ("".Equals(sv.MSSV))
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
                lsh_cbb.SelectedIndex = 0;
            }
            
        }
        public SVForm(SV sv,Main main) {
            this.sv = sv;
            InitializeComponent();
        }

        private void SVForm_Load(object sender, EventArgs e)
        {
            if (!("".Equals(sv.MSSV))) txt_MSSV.ReadOnly = true;
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
            if (CSDL_OOP.Instance.svIsExist(sv.MSSV))
            {
                CSDL_OOP.Instance.updateSV(sv);
            }
            else
            {
                CSDL_OOP.Instance.insertSV(sv);
            }
        }
    }
}
