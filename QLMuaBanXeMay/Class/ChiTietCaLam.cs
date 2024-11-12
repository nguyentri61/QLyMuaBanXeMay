using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
    public class ChiTietCaLam
    {
        private int maCa;
        private int cCDNV;
        private string ghiChu="";

        public ChiTietCaLam()
        {
        }

        public int MaCa { get => maCa; set => maCa = value; }
        public int CCDNV { get => cCDNV; set => cCDNV = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
