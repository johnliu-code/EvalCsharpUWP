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
    public sealed partial class PageExo3 : Page
    {
        private int total;
        private int don;
        List<Don> dons = new List<Don>();
        int position = 0;

        public PageExo3()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            don = int.Parse(tboxDon.Text);
            total += don;

            if (tboxDonateur.Text != null && don != 0)
            {
                Don d = new Don(tboxDonateur.Text.ToString(), don);

                dons.Add(d);
                position = dons.Count -1;
            }

            tboxDonTotal.Text = total.ToString();
        }

        private void btnParcourir_Click(object sender, RoutedEventArgs e)
        {
            if (dons.Count != 0)
            {
                if (position == dons.Count - 1)
                    position = 0;
                else position++;

                tboxDonateur.Text = dons[position].Donateur().ToString();
                tboxDon.Text = dons[position].Montant().ToString();

                tboxDonTotal.Text = total.ToString();
            }
        }
    }
}
