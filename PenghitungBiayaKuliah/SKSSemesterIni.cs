using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenghitungBiayaKuliah
{
    class SKSSemesterIni : IPSemesterIni
    {
        private int jumlahMataKuliah;
        private int[] sksPerMataKuliah = new int[10];
        private char[] nilaiPerMataKuliah = new char[10];
        private float totalSKSDiperoleh, totalKNDiperoleh;

        private int i, nilaiDalamAngka, temp = 0;

        // constructor       
        public SKSSemesterIni(int jumlahMataKuliah, int[] sksPerMataKuliah, char[] nilaiPerMataKuliah)
        {

            this.jumlahMataKuliah = jumlahMataKuliah;
            this.sksPerMataKuliah = sksPerMataKuliah;
            this.nilaiPerMataKuliah = nilaiPerMataKuliah;
        }

        // namanya bukan SKS => K.N, else?
        public float HitungTotalKNDiperoleh()
        {
            for (i = 0; i < jumlahMataKuliah; i++)
            {
                switch (nilaiPerMataKuliah[i])
                {
                    case 'A':
                        nilaiDalamAngka = 4;
                        break;

                    case 'B':
                        nilaiDalamAngka = 3;
                        break;

                    case 'C':
                        nilaiDalamAngka = 2;
                        break;

                    case 'D':
                        nilaiDalamAngka = 1;
                        break;

                    case 'E':
                        nilaiDalamAngka = 0;
                        break;

                    default:
                        nilaiDalamAngka = 0;
                        break;
                }

                temp = sksPerMataKuliah[i] * nilaiDalamAngka;
                totalKNDiperoleh = totalKNDiperoleh + temp;
            }

            return totalKNDiperoleh;
        }

        public float HitungTotalSKSDiperoleh()
        {
            for (i = 0; i < jumlahMataKuliah; i++)
            {
                totalSKSDiperoleh += sksPerMataKuliah[i];
            }

            return totalSKSDiperoleh;


        }
    }
}
