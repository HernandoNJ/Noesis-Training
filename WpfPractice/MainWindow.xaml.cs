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
        private List<Image> imagesList = new List<Image>();
        private List<ImageSource> imagesSourceList = new List<ImageSource>();
        private Dictionary<string, ImageSource> imagesDictionary = new Dictionary<string, ImageSource>();

        private Image mainImage;

        private Image imageA;
        private Image imageB;
        private Image imageC;
        private Image imageD;
        private Image imageE;

        public MainWindow()
        {
            InitializeComponent();
            FindImageNames();
            AddImagesToList();
            AssignInitialSources();
            ResetImagesSources();
            AssignSourcesToDictionary();
            SetMainImage(imageC);
        }
        private void FindImageNames()
        {
            mainImage = (Image)FindName("Main_image");

            imageA = (Image)FindName("ImageA");//moraine sm
            imageB = (Image)FindName("ImageB");//ian gf
            imageC = (Image)FindName("ImageC");//bri dl
            imageD = (Image)FindName("ImageD");//green gm
            imageE = (Image)FindName("ImageE");//james ls
        }

        private void AddImagesToList()
        {
            imagesList.Add(imageA);
            imagesList.Add(imageB);
            imagesList.Add(imageC);
            imagesList.Add(imageD);
            imagesList.Add(imageE);
        }

        private void AssignInitialSources()
        {
            imagesSourceList.Add(imageA.Source);
            imagesSourceList.Add(imageB.Source);
            imagesSourceList.Add(imageC.Source);
            imagesSourceList.Add(imageD.Source);
            imagesSourceList.Add(imageE.Source);
        }

        private void ResetImagesSources()
        {
            imageA.Source = imagesSourceList[0];
            imageB.Source = imagesSourceList[1];
            imageC.Source = imagesSourceList[2];
            imageD.Source = imagesSourceList[3];
            imageE.Source = imagesSourceList[4];
        }

        private void AssignSourcesToDictionary()
        {
            imagesDictionary.Add("ImageA", ImageA.Source);
            imagesDictionary.Add("ImageB", ImageB.Source);
            imagesDictionary.Add("ImageC", ImageC.Source);
            imagesDictionary.Add("ImageD", ImageD.Source);
            imagesDictionary.Add("ImageE", ImageE.Source);
        }

        private void SetMainImage(Image img) => mainImage.Source = img.Source;

        private void ImageA_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image img = (Image)sender;
            SetMainImage(img);

            //ResetImagesSources();
            ImageA.Source = imagesSourceList[3];//D
            ImageB.Source = imagesSourceList[4];//E
            ImageC.Source = imagesSourceList[0];//A
            ImageD.Source = imagesSourceList[1];//B
            ImageE.Source = imagesSourceList[2];//C

            imagesSourceList[0] = imagesSourceList[3];//D
            imagesSourceList[1] = imagesSourceList[4];//E
            imagesSourceList[2] = imagesSourceList[0];//A
            imagesSourceList[3] = imagesSourceList[1];//B
            imagesSourceList[4] = imagesSourceList[2];//C

        }
        private void ImageB_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image img = (Image)sender;
            SetMainImage(img);

            //ResetImagesSources();

            ImageA.Source = imagesSourceList[4];//E
            ImageB.Source = imagesSourceList[0];//A
            ImageC.Source = imagesSourceList[1];//B
            ImageD.Source = imagesSourceList[2];//C
            ImageE.Source = imagesSourceList[3];//D

            imagesSourceList[0] = imagesSourceList[4];//E
            imagesSourceList[1] = imagesSourceList[0];//A
            imagesSourceList[2] = imagesSourceList[1];//B
            imagesSourceList[3] = imagesSourceList[2];//C
            imagesSourceList[4] = imagesSourceList[3];//D
        }

        private void ImageC_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image img = (Image)sender;
            SetMainImage(img);

            //ResetImagesSources();
            //ImageA.Source = imagesDictionary["ImageA"];
            //ImageB.Source = imagesDictionary["ImageB"];
            //ImageC.Source = imagesDictionary["ImageC"];
            //ImageD.Source = imagesDictionary["ImageD"];
            //ImageE.Source = imagesDictionary["ImageE"];
        }

        private void ImageD_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image img = (Image)sender;
            SetMainImage(img);

            //ResetImagesSources();

            //ImageA.Source = imagesList[1].Source;
            //ImageB.Source = imagesList[2].Source;
            //ImageC.Source = imagesList[3].Source;
            //ImageD.Source = imagesList[4].Source;
            //ImageE.Source = imagesList[0].Source;
        }

        private void ImageE_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image img = (Image)sender;
            SetMainImage(img);

            //ResetImagesSources();

            //ImageA.Source = imagesList[2].Source;
            //ImageB.Source = imagesList[3].Source;
            //ImageC.Source = imagesList[4].Source;
            //ImageD.Source = imagesList[0].Source;
            //ImageE.Source = imagesList[1].Source;
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

/*    0 A sm
    * 1 B gf
    * 2 C cl
    * 3 D gv
    * 4 E ls
    * 
    * 0 D gv
    * 1 E
    * 2 A
    * 3 B
    * 4 C
    * 
    */

//List<Foo> list = new List<Foo> { 1, 2, 3 };
//var query = list.Select((val, index) => list[index].val += 6);
//Console.WriteLine(string.Join(",", query));

//indexesDifference = Math.Abs(centralIndex - selectedImageIndex);
//imagesDictionary.Remove(centralIndex);
//imagesDictionary.Add(centralIndex, image0);
//imageSender.Source = imagesDictionary.Values.ToList().IndexOf()

//fooDictionary.Values.ToList().IndexOf(someValue);
//Values.ToList() converts your dictionary values into a List of someValue objects.
//IndexOf(someValue) searches your new List looking for the someValue object in question and returns the Index which would match the index of the Key / Value pair in the dictionary.
//This method does not care about the dictionary keys, it simply returns the index of the value that you are looking for
