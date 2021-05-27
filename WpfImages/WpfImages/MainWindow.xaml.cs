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

namespace WpfImages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            image2.Source = new BitmapImage(new Uri("000085.jpg",UriKind.RelativeOrAbsolute));
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.jpg (JPG képek)|*.jpg|minden fájl(*.*)|*.*";
            if (dialog.ShowDialog()==true)
            {
                if (radioKep1.IsChecked==true)
                {
                    image1.Source = new BitmapImage(new Uri(dialog.FileName));
                } else
                {
                    image2.Source = new BitmapImage(new Uri(dialog.FileName));
                }
            }
        }
    }
}
