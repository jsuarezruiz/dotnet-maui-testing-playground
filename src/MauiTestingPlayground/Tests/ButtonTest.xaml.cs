using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui;

namespace MauiTestingPlayground.Tests;

public partial class ButtonTest : ContentPage
{
	public ButtonTest()
	{
		InitializeComponent();

        BindingContext = new ButtonViewModel();
    }

    void OnChangeBorderColorBtnClicked(object sender, System.EventArgs e)
    {
        Random rnd = new Random();
        Color borderColor = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);

        B2Button.BorderColor = borderColor;
    }

    void OnChangeTextColorBtnClicked(object sender, System.EventArgs e)
    {
        Random rnd = new Random();
        Color borderColor = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);

        B18Button.TextColor = borderColor;
    }

    void OnButtonClicked(object sender, System.EventArgs e)
    {
        DisplayAlert("Button", "Clicked", "OK");
    }

    void OnButtonPressed(object sender, System.EventArgs e)
    {
        DisplayAlert("Button", "Pressed", "OK");
    }

    void OnButtonReleased(object sender, System.EventArgs e)
    {
        DisplayAlert("Button", "Released", "OK");
    }

    void OnChangeIsVisibleBtnClicked(object sender, System.EventArgs e)
    {
        B24Button.IsVisible = !B24Button.IsVisible;
    }

    void OnChangeBackgroundBtnClicked(object sender, System.EventArgs e)
    {
        Random rnd = new Random();
        Color startColor = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);
        Color endColor = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);

        B28Button.Background = new LinearGradientBrush
        {
            EndPoint = new Point(1, 0),
            GradientStops = new GradientStopCollection
            {
                new GradientStop { Color = startColor },
                new GradientStop { Color = endColor }
            }
        };
    }

    void OnTapGestureRecognizerTapped(object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        DisplayAlert("Button", "Tapped", "OK");
    }
}

public class ButtonViewModel : INotifyPropertyChanged
{
    double number = 1;

    public event PropertyChangedEventHandler PropertyChanged;

    public ButtonViewModel()
    {
        MultiplyBy2Command = new Command(() => Number *= 2);

        DivideBy2Command = new Command(() => Number /= 2);
    }

    public double Number
    {
        set
        {
            if (number != value)
            {
                number = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Number"));
            }
        }
        get
        {
            return number;
        }
    }

    public ICommand MultiplyBy2Command { private set; get; }

    public ICommand DivideBy2Command { private set; get; }
}
