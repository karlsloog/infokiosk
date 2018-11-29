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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Kontaktid : Page
    {
        public Kontaktid()
        {
            this.InitializeComponent();
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ListViewItem_Tapped_1(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ListViewItem_Tapped_2(object sender, TappedRoutedEventArgs e)
        {

        }

        private void Backbutton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Esileht));
        }
    }
}
