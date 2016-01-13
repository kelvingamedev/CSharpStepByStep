using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Delegates
{
    public partial class ClockWindow : Window
    {
        private Controller controller = new Controller();
        private LocalClock localClock = null;
        private EuropeanClock londonClock = null;
        private AmericanClock newYorkClock = null;
        private JapaneseClock tokyoClock = null;

        public ClockWindow()
        {
            InitializeComponent();
            localClock = new LocalClock();
            londonClock = new EuropeanClock(londonTimeDisplay);
            newYorkClock = new AmericanClock(newYorkTimeDisplay);
            tokyoClock = new JapaneseClock(tokyoTimeDisplay);

            controller.StartClocks += localClock.StartLocalClock;
            controller.StartClocks += londonClock.StartEuropeanClock;
            controller.StartClocks += newYorkClock.StartAmericanClock;
            controller.StartClocks += tokyoClock.StartJapaneseClock;

            controller.StopClocks += localClock.StopLocalClock;
            controller.StopClocks += londonClock.StopEuropeanClock;
            controller.StopClocks += newYorkClock.StopAmericanClock;
            controller.StopClocks += tokyoClock.StopJapaneseClock;
            
        }

        private void displayLocalTime(string time)
        {
            localTimeDisplay.Text = time;
        }

        private void startClick(object sender, RoutedEventArgs e)
        {
            controller.StartClocks();
            localClock.LocalClockTick += displayLocalTime;
            stop.IsEnabled = true;
            start.IsEnabled = false;
        }

        private void stopClick(object sender, RoutedEventArgs e)
        {
            controller.StopClocks();
            stop.IsEnabled = false;
            start.IsEnabled = true;
        }
    }
}
