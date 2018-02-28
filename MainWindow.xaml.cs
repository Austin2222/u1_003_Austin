/// Austin
/// 2/23/2018
/// u1_003_Austin
/// This program will show an image, and has two buttons to either go to the next, or previous image



/// http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=10034004&CatId=9594    Motherboard
/// http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=9973878&CatId=11637    RAM
/// http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=8189594&CatId=11994    Power Source
/// http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=9803989&CatId=3427     Starting Peice_Case
/// http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=10000015&CatId=11862   Processor


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

namespace Example_Image
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int imgcount = 0;
        List<string> lst = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            lst.Add("https://images10.newegg.com/BizIntell/item/11/133/11-133-274/CoreV211118_1.jpg"); ///list pos 0
            lst.Add("http://ecx.images-amazon.com/images/I/51A26GiRGKL.jpg");///list pos 1
            lst.Add("http://hexus.net/media/uploaded/2016/11/1e0185ae-b767-4e93-a74b-54fac867da0c.jpg");///list pos 2
            lst.Add("https://images-na.ssl-images-amazon.com/images/I/41hoB-ZpXCL._SY355_.jpg");///list pos 3
            lst.Add("https://www.ple.com.au//imagelibrary/inventoryitemimages/84070-623579-full.jpg");///list pos 4


        }

        private void bttnNxtImg_Click(object sender, RoutedEventArgs e)
        {
            if (imgcount < 4)
            {
                imgcount += 1;
                BitmapImage bi = new BitmapImage(new Uri(lst[imgcount]));

                imgPicture.Source = bi;
            }
        }

        private void bttnPrvsImg_Click(object sender, RoutedEventArgs e)
        {
            if (imgcount > 0)
            {
                imgcount -= 1;
                BitmapImage bi = new BitmapImage(new Uri(lst[imgcount]));
                imgPicture.Source = bi;
            }
        }
    }
}
