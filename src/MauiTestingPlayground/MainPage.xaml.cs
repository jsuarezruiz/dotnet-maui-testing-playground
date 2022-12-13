using System;

namespace MauiTestingPlayground;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void OnActivityIndicatorButtonClicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Tests.ActivityIndicatorTest());
    }

    void OnButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Tests.ButtonTest());
    }
}