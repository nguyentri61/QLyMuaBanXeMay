using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
    public class CaLam
    {
        private int maCa;
        private DateTime tGBatDau;
        private DateTime tGKetThuc;
        private int cCCDQL;

        public int MaCa { get => maCa; set => maCa = value; }
        public DateTime TGBatDau { get => tGBatDau; set => tGBatDau = value; }
        public DateTime TGKetThuc { get => tGKetThuc; set => tGKetThuc = value; }
        public int CCCDQL { get => cCCDQL; set => cCCDQL = value; }

        public CaLam()
        {

        }
        public CaLam(int maCa, DateTime tgBatDau, DateTime tgKetThuc, int cccDQL)
        {
            MaCa = maCa;
            TGBatDau = tgBatDau;
            TGKetThuc = tgKetThuc;
            CCCDQL = cccDQL;
        }
    }
}
