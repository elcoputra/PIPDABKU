using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenghitungBiayaKuliah
{
    class PembayaranSKS
    {
        protected float hargaPerSKS;
        private int jumlahSKSYangDiperoleh;

        public PembayaranSKS()
        {
            this.hargaPerSKS = 40000;
            this.jumlahSKSYangDiperoleh = 0;
        }

        public float GetHargaPerSKS()
        {
            return this.hargaPerSKS;
        }

        public float HitungSKSYangHarusDibayar(int jumlahSKSYangDiperoleh)
        {
            this.jumlahSKSYangDiperoleh = jumlahSKSYangDiperoleh;
            float hasil = this.jumlahSKSYangDiperoleh * hargaPerSKS;
            return hasil;
        }
    }
}
