namespace MauiTestingPlayground.Tests;

public partial class BoxViewTest : ContentPage
{
	public BoxViewTest()
	{
		InitializeComponent();
	}

    void OnUpdateColorButtonClicked(object sender, EventArgs e)
    {
        Random rnd = new Random();
        Color borderColor = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);

        Box3.Color = borderColor;
    }

    void OnChangeIsVisibleBtnClicked(object sender, EventArgs e)
    {
        Box12.IsVisible = !Box12.IsVisible;
    }

    void OnChangeBackgroundBtnClicked(object sender, EventArgs e)
    {
        Random rnd = new Random();
        Color startColor = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);
        Color endColor = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);

        Box13.Background = new LinearGradientBrush
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
        DisplayAlert("BoxView", "Tapped", "OK");
    }
}