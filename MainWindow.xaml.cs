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

namespace U1CareersKeegan
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

        private void btnPage1_Click(object sender, RoutedEventArgs e)
        {
            txbColumn1.Text = "Corsair Vengeance C70 Mid-Tower Gaming Case";
            txbColumn2.Text = "http://www.corsair.com/en-us/vengeance-c70-mid-tower-gaming-case-gunmetal-black";
            txbColumn3.Text = "159.99$";
            txbColumn4.Text = "1";
            BitmapImage bi = new BitmapImage(new Uri("https://www.telemart.pk/media/catalog/product/cache/7/thumbnail/9df78eab33525d08d6e5fb8d27136e95/c/c/ccgreen.jpg"));
            imgComPart.Source = bi;
        }

        private void btnPage2_Click(object sender, RoutedEventArgs e)
        {
            txbColumn1.Text = "AMD - Ryzen 5 1600 3.2GHz 6-Core Processor";
            txbColumn2.Text = "https://www.amd.com/en/products/cpu/amd-ryzen-5-1600";
            txbColumn3.Text = "238.95$";
            txbColumn4.Text = "2";
            BitmapImage bi = new BitmapImage(new Uri("https://c.76.my/Malaysia/amd-ryzen-5-1600-processor-3-6ghz-19mb-cache-am4-saveallstore-1704-17-F379278_1.jpg"));
            imgComPart.Source = bi;
        }

        private void btnPage3_Click(object sender, RoutedEventArgs e)
        {
            txbColumn1.Text = "MSI - B350 PC MATE ATX AM4 Motherboard";
            txbColumn2.Text = "https://www.msi.com/Motherboard/B350-PC-MATE.html";
            txbColumn3.Text = "109.00$";
            txbColumn4.Text = "3";
            BitmapImage bi = new BitmapImage(new Uri("https://images-na.ssl-images-amazon.com/images/I/61LrNFyFJqL.jpg"));
            imgComPart.Source = bi;
        }
        private void btnPage4_Click(object sender, RoutedEventArgs e)
        {
            txbColumn1.Text = "Seagate - Barracuda 2TB 3.5 inches 7200RPM Internal Hard Drive";
            txbColumn2.Text = "https://www.seagate.com/ca/en/internal-hard-drives/hdd/barracuda/";
            txbColumn3.Text = "69.49$";
            txbColumn4.Text = "4";
            BitmapImage bi = new BitmapImage(new Uri("https://www.webantics.com/content/images/thumbs/007/0070614_seagate-barracuda-2tb-sata-iii-7200rpm-35-internal-hard-drive_600.jpeg"));
            imgComPart.Source = bi;
        }
    }
}
