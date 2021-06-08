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

namespace WpfEladasok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameData gameData;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog()==true)
            {
                try
                {
                    gameData = new GameData(dialog.FileName,';',1);
                    MessageBox.Show($"Betöltött adatsorok száma:{gameData.Games.Count}");
                    tabKereses.IsEnabled = true;
                    datagridAdatok.ItemsSource = gameData.Games;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace,"Hiba!",MessageBoxButton.OK,MessageBoxImage.Error);                    
                }
            }

        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            var eredmeny = gameData.Games.FindAll(x=>x.Name.ToLower().Contains(textboxName.Text.ToLower()));
            datagridKereses.ItemsSource = null;
            

            if (eredmeny.Count==0)
            {
                MessageBox.Show("Nincs a feltételnek megfelelő adat!", "Információ", MessageBoxButton.OK, MessageBoxImage.Information);
            } else
            {
                datagridKereses.ItemsSource = eredmeny;
            }

        }
    }
}
