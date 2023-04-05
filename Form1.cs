using System.Diagnostics;
using System.Timers;

namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer countdownTimer;
        private long? remainingSecondsLong;

        public Form1()
        {
            InitializeComponent();

            countdownTimer = new System.Timers.Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Elapsed += new ElapsedEventHandler(CountdownTimer_Tick);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            remainingSecondsLong = null;
            lblCountdown.Text = "00:00:00";
            countdownTimer.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // When you click on Link Label
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/guneyarslan",
                UseShellExecute = true
            });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minutes;
            if (int.TryParse(txtMinutes.Text, out minutes))
            {
                if (minutes == 0)
                {
                    MessageBox.Show("You made an incorrect entry.");
                }
                else
                {
                    long seconds = minutes * 60L;
                    ShutdownComputer(seconds);
                }
            }
            else
            {
                MessageBox.Show("You made an incorrect entry.");
            }
        }

        private void ShutdownComputer(long seconds)
        {
            Process.Start("shutdown", $"/s /t {seconds}");

            remainingSecondsLong = seconds;
            countdownTimer.Start();

            this.Invoke(new Action(() =>
            {
                shutdownInfoLabel.Text = "Your computer will shut down in " + (seconds / 60).ToString() + " minutes."
                 + Environment.NewLine + "You can close this window."
                 + Environment.NewLine + "If you want to cancel the process later,"
                 + Environment.NewLine + "you can open the application and press"
                 + Environment.NewLine + "the 'Stop Timer' button.";

            }));
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSecondsLong.HasValue)
            {
                remainingSecondsLong--;

                if (remainingSecondsLong >= 0)
                {
                    TimeSpan remainingTimeSpan = TimeSpan.FromSeconds(remainingSecondsLong.Value);

                    // Access the control with the Invoke method
                    lblCountdown.Invoke(new Action(() =>
                    {
                        lblCountdown.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", remainingTimeSpan.Hours, remainingTimeSpan.Minutes, remainingTimeSpan.Seconds);
                    }));
                }
                else
                {
                    countdownTimer.Stop();
                    MessageBox.Show("Time is up! Your computer is shutting down now.");
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/a");
            countdownTimer.Stop();
            this.Invoke(new Action(() =>
            {
                shutdownInfoLabel.Text = "The process of shutting down"
                + Environment.NewLine + "the computer has been terminated."
                + Environment.NewLine + "If you want to be sure open 'cmd'"
                + Environment.NewLine + "and write 'shutdown /a' :)";
            }));
        }
        private void infobutton_MouseHover(object sender, EventArgs e)
        {
            string line = " Hello, thank you very much for using the application." +
                "\n I hope it works for you. First of all, I have to say that I made the application for myself." +
                "\n Since it is not a commercial application, so everything may not be working perfectly. \n\n" +
                "This app does nothing but open cmd and type shutdown and set a time. \n" +
                "I already share all the open source codes of the application on my github page.\n" +
                "You can review as much as you want. You can even use codes and add more features.\n" +
                "Please don't forget to give a star to the source code on the github page.\n\n" +
                "I do not intend to bring any updates to the application and develop it further.";

            toolTip1.Show(line, infobutton, 5000);

        }
        private void infobutton_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(infobutton);
        }

        private void infobutton_Click(object sender, EventArgs e)
        {

        }
    }
}
