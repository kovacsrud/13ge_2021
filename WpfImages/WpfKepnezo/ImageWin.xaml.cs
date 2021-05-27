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

namespace WpfKepnezo
{
    /// <summary>
    /// Interaction logic for ImageWin.xaml
    /// </summary>
    public partial class ImageWin : Window
    {
        public ImageWin()
        {
            InitializeComponent();
        }

        public ImageWin(Image kep)
        {
            InitializeComponent();
            nagyKep.Source = kep.Source;
            this.Width = nagyKep.Source.Width;
            this.Height = nagyKep.Source.Height;
        }
    }
}
