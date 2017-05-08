using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.Utilities
{
    class UpdateTest
    {
        public void Initialize()
        {
            UpdateLoop.Instance.dispatcherTimer.Tick += new EventHandler(Loop);
        }

        private void Loop(object sender, EventArgs e)
        {
            Console.WriteLine("HI");
        }
    }
}
