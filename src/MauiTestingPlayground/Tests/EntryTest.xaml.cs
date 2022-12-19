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
        En8.Text = string.Empty;
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
