using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{
    public class Voucher
    {
        private int maVC;
        private string tenVC;
        private double giatri;
        private double giamgia;
        private DateTime ngayHH;
        private double ggToida;

        public Voucher() { }

        public Voucher(int maVC, string tenVC, double giatri, double giamgia, DateTime ngayHH, double ggToida)
        {
            this.maVC = maVC;
            this.tenVC = tenVC;
            this.giatri = giatri;
            this.giamgia = giamgia;
            this.ngayHH = ngayHH;
            this.ggToida = ggToida;
        }

        public int MaVC { get => maVC; set => maVC = value; }
        public string TenVC { get => tenVC; set => tenVC = value; }
        public double Giatri { get => giatri; set => giatri = value; }
        public double Giamgia { get => giamgia; set => giamgia = value; }
        public DateTime NgayHH { get => ngayHH; set => ngayHH = value; }
        public double GgToida { get => ggToida; set => ggToida = value; }
    }
}
