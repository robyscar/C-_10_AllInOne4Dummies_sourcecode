using System;
using System.Windows.Forms;
using System.Threading;

namespace SimpleProgress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare the delegate. This one is void.
        delegate void UpdateProgressCallback();

        //DoSomethingLengthy -- My workhorse method takes a delegate.
        private void DoSomethingLengthy(UpdateProgressCallback updateProgress)
        {
            // Set the duration of the updates (4 seconds), number of updates
            // and the duration of eacn update interval.
            int duration = 4000;
            int intervals = 10;
            int updateInterval = duration / intervals;

            for (int i = 0; i <= intervals; i++)
            {
                // Do something time consuming.
                Thread.Sleep(updateInterval);

                // Update the progress bar.
                updateProgress();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateProgressCallback callback =
                new UpdateProgressCallback(this.DoUpdate);

            // Do something that needs periodic progress reports. This
            // passes a delegate instance that knows how to update the bar.
            DoSomethingLengthy(callback);

            // Clear the bar so that it can be used again.
            progressBar1.Value = 0;
        }

        private void DoUpdate()
        {
            // Tells progress bar to update itself
            progressBar1.PerformStep();
        }
    }
}
