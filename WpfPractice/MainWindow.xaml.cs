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

        public MainWindow()
        {
            InitializeComponent();
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

        //private static void OnPictureHovered(
        //    DependencyObject dObj,
        //    DependencyPropertyChangedEventArgs dp)
        //{
        //    MainWindow mainWindow1 = dObj as MainWindow;
        //    mainWindow1.OnPictureHovered(dp);
        //}

        //private void OnPictureHovered(DependencyPropertyChangedEventArgs dp)
        //{
        //    Console.WriteLine("Picture Hovered: " + dp.NewValue);
        //}

        private void OnClick5(object sender, RoutedEventArgs e)
        {
            //btn6.FontSize = 25;
            //btn6.Content = "This is my favorite photo.";
            //btn6.Background = Brushes.IndianRed;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            //Button btn = (Button)sender;
            //Image img = (Image)btn.FindResource("Image");
            //var a = sender;

            //var newImageSourcePath = @"C:\Users\HernandoNJ\Pictures\Landscapes\Lago-Moraine.jpg";
            //Image img = (Image)sender; // Invalid cast
            Main_image.Stretch = Stretch.UniformToFill;
            //Main_image.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(newImageSourcePath);
            // Image1.Source = (ImageSource)new ImageSourceConverter().ConvertFrom("Image2.gif");
        }

        private void Button1_MouseEnter(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse enter called");
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Button 1 clicked");

            Uri newImageUri = new Uri(@"C:\Users\HernandoNJ\Pictures\Landscapes\Lago-Moraine.jpg");
            Main_image.Source = new BitmapImage(newImageUri);
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Left button clicked");
        }
    }
}
