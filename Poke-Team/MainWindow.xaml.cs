using PokeTeamLibrary;
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

    public partial class MainWindow : Window
    {
        /*private int maxId = 0;
        private int currentId = 0;*/

        public MainWindow()
        {
            InitializeComponent();

            /*ApiHelper.InitializeClient();*/
        }

        private void topMenuBar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MaximizeRestore();
        }

        private void topMenuBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void chromeCloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void chromeMinBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void chromeMaxRestBtn_Click(object sender, RoutedEventArgs e)
        {
            MaximizeRestore();
        }

        private void MaximizeRestore()
        {
            if (WindowState == WindowState.Maximized)
            {
                chromeMaxRestBtn.Content = "\uE922";
                WindowState = WindowState.Normal;
            }
            else
            {
                chromeMaxRestBtn.Content = "\uE923";
                WindowState = WindowState.Maximized;
            }
        }

        /*private async Task LoadSprite(int spriteId = 0)
        {
            var pokemon = await PokemonProcessor.LoadPokemon(spriteId);

            if (spriteId == 0)
            {
                maxId = pokemon.Id;
            }

            currentId = pokemon.Id;

            var uriSource = new Uri(pokemon.Sprites, UriKind.Absolute);

            pokemonSprite.Source = new BitmapImage(uriSource);
        }

        private async void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            await LoadSprite();
        }*/
    }
}

