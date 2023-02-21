using Stride.Core.Shaders.Ast;
using Stride.Engine;
using Stride.Input;
using stride_ui_alternate_example.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stride_ui_alternate_example;
public class HealthRandomizer : SyncScript
{

	private MainView _mainView;
	private Random _random;

	public override void Start()
	{
		base.Start();
		Game.Services.ServiceAdded += ServiceAdded;
		_random = new Random();
	}

	private void ServiceAdded(object sender, Stride.Core.ServiceEventArgs e)
	{
		if(e.ServiceType == typeof(MainView))
		{
			_mainView = Game.Services.GetService<MainView>();
		}
	}

	public override void Update()
	{
		if (Input.IsKeyDown(Keys.Space))
		{
			_mainView.HealthBar.Value = _random.Next(0, 100);
		}
	}
}
