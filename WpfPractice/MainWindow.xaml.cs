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
        private Image mainImage;
        private Image image0;
        private Image image1;
        private Image image2;
        private Image image3;
        private Image image4;

        private Dictionary<int, ImageSource> imagesDictionary = new Dictionary<int, ImageSource>();
        private List<Image> currentImagesList = new List<Image>();
        private List<Image> newImagesList = new List<Image>();

        private int centralIndex = 2;
        //private int centralIndex = 2;

        public MainWindow()
        {
            InitializeComponent();
            AddImagesToList();
            SetMainImage(imagesDictionary.Values.ElementAt(centralIndex));
        }

        private void AddImagesToList()
        {
            mainImage = (Image)FindName("Main_image");
            image0 = (Image)FindName("Image0");
            image1 = (Image)FindName("Image1");
            image2 = (Image)FindName("Image2");
            image3 = (Image)FindName("Image3");
            image4 = (Image)FindName("Image4");

            imagesDictionary.Add(0, image0.Source);
            imagesDictionary.Add(1, image1.Source);
            imagesDictionary.Add(2, image2.Source);
            imagesDictionary.Add(3, image3.Source);
            imagesDictionary.Add(4, image4.Source);


            //fooDictionary.Values.ToList().IndexOf(someValue);

            //Values.ToList() converts your dictionary values into a List of someValue objects.

            //IndexOf(someValue) searches your new List looking for the someValue object in question and returns the Index which would match the index of the Key / Value pair in the dictionary.

            //This method does not care about the dictionary keys, it simply returns the index of the value that you are looking for.
        }

        private void SetMainImage(ImageSource newSource) => mainImage.Source = newSource;

        //private void SortImages(int new)

        private void SortImagesList()
        {

        }

        private void ImageClicked(object sender, MouseButtonEventArgs e)
        {
            Image imageSender = (Image)sender;
            int selectedImageIndex;
            int indexesDifference;
            ImageSource selectedImageSource;

            switch (imageSender.Name)
            {
                case "Image0":
                    selectedImageIndex = imagesDictionary.Values.ToList().IndexOf(imageSender.Source);
                    selectedImageSource = imagesDictionary.Values.ElementAt(selectedImageIndex); 
                    SetNewMainImage(selectedImageIndex, selectedImageSource);

                    //indexesDifference = Math.Abs(centralIndex - selectedImageIndex);
                    //imagesDictionary.Remove(centralIndex);
                    //imagesDictionary.Add(centralIndex, image0);
                    //imageSender.Source = imagesDictionary.Values.ToList().IndexOf()

                    break;
                case "Image1":
                    selectedImageIndex = imagesDictionary.Values.ToList().IndexOf(imageSender.Source);
                    selectedImageSource = imagesDictionary.Values.ElementAt(selectedImageIndex);
                    SetNewMainImage(selectedImageIndex, selectedImageSource);
                    break;
                case "Image2":
                    selectedImageIndex = imagesDictionary.Values.ToList().IndexOf(imageSender.Source);
                    selectedImageSource = imagesDictionary.Values.ElementAt(selectedImageIndex);
                    SetNewMainImage(selectedImageIndex, selectedImageSource);
                    break;
                case "Image3":
                    selectedImageIndex = imagesDictionary.Values.ToList().IndexOf(imageSender.Source);
                    selectedImageSource = imagesDictionary.Values.ElementAt(selectedImageIndex);
                    SetNewMainImage(selectedImageIndex, selectedImageSource);
                    break;
                case "Image4":
                    selectedImageIndex = imagesDictionary.Values.ToList().IndexOf(imageSender.Source);
                    selectedImageSource = imagesDictionary.Values.ElementAt(selectedImageIndex);
                    SetNewMainImage(selectedImageIndex, selectedImageSource);
                    break;

                //    selectedImageIndex = imagesDictionary.Values.ToList().IndexOf(imageSender);
                //    indexesDifference = Math.Abs(centralIndex - selectedImageIndex);
                //    imagesDictionary.Remove(centralIndex);
                //    imagesDictionary.Add(centralIndex, image1);
                //    SetMainImage();
                //    break;
                //case "Image2":
                //    selectedImageIndex = imagesDictionary.Values.ToList().IndexOf(imageSender);
                //    indexesDifference = Math.Abs(centralIndex - selectedImageIndex);
                //    imagesDictionary.Remove(centralIndex);
                //    imagesDictionary.Add(centralIndex, image2);
                //    SetMainImage();
                //    break;
                //case "Image3":
                //    selectedImageIndex = imagesDictionary.Values.ToList().IndexOf(imageSender);
                //    indexesDifference = Math.Abs(centralIndex - selectedImageIndex);
                //    imagesDictionary.Remove(centralIndex);
                //    imagesDictionary.Add(centralIndex, image3);
                //    SetMainImage();
                //    break;
                //case "Image4":
                //    selectedImageIndex = imagesDictionary.Values.ToList().IndexOf(imageSender);
                //    indexesDifference = Math.Abs(centralIndex - selectedImageIndex);
                //    imagesDictionary.Remove(centralIndex);
                //    imagesDictionary.Add(centralIndex, image4);
                //    SetMainImage();
                //    break;
                default:
                    break;
            }
        }

        private void SetNewMainImage(int selectedImageIndex, ImageSource senderImageSource)
        {
            ImageSource newCurrentImageSource = imagesDictionary.Values.ElementAt(selectedImageIndex);

            image2.Source = senderImageSource;
            SetMainImage(newCurrentImageSource);
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
