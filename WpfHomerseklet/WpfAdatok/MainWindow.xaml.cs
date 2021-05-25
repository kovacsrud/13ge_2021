using Microsoft.Win32;
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

namespace WpfAdatok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VersenyzoAdatok versenyzok;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            try
            {
                if (dialog.ShowDialog() == true)
                {
                    versenyzok = new VersenyzoAdatok(dialog.FileName, ';', 1);
                    MessageBox.Show($"Adatok száma:{versenyzok.Versenyzok.Count}");
                    datagridAdatok.ItemsSource = versenyzok.Versenyzok;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }

            

        }

        private void buttonKereses_Click(object sender, RoutedEventArgs e)
        {
            if (versenyzok==null)
            {
                MessageBox.Show("Be kell tölteni az adatokat!");
            } else
            {
                var keresett = textboxKeresett.Text;

                var eredmeny = versenyzok.Versenyzok.FindAll(x=>x.Nev.ToLower().Contains(keresett.ToLower()));

                if (eredmeny.Count>0)
                {

                    datagridKereses.ItemsSource = eredmeny;

                } else
                {
                    MessageBox.Show("Nincs találat!");
                }
            }
        }
    }
}
