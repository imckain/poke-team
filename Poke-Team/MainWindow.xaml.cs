using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Net.Http;

namespace Poke_Team
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /*public class HttpClient : System.Net.Http.HttpMessageInvoker
    {
        static readonly HttpClient client = new HttpClient();

        static async Task Main()
        {
            var uri = "https://pokeapi.co/api/v2/pokemon/";

            try
            {
                string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
            }
        }

    }*/



    public partial class MainWindow : Window
    {
        DispatcherTimer timer;

        double panelWidth;
        bool hidden;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 0, 0, 0) };
            timer.Tick += Timer_Tick;

            panelWidth = SidePanel.Width;

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                SidePanel.Width += 1;
                if (SidePanel.Width >= 160)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                SidePanel.Width -= 1;
                if (SidePanel.Width <= panelWidth)
                {
                    timer.Stop();
                    hidden = true;
                }
            }
        }

        private void Close_Button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PanelHeader_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void MinimizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
