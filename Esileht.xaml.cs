using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Infokiosk
{

    public sealed partial class Esileht : Page
    {
        public Esileht()
        {
            this.InitializeComponent();
        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(sookla));
        }

        private void GridViewItem_Tapped_1(object sender, TappedRoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(Bussiajad));
        }

        private void GridViewItem_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Kontaktid));
        }

        private void GridViewItem_Tapped_4(object sender, TappedRoutedEventArgs e)
        {


            this.Frame.Navigate(typeof(Tunniplaan));

        }

        private void GridViewItem_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ruumid));
        }
    }
}
