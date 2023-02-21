using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.Core;
using stride_ui_alternate_example.Views;

namespace stride_ui_alternate_example
{
    public class RandomizeHealthbar : SyncScript
    {

        private Random _random;
        private MainView _mainView;

        public override void Start()
        {
			_random = new Random();
            Game.Services.ServiceAdded += ServicesChanged;
        }

        private void ServicesChanged(object sender, ServiceEventArgs e)
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
}
