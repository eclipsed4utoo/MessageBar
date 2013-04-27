using System.Windows;
using System.Windows.Controls;

namespace MessageBarDemo
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myMsgBar.Text = "Record has been deleted. (just kidding!!!)";
            myMsgBar.TimeShow(2);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            myMsgBar.Text = "Welcome to DataArtist MessageBar demo!";
            myMsgBar.TimeShow(5);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            myMsgBar.Text = "Showing some test data...";
            myMsgBar.Show = true;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            myMsgBar.Show = false;
        }
    }
}
