using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class CSDL
    {
        private static CSDL _Instance;
        public DataTable DTSV { get; set; }
        public DataTable DTLSH { get; set; }
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    return _Instance = new CSDL();
                }
                else
                {


                    return _Instance;
                }
            }
            set
            {

            }
        }
        private CSDL()
        {
            DataTable dtSH = new DataTable();
            dtSH.Columns.AddRange(new DataColumn[]
            {
                        new DataColumn("ID_Lop",typeof(int)),
                        new DataColumn("NameLop",typeof(String))
            });
           
            for(int i = 0; i < 5; i++)
            {

                DataRow drSH = dtSH.NewRow();
                drSH["ID_Lop"] = "19" + (i+1);
                drSH["NameLop"] = "19TCLC_DT" + (i + 1);
                dtSH.Rows.Add(drSH); 
            }
            DataTable dtSV = new DataTable();
            dtSV.Columns.AddRange(new DataColumn[]
            {

                new DataColumn("MSSV",typeof(String)),
                new DataColumn("NameSV" ,typeof(String)),
                new DataColumn("Gender",typeof(Boolean)),
                new DataColumn("NS",typeof(DateTime)),
                new DataColumn("ID_Lop",typeof(int))
            });
           
            for(int i= 0; i < dtSH.Rows.Count; i++)
            {
                for(int j = 0; j <= 5; j++)
                {
                    DataRow drSV = dtSV.NewRow();
                      drSV["MSSV"] = dtSH.Rows[i]["ID_Lop"].ToString() + j ;
                      drSV["NameSV"] = j % 2 == 0 ? "Nguyen Van " + (char)(j+65) : "Nguyen Cong " + (char)(j + 65);
                      drSV["Gender"] = j % 2 == 0 ? true.ToString() : false.ToString();
                      drSV["NS"] =  new DateTime(2001,j+1,i+j+5);
                        drSV["ID_Lop"] = dtSH.Rows[i]["ID_Lop"].ToString();
                   
                       dtSV.Rows.Add(drSV);
                }
                
            }
            DTLSH = dtSH;
            DTSV = dtSV;

        }
    }
}
