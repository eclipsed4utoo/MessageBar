using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace DataArtist
{
    public partial class MessageBar : UserControl
    {
        private bool _show;
        private DispatcherTimer Timer { get; set;}
        
        public MessageBar()
        {
            InitializeComponent();
        }

        public string Text
        {
            get
            {
                return MessageText.Text;
            }
            set
            {
                MessageText.Text = value;
            }
        }

        public bool Show
        {
            get
            {
                return _show;
            }
            set
            {
                StopTimer();
                GotoBarState(value);
                _show = value;
            }
        }

        public void TimeShow(int seconds)
        {
            InitTimer(seconds);
            _show = true;
            GotoBarState(_show);
            Timer.Start();
        }

        private void GotoBarState(bool showBar)
        {
            VisualStateManager.GoToState(this, ((showBar) ? "ShowBar" : "HideBar"), true);
        }

        private void InitTimer(int seconds)
        {
            StopTimer();

            Timer = new DispatcherTimer
                        {
                            Interval = TimeSpan.FromSeconds(seconds)
                        };

            Timer.Tick += (s, e) =>
                        {
                            StopTimer();
                            Show = false;
                        };
        }

        private void StopTimer()
        {
            if (Timer != null && Timer.IsEnabled == true)
            {
                Timer.Stop();
            }
        }
    }
}
