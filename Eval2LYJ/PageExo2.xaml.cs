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

namespace Eval2LYJ
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageExo2 : Page
    {
        private int total;
        private int don;
        public PageExo2()
        {
            this.InitializeComponent();
        }


        private void selectDon1_Checked(object sender, RoutedEventArgs e)
        {
            don = 10;
            tboxDon.Text = "10";
        }

        private void selectDon2_Checked(object sender, RoutedEventArgs e)
        {
            don = 20;
            tboxDon.Text = "20";
        }

        private void selectDon3_Checked(object sender, RoutedEventArgs e)
        {
            don = 30;
            tboxDon.Text = "30";
        }


        private void tboxDon_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.Parse(tboxDon.Text) == 10)
                selectDon1.IsChecked = true;
            else if (int.Parse(tboxDon.Text) == 20)
                selectDon2.IsChecked = true;
            else if (int.Parse(tboxDon.Text) == 30)
                selectDon3.IsChecked = true;
            else 
            {
                selectDon1.IsChecked = selectDon2.IsChecked = selectDon3.IsChecked = false;
                don = int.Parse(tboxDon.Text);
            }
                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            total += don;
            tboxDonTotal.Text = total.ToString();
        }


        private void txbDon_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }


    }
}
