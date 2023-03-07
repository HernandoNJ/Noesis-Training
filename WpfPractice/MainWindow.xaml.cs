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

namespace WpfPractice
{
    /// <summary> Interaction logic for MainWindow.xaml </summary>
    public partial class MainWindow : Window
    {
        public Image mainImage;
        public Image image0;
        public Image image1;
        public Image image2;
        public Image image3;
        public Image image4;

        public MainWindow()
        {
            InitializeComponent();
            GetImageReferences();
        }

        private void GetImageReferences()
        {
            mainImage = (Image)FindName("Main_image");
            image0 = (Image)FindName("Image0");
            image1 = (Image)FindName("Image1");
            image2 = (Image)FindName("Image2");
            image3 = (Image)FindName("Image3");
            image4 = (Image)FindName("Image4");

            Console.WriteLine("Image 0: " + image0.Name);
            Console.WriteLine("Image 1: " + image1.Name);
        }

        private void ImageClicked(object sender, MouseButtonEventArgs e)
        {
            var imageSender = (Image)sender;
            var imageName = imageSender.Name;

            Console.WriteLine("Image sender: " + imageName); 
            if (imageName == "Image0") mainImage.Source = image0.Source;
            else if (imageName == "Image1") mainImage.Source = image1.Source;
            else if (imageName == "Image2") mainImage.Source = image2.Source;
            else if (imageName == "Image3") mainImage.Source = image3.Source;
            else if (imageName == "Image4") mainImage.Source = image4.Source;
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
