using System;
using System.Windows.Forms;
using System.Threading;

namespace SimpleProgress2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare the delegate. This one is void.
        delegate void UpdateProgressCallback();

        // DoSomethingLengthy in anonymous form requires no input.
        private void DoSomethingLengthy()
        {
            // Set the duration of the updates (4 seconds), number of updates
            // and the duration of eacn update interval.
            int duration = 4000;
            int intervals = 10;
            int updateInterval = duration / intervals;

            // Create delegate instance.
            UpdateProgressCallback anon = delegate ()
            {
                // Method ‘pointed’ to
                progressBar1.PerformStep();            
            };

            for (int i = 0; i <= intervals; i++)
            {
                // Do something time consuming.
                Thread.Sleep(updateInterval);

                // Invoke the delegate.
                if (anon != null) anon();                 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Do something that needs periodic progress reports. This
            // passes a delegate instance that knows how to update the bar.
            DoSomethingLengthy();

            // Clear the bar so that it can be used again.
            progressBar1.Value = 0;
        }
    }
}
