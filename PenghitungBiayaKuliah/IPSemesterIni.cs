using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenghitungBiayaKuliah
{
    class IPSemesterIni : PembayaranSKS
    {
        float totalSKSDiperoleh, totalKNDiperoleh;
        int JumlahSKSSemesterIni;

        // constructor
        public IPSemesterIni()
        {
            this.totalSKSDiperoleh = 0;
            this.totalKNDiperoleh = 0;
        }

        public IPSemesterIni(float totalSKSDiperoleh, float totalKNDiperoleh)
        {
            this.totalSKSDiperoleh = totalSKSDiperoleh;
            this.totalKNDiperoleh = totalKNDiperoleh;
        }

        public float HitungIPYangDiperoleh(float totalSKSDiperoleh, float totalKNDiperoleh)
        {
            return totalKNDiperoleh / totalSKSDiperoleh;
        }

        public int SKSYangDiperolehSemesterBaru(float IPSemesterIni)
        {
            if (IPSemesterIni <= 2.5) { JumlahSKSSemesterIni = 18; }
            else if ((IPSemesterIni > 2.5) && (IPSemesterIni < 3)) { JumlahSKSSemesterIni = 21; }
            else if (IPSemesterIni >= 3) { JumlahSKSSemesterIni = 24; }

            return JumlahSKSSemesterIni;
        }
    }
}
