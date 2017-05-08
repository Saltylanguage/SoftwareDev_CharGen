using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace PathfinderCharGen.Utilities
{
    public class UpdateLoop
    {
        private UpdateLoop() { }

        private static UpdateLoop TheInstance;
        public static UpdateLoop Instance
        {
            get
            {
                if (TheInstance == null)
                {
                    TheInstance = new UpdateLoop();
                }

                return TheInstance;
            }
        }

        public DispatcherTimer dispatcherTimer;

        public void Initialize()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();
        }
    }
}
