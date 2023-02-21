using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI;

namespace stride_ui_alternate_example.Views;
public class MainView : Panel
{

	public HorizontalProgressBar HealthBar;

	public MainView() 
	{
		var crosshair = new Label();
		crosshair.Text = ".";
		crosshair.HorizontalAlignment = HorizontalAlignment.Center;
		crosshair.VerticalAlignment = VerticalAlignment.Center;

		HealthBar = new HorizontalProgressBar();
		HealthBar.HorizontalAlignment = HorizontalAlignment.Left;
		HealthBar.VerticalAlignment = VerticalAlignment.Bottom;
		HealthBar.Value = 50;
		HealthBar.Filler = new SolidBrush("#4BD961FF");
		HealthBar.Left = 20;
		HealthBar.Top = -20;
		HealthBar.Width = 300;
		HealthBar.Height = 50;
		HealthBar.Background = new SolidBrush("#202020FF");
		HealthBar.Id = "Health Bar";

		Widgets.Add(crosshair);
		Widgets.Add(HealthBar);

	}
}
