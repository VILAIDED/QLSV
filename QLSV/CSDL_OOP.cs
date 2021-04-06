using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class CSDL_OOP
    {
        private static CSDL_OOP _Instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new CSDL_OOP();
                    return _Instance;
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
        private CSDL_OOP()
        {
           

        }
        public List<SV> GetAllSV()
        {
            List<SV> svList = new List<SV>();
            DataTable dtSV = CSDL.Instance.DTSV;
            foreach(DataRow dr in dtSV.Rows)
            {
               
                svList.Add(GetSV(dr));


            }
            return svList;
        }
        public SV GetSV(DataRow i)
        {
            return new SV
            {
                ID_Lop = Convert.ToInt32(i["ID_Lop"]),
                MSSV = i["MSSV"].ToString(),
                NameSV = i["NameSV"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"]),
                NS = Convert.ToDateTime(i["NS"])
            };
        }
        public List<LSH> GetAllLSH()
        {
            List<LSH> lshList = new List<LSH>();
            DataTable dtSH = CSDL.Instance.DTLSH;
            foreach(DataRow dr in dtSH.Rows)
            {
                
                lshList.Add(GetLSH(dr));
            }
            return lshList;

        }
        public LSH GetLSH(DataRow i)
        {

            return new LSH
            {
                ID_Lop = Convert.ToInt32(i["ID_Lop"]),
                NameLop = i["NameLop"].ToString()
            };
        }
        public LSH GetLSHById(int ID_Lop)
        {
            LSH lsh = new LSH();
            foreach(LSH ls in GetAllLSH())
            {
                if(ID_Lop == ls.ID_Lop)
                {
                    lsh = ls;
                    break;
                }
            }
            return lsh;
        }
        public SV getSVById(string mssv)
        {
            SV sv = new SV();
            foreach(SV s in GetAllSV())
            {
                if (mssv.Equals(s.MSSV))
                {
                    sv = s;
                    break;
                }
            }
            return sv;
        }
        public void deleteSV(String MSSV)
        {
            DataTable dtSV = new DataTable();
            dtSV = CSDL.Instance.DTSV;
          /*  for (int i = 0; i < dtSV.Rows.Count; i++)
            {
                DataRow dr = dtSV.Rows[i];
                if (dr["MSSV"].Equals(MSSV))
                {
                    dr.Delete();
                    break;
                }
            }*/
          foreach(DataRow dr in dtSV.Rows)
            {
                if (dr["MSSV"].Equals(MSSV))
                {
                    dr.Delete();
                    break;
                }
            }
            dtSV.AcceptChanges();
            CSDL.Instance.DTSV = dtSV;
        }
        public void updateSV(SV sv)
        {
            DataTable dtSV = new DataTable();
            dtSV = CSDL.Instance.DTSV;
            foreach (DataRow dr in dtSV.Rows) {
                if (dr["MSSV"].Equals(sv.MSSV))
                {

                    dr["NameSV"] = sv.NameSV;
                    dr["Gender"] = sv.Gender;
                    dr["NS"] = sv.NS;
                    dr["ID_Lop"] = sv.ID_Lop;

                    break;
                }
            }
        
            dtSV.AcceptChanges();
            CSDL.Instance.DTSV = dtSV;
        }
        public void insertSV(SV sv)
        {
            DataRow drSV = CSDL.Instance.DTSV.NewRow();
            drSV["MSSV"] = sv.MSSV;
            drSV["NameSV"] = sv.NameSV;
            drSV["Gender"] = sv.Gender;
            drSV["NS"] = sv.NS;
            drSV["ID_Lop"] = sv.ID_Lop;
            CSDL.Instance.DTSV.Rows.Add(drSV);
        }
        public bool svIsExist(string MSSV)
        {
            bool check = false;
            foreach(SV sv in GetAllSV())
            {
                if (sv.MSSV.Equals(MSSV))
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public List<SV> GetListSV(int ID_Lop,string Name)
        {
            List<SV> svList = new List<SV>();
            if ("".Equals(Name))
            {
                foreach (SV sv in GetAllSV())
                {
                    if (sv.ID_Lop == ID_Lop)
                    {
                        svList.Add(sv);
                    }
            }
            }
            else
            {
                foreach (SV sv in GetAllSV())
                {
                    if (ID_Lop == 0)
                    {

                        if (sv.NameSV.Equals(Name))
                        {
                            svList.Add(sv);
                        }
                    }
                    else
                    {
                        if (sv.ID_Lop == ID_Lop && sv.NameSV.Equals(Name))
                        {
                            svList.Add(sv);
                        }
                    }
            }
            }
            return svList;
            
        }
    }
}
