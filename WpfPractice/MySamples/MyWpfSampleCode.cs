using System;

public class Class1
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
        DependencyProperty.Register("IsPictureHovered", typeof(bool), typeof(MainWindow)); // typeof(MainWindow): who is the owner, where the property has been declared}

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

    private void ButtonClickSample(object sender, RoutedEventArgs e)
    {
        Button currentButton = (Button)sender;
        Console.WriteLine("button name: " + currentButton.Name);
    }

    //private void SortImagesList()
    //{
    //    var imagesKeys = imagesDictionary.Keys.ToList();

    //    for (int i = 0; i < imagesKeys.Count; i++) // Pivot number
    //    {
    //        for (int j = 0; j < (imagesKeys.Count - i - 1); j++) // Number to compare with Pivot number
    //        {
    //            // If true, interchange items with an aux variable
    //            if (imagesKeys[j] > imagesKeys[j + 1])
    //            {
    //                int aux = imagesKeys[j]; // Keep the Pivot number
    //                imagesKeys[j] = imagesKeys[j + 1]; // assign the following number to imagesKeys[j]
    //                imagesKeys[j + 1] = aux; // assign j (aux) to [j+1]

    //            }
    //        }
    //    }
    //}
}