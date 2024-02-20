using Microsoft.Maui.Controls.Shapes;

namespace phone;

public partial class MainPage : ContentPage
{
	int count = 0;
	double widht;
	double height;
	string or;
    double batt;

	public MainPage()
	{
		InitializeComponent();
        DeviceDisplay.Current.MainDisplayInfoChanged += UpdateInfo;
	}

    private void UpdateInfo(object sender, DisplayInfoChangedEventArgs e)
    {
        widht = DeviceDisplay.Current.MainDisplayInfo.Width;
        height = DeviceDisplay.Current.MainDisplayInfo.Height;
        or = DeviceDisplay.Current.MainDisplayInfo.Orientation.ToString();
        batt = Battery.Default.ChargeLevel * 100;
        Lbl.Text = $"Display:{widht}x{height}";
        OriLbl.Text = $"Orientation:{or} ";
        BattLbl.Text = $"Battery:{batt}%;{Battery.Default.PowerSource}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        widht = DeviceDisplay.Current.MainDisplayInfo.Width;
        height = DeviceDisplay.Current.MainDisplayInfo.Height;
        or = DeviceDisplay.Current.MainDisplayInfo.Orientation.ToString();
        batt = Battery.Default.ChargeLevel * 100;


        Lbl.Text = $"Display:{widht}x{height}";
        OriLbl.Text = $"Orientation:{or} ";

        BattLbl.Text = $"Battery:{batt}%;{Battery.Default.PowerSource}";
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

        int x = (int)e.GetPosition(rect).Value.X;
        int y = (int)e.GetPosition(rect).Value.Y;
        posX.Text = x.ToString();
        posY.Text = y.ToString();

        Rectangle r = new Rectangle();
        r.Fill = Colors.Red;
        r.WidthRequest = 10;
        r.HeightRequest = 10;
        abs.Add(r);
        abs.SetLayoutBounds(r,new Rect(x,y,0,0));
     
    }

    private void clr_Clicked(object sender, EventArgs e)
    {
        abs.Children.Clear();
    }
}

