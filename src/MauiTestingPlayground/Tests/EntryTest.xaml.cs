using System.ComponentModel;
using System.Windows.Input;

namespace MauiTestingPlayground.Tests;

public partial class EntryTest : ContentPage
{
	public EntryTest()
	{
		InitializeComponent();

        BindingContext = new EntryViewModel();
    }

    void OnClearTextButtonClicked(object sender, EventArgs e)
    {
        En2.Text = string.Empty;
    }

    void OnUpdateTextButtonClicked(object sender, EventArgs e)
    {
        En3.Text += " more text -";
    }

    void OnClearPlaceholderButtonClicked(object sender, EventArgs e)
    {
        En8.Placeholder = string.Empty;
    }

    void OnUpdatePlaceholderButtonClicked(object sender, EventArgs e)
    {
        En9.Text += " more text -";
    }

    void OnUpdateCursorPositionButtonClicked(object sender, EventArgs e)
    {
        En16.CursorPosition++;
    }

    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        DisplayAlert("Entry", $"{e.NewTextValue}", "OK");
    }

    void OnEntryCompleted(object sender, EventArgs e)
    {
        DisplayAlert("Entry", "Completed", "OK");
    }

    void OnChangeIsVisibleBtnClicked(object sender, System.EventArgs e)
    {
        En34.IsVisible = !En34.IsVisible;
    }

    void OnChangeBackgroundBtnClicked(object sender, System.EventArgs e)
    {
        Random rnd = new Random();
        Color startColor = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);
        Color endColor = Color.FromRgba(rnd.Next(256), rnd.Next(256), rnd.Next(256), 255);

        En38.Background = new LinearGradientBrush
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
        DisplayAlert("Entry", "Tapped", "OK");
    }
}

public class EntryViewModel : INotifyPropertyChanged
{
    double number = 1;

    public event PropertyChangedEventHandler PropertyChanged;

    public EntryViewModel()
    {
        ReturnCommand = new Command(() => Number++);
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

    public ICommand ReturnCommand { private set; get; }
}
