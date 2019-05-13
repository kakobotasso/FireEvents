using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FireEvents
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnButton01Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("Button 01 clicked");
        }

        async void OnButton02Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("Button 02 clicked");
        }

        async void OnButton03Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("Button 03 clicked");
        }
    }


}
