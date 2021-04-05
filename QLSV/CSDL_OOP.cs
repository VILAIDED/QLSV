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
