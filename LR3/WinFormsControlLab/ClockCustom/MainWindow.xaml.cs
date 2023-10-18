using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;


namespace ClockCustom
{
    public partial class MainWindow : Window
    {
        const double angleSecMin = 6;
        const double angleHour = 30;

        public MainWindow()
        {
            InitializeComponent();
            StartClock();
        }

        void StartClock()
        {
            this.Hide();
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var rotateSec = new RotateTransform();
            var rotateMin = new RotateTransform();
            var rotateHour = new RotateTransform();

            int sec = DateTime.Now.Second;
            int min = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;

            rotateSec.Angle = angleSecMin * sec;
            SecondArrow.RenderTransform = rotateSec;

            rotateMin.Angle = (min * angleSecMin) + (rotateSec.Angle / 60.0);
            MinuteArrow.RenderTransform = rotateMin;

            rotateHour.Angle = (hour - 12) * angleHour + rotateMin.Angle / 12;
            HourArrow.RenderTransform = rotateHour;

            this.Show();
        }        

    }
}
