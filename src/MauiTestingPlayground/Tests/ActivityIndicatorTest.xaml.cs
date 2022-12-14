using Microsoft.Maui;

namespace MauiTestingPlayground.Tests;

public partial class ActivityIndicatorTest : ContentPage
{
	public ActivityIndicatorTest()
	{
		InitializeComponent();
	}

    void OnChangeColorBtnClicked(object sender, EventArgs e)
    {
        Random rnd = new Random();
        Color color = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);

        AI2ActivityIndicator.Color = color;
    }

    void OnChangeIsRunningBtnClicked(object sender, EventArgs e)
    {
        AI5ActivityIndicator.IsRunning = !AI5ActivityIndicator.IsRunning;
    }

    void OnChangeIsVisibleBtnClicked(object sender, EventArgs e)
    {
        AI7ActivityIndicator.IsVisible = !AI7ActivityIndicator.IsVisible;
    }

    void OnChangeBackgroundBtnClicked(object sender, EventArgs e)
    {
        Random rnd = new Random();
        Color startColor = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);
        Color endColor = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);

        AI11ActivityIndicator.Background = new LinearGradientBrush
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
        DisplayAlert("ActivityIndicator", "Tapped", "OK");
    }
}
