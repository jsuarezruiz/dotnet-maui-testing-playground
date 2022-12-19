namespace MauiTestingPlayground.Tests;

public partial class EntryTest : ContentPage
{
	public EntryTest()
	{
		InitializeComponent();
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

    private void OnUpdateCursorPositionButtonClicked(object sender, EventArgs e)
    {
        En16.CursorPosition++;
    }
}