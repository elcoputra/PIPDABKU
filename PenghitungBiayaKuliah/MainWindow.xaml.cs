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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PenghitungBiayaKuliah
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EXIT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ABOUT_Click(object sender, RoutedEventArgs e)
        {
            About about1 = new About();
            about1.Show();
            this.Close();
        }

        private void mulai_Click(object sender, RoutedEventArgs e)
        {
            Menghitung menghitun1 = new Menghitung();
            menghitun1.Show();
            this.Close();
        }
    }
}
