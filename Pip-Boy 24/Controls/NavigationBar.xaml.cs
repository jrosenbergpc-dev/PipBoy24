namespace Pip_Boy_24;

public partial class NavigationBar : ContentView
{
	public NavigationBar()
	{
		InitializeComponent();
	}

    private void NavSelected(object sender, bool e)
    {
		Nav1.IsSelected = false;
        Nav2.IsSelected = false;
        Nav3.IsSelected = false;
        Nav4.IsSelected = false;
        Nav5.IsSelected = false;

        if (sender is NavButton)
        {
            (sender as NavButton).IsSelected = e;

            Item1Border.IsVisible = true;
            Item2Border.IsVisible = true;
            Item3Border.IsVisible = true;
            Item4Border.IsVisible = true;
            Item5Border.IsVisible = true;

            if (sender.Equals(Nav1))
            {
                Item1Border.IsVisible = !e;
            }
            else if (sender.Equals(Nav2))
            {
                Item2Border.IsVisible = !e;
            }
            else if (sender.Equals(Nav3))
            {
                Item3Border.IsVisible = !e;
            }
            else if (sender.Equals(Nav4))
            {
                Item4Border.IsVisible = !e;
            }
            else if (sender.Equals(Nav5))
            {
                Item5Border.IsVisible = !e;
            }
        }
    }
}