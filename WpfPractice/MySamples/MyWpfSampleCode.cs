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
}