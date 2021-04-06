using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
     class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; }
        public DateTime NS { get; set; }
        public int ID_Lop { get; set; }
        public SV() { NS = new DateTime(2000, 1, 1); }
        public override string ToString()
        {
            return NameSV + " : " + MSSV + NS + " " + ID_Lop;
        }
    }
}
