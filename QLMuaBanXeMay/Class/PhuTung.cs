using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLMuaBanXeMay.Class
{

    public class PhuTung
    {
        private int maPT;
        private string tenPT;
        private double donGia;
        private string chatLieu;
        private string hangSX;
        private int soLuongTon;

        public PhuTung() { }

        public PhuTung(int maPT, string tenPT, double donGia, string chatLieu, string hangSX, int soLuongTon)
        {
            this.maPT = maPT;
            this.tenPT = tenPT;
            this.donGia = donGia;
            this.chatLieu = chatLieu;
            this.hangSX = hangSX;
            this.soLuongTon = soLuongTon;
        }

        public int MaPT
        {
            get { return maPT; }
            set { maPT = value; }
        }

        public string TenPT
        {
            get { return tenPT; }
            set { tenPT = value; }
        }

        public double DonGia
        {
            get { return donGia; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("DonGia must be greater than 0.");
                donGia = value;
            }
        }

        public string ChatLieu
        {
            get { return chatLieu; }
            set { chatLieu = value; }
        }

        public string HangSX
        {
            get { return hangSX; }
            set { hangSX = value; }
        }

        public int SoLuongTon
        {
            get { return soLuongTon; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("SoLuongTon must be greater than 0.");
                soLuongTon = value;
            }
        }
    }

}
