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

        private Image image1;
        private Image image2;
        private Image image3;
        private Image image4;
        private Image image5;

        private int imgIndex;
        private int imgCount;
        private int centralIndex = 2;

        private List<Image> imagesList = new List<Image>();
        private List<ImageSource> imagesSourcesList = new List<ImageSource>();
        private List<ImageSource> tempSources = new List<ImageSource>();

        public MainWindow()
        {
            InitializeComponent();
            SetImages();
            SetStartingMainImage(image3);
        }

        private void SetImages()
        {
            mainImage = (Image)FindName("Main_image");
            image1 = (Image)FindName("Image1");
            image2 = (Image)FindName("Image2");
            image3 = (Image)FindName("Image3");
            image4 = (Image)FindName("Image4");
            image5 = (Image)FindName("Image5");

            imagesList.Add(image1);
            imagesList.Add(image2);
            imagesList.Add(image3);
            imagesList.Add(image4);
            imagesList.Add(image5);

            imagesSourcesList.Add(image1.Source);
            imagesSourcesList.Add(image2.Source);
            imagesSourcesList.Add(image3.Source);
            imagesSourcesList.Add(image4.Source);
            imagesSourcesList.Add(image5.Source);

            tempSources.Add(image1.Source);
            tempSources.Add(image2.Source);
            tempSources.Add(image3.Source);
            tempSources.Add(image4.Source);
            tempSources.Add(image5.Source);
        }

        private void SetStartingMainImage(Image img) => mainImage.Source = img.Source;

        private void SetMainImage(object sender)
        {
            Image img = (Image)sender;
            mainImage.Source = img.Source;
        }

        private void SetCarrouselImages(int senderIndex)
        {
            if (senderIndex == 0)
            {
                //0
                imagesList[0].Source = imagesSourcesList[senderIndex + 3];//3
                tempSources[0] = imagesSourcesList[senderIndex + 3];

                imagesList[1].Source = imagesSourcesList[senderIndex + 4];//4
                tempSources[1] = imagesSourcesList[senderIndex + 4];

                imagesList[2].Source = imagesSourcesList[senderIndex];//0
                tempSources[2] = imagesSourcesList[senderIndex];

                imagesList[3].Source = imagesSourcesList[senderIndex + 1];//1
                tempSources[3] = imagesSourcesList[senderIndex + 1];

                imagesList[4].Source = imagesSourcesList[senderIndex + 2];//2
                tempSources[4] = imagesSourcesList[senderIndex + 2];
            }
            else if (senderIndex == 1)
            {
                //1
                imagesList[0].Source = imagesSourcesList[senderIndex + 3];//4
                tempSources[0] = imagesSourcesList[senderIndex + 3];

                imagesList[1].Source = imagesSourcesList[senderIndex - 1];//0
                tempSources[1] = imagesSourcesList[senderIndex - 1];

                imagesList[2].Source = imagesSourcesList[senderIndex];//1
                tempSources[2] = imagesSourcesList[senderIndex];

                imagesList[3].Source = imagesSourcesList[senderIndex + 1];//2
                tempSources[3] = imagesSourcesList[senderIndex + 1];

                imagesList[4].Source = imagesSourcesList[senderIndex + 2];//3
                tempSources[4] = imagesSourcesList[senderIndex + 2];
            }
            else if (senderIndex == 2)
            {
                //2
                imagesList[0].Source = imagesSourcesList[senderIndex - 2];//0
                tempSources[0] = imagesSourcesList[senderIndex - 2];

                imagesList[1].Source = imagesSourcesList[senderIndex - 1];//1
                tempSources[1] = imagesSourcesList[senderIndex - 1];

                imagesList[2].Source = imagesSourcesList[senderIndex];//2
                tempSources[2] = imagesSourcesList[senderIndex];

                imagesList[3].Source = imagesSourcesList[senderIndex + 1];//3
                tempSources[3] = imagesSourcesList[senderIndex + 1];

                imagesList[4].Source = imagesSourcesList[senderIndex + 2];//4
                tempSources[4] = imagesSourcesList[senderIndex + 2];
            }
            else if (senderIndex == 3)
            {
                //3
                imagesList[0].Source = imagesSourcesList[senderIndex - 2];//1
                tempSources[0] = imagesSourcesList[senderIndex - 2];

                imagesList[1].Source = imagesSourcesList[senderIndex - 1];//2
                tempSources[1] = imagesSourcesList[senderIndex - 1];

                imagesList[2].Source = imagesSourcesList[senderIndex];//3
                tempSources[2] = imagesSourcesList[senderIndex];

                imagesList[3].Source = imagesSourcesList[senderIndex + 1];//4
                tempSources[3] = imagesSourcesList[senderIndex + 1];

                imagesList[4].Source = imagesSourcesList[senderIndex - 3];//0
                tempSources[4] = imagesSourcesList[senderIndex - 3];
            }
            else if (senderIndex == 4)
            {
                //4
                imagesList[0].Source = imagesSourcesList[senderIndex - 2];//2
                tempSources[0] = imagesSourcesList[senderIndex - 2];

                imagesList[1].Source = imagesSourcesList[senderIndex - 1];//3
                tempSources[1] = imagesSourcesList[senderIndex - 1];

                imagesList[2].Source = imagesSourcesList[senderIndex];//4
                tempSources[2] = imagesSourcesList[senderIndex];

                imagesList[3].Source = imagesSourcesList[senderIndex - 4];//0
                tempSources[3] = imagesSourcesList[senderIndex - 4];

                imagesList[4].Source = imagesSourcesList[senderIndex - 3];//1
                tempSources[4] = imagesSourcesList[senderIndex - 3];
            }

            SetMainImage(imagesList[2]);

            for (int i = 0; i < imagesSourcesList.Count; i++)
            {
                imagesSourcesList[i] = tempSources[i];
            }
        }

        private void Image1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image imageSent = (Image)sender;
            int senderIndex = imagesList.IndexOf(imageSent);

            // Reset temp images list
            for (int i = 0; i < tempSources.Count; i++) tempSources[i] = null;

            SetCarrouselImages(senderIndex);
        }

        private void Image2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image imageSent = (Image)sender;
            int senderIndex = imagesList.IndexOf(imageSent);

            // Reset temp images list
            for (int i = 0; i < tempSources.Count; i++) tempSources[i] = null;

            SetCarrouselImages(senderIndex);


        }



        private void Image3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image imageSent = (Image)sender;
            int senderIndex = imagesList.IndexOf(imageSent);

            // Reset temp images list
            for (int i = 0; i < tempSources.Count; i++) tempSources[i] = null;

            SetCarrouselImages(senderIndex);


        }

        private void Image4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image imageSent = (Image)sender;
            int senderIndex = imagesList.IndexOf(imageSent);

            // Reset temp images list
            for (int i = 0; i < tempSources.Count; i++) tempSources[i] = null;

            SetCarrouselImages(senderIndex);


        }

        private void Image5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image imageSent = (Image)sender;
            int senderIndex = imagesList.IndexOf(imageSent);

            // Reset temp images list
            for (int i = 0; i < tempSources.Count; i++) tempSources[i] = null;

            SetCarrouselImages(senderIndex);
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            // Go back
            // imgIndex --;
            // if(i<1) i = 6;
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            // imgIndex ++;
            // if(i>1) i = 1;
        }
    }
}


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
