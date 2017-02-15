using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PenghitungBiayaKuliah
{
    /// <summary>
    /// Interaction logic for Menghitung.xaml
    /// </summary>
    /// 

    

    public partial class Menghitung : Window
    {
        private int[] sksPerMataKuliah = new int[10];
        private char[] nilaiPerMataKuliah = new char[10];
        private int indexArray = 0, noMatKul = 0;

        private void txtJumlahMatKul_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.Parse(txtJumlahMatKul.Text) > 10)
                txtJumlahMatKul.Text = "10";
            else if (int.Parse(txtJumlahMatKul.Text) <= 0)
                txtJumlahMatKul.Text = "1";
        }

        private void cmdOke_Click(object sender, RoutedEventArgs e)
        {
            gbDataMatKul.IsHitTestVisible = true;
            if (int.Parse(txtJumlahMatKul.Text) == 1)
            {
                cmdNext.IsEnabled = false;
                cmdHitung.IsEnabled = true;
            }

            lblNoMatKul.Content = "1";
            noMatKul = 2;

            txtJumlahMatKul.IsEnabled = false;
            cmdOke.IsEnabled = false;
        }

        private void txtSKSperMataKuliah_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtSKSperMataKuliah.Text == "")
                cmdNext.IsEnabled = false;
            else
                cmdNext.IsEnabled = true;
        }

        private void cmdNext_Click(object sender, RoutedEventArgs e)
        {
            if (indexArray < int.Parse(txtJumlahMatKul.Text))
            {
                if (indexArray < int.Parse(txtJumlahMatKul.Text) - 1)
                {
                    lblNoMatKul.Content = Convert.ToString(noMatKul);
                    noMatKul++;
                }
                else
                {
                    txtSKSperMataKuliah.IsEnabled = false;
                    comboNilaiPerMataKuliah.IsEnabled = false;
 
                    cmdNext.IsEnabled = false;
                    cmdHitung.IsEnabled = true;
                }
 
                sksPerMataKuliah[indexArray] = int.Parse(txtSKSperMataKuliah.Text);
                nilaiPerMataKuliah[indexArray] = char.Parse(comboNilaiPerMataKuliah.Text);
                indexArray++;
            }

            txtSKSperMataKuliah.Text = "";
            txtSKSperMataKuliah.Focus();
            comboNilaiPerMataKuliah.Text = "A";
        }

        private void cmdHitung_Click(object sender, RoutedEventArgs e)
        {
            gbHasilHitung.IsHitTestVisible = true;
            cmdHitung.IsEnabled = false;

            int jumlahMatKul = int.Parse(txtJumlahMatKul.Text);

            SKSSemesterIni objHitungSKS = new SKSSemesterIni(jumlahMatKul, sksPerMataKuliah, nilaiPerMataKuliah);

            float totalKNDiperoleh = objHitungSKS.HitungTotalKNDiperoleh();
            float totalSKSDiperoleh = objHitungSKS.HitungTotalSKSDiperoleh();

            float IPSemesterIni = objHitungSKS.HitungIPYangDiperoleh(totalSKSDiperoleh, totalKNDiperoleh);
            txtIP.Text = IPSemesterIni.ToString();

            int SKSSemesterIni = objHitungSKS.SKSYangDiperolehSemesterBaru(IPSemesterIni);
            txtSKSSemesterIni.Text = SKSSemesterIni.ToString();

            
            float SKSYangHarusDibayar = objHitungSKS.HitungSKSYangHarusDibayar(SKSSemesterIni);
            txtTotalSKSYangHarusDiBayar.Text = SKSYangHarusDibayar.ToString() + ",-";
 
            float hargaPerSKS = objHitungSKS.GetHargaPerSKS();
            txtHargaPerSKS.Text = hargaPerSKS.ToString() + ",-";
            
/*
            UbahHargaSKS objUbahHargaSKS = new UbahHargaSKS();
            float SKSYangHarusDibayar = objUbahHargaSKS.HitungSKSYangHarusDibayar(SKSSemesterIni, 45000);
            txtTotalSKSYangHarusDiBayar.Text = SKSYangHarusDibayar.ToString() + ",-";
            float hargaPerSKS = objUbahHargaSKS.GetHargaPerSKS();
            txtHargaPerSKS.Text = hargaPerSKS.ToString() + ",-";
*/        
    }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cmdInfo_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
            this.Close();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public Menghitung()
        {
            
            InitializeComponent();


        }

        
    }
}
