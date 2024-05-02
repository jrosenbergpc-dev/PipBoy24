namespace Pip_Boy_24;

public partial class NavButton : ContentView
{
	private bool bSelected = false;
	public NavButton()
	{
		InitializeComponent();
	}

	public event EventHandler<bool> NavButtonSelected;

	public bool IsSelected
	{
		get
		{
			return bSelected;
		}
		set
		{
			bSelected = value;

            Sel1.IsVisible = bSelected;
            Sel2.IsVisible = bSelected;
            Sel3.IsVisible = bSelected;
            Sel4.IsVisible = bSelected;

            this.InvalidateMeasure();
        }
	}

	public String Text
	{
		get
		{
			return NavLabel.Text;

        }
		set
		{
			NavLabel.Text = value;

        }
	}

	private void OnLabelClicked(object sender, EventArgs e)
	{
        IsSelected = !IsSelected;

        NavButtonSelected.Invoke(this, IsSelected);
    }
}