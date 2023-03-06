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
        // Property declaration
        public bool IsPictureHovered
        {
            // Bind this property to the dependency
            get => (bool)GetValue(isPictureHoveredProperty);
            set => SetValue(isPictureHoveredProperty, value);
        }

        // Dependency declaration
        public static readonly DependencyProperty isPictureHoveredProperty =
            DependencyProperty.Register("IsPictureHovered", typeof(bool), typeof(MainWindow)); // typeof(MainWindow): who is the owner, where the property has been declared


        public Image mainImage;
        public Image image0;
        public Image image1;


        public MainWindow()
        {
            InitializeComponent();
            mainImage = (Image)FindName("Main_image");
            image1 = (Image)FindName("Image1");
            image0 = (Image)FindName("Image0");
        }

        private static void OnPictureHovered(
            DependencyObject dObj,
            DependencyPropertyChangedEventArgs dp)
        {
            MainWindow mainWindow1 = dObj as MainWindow;
            mainWindow1.OnPictureHovered(dp);
        }

        private void OnPictureHovered(DependencyPropertyChangedEventArgs dp)
        {
            Console.WriteLine("Picture Hovered: " + dp.NewValue);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button currentButton = (Button)sender;
            Console.WriteLine("button name: " + currentButton.Name);



            // if(btn1) img1 source
            var newSource = image1.Source;
            mainImage.Source = newSource; 
        }

        public string GetSource(string btnName)
        {
            var newSource = (Button)FindName(btnName);
            return null;

        }

        private void Image0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Image 0 clicked");
            mainImage.Source = image0.Source;

        }
    }
}
