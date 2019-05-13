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
        IEventTracker eventTracker;

        public MainPage()
        {
            InitializeComponent();
            eventTracker = DependencyService.Get<IEventTracker>();
        }

        async void OnButton01Clicked(object sender, System.EventArgs e)
        {
            eventTracker.SendEvent("Click01");
        }

        async void OnButton02Clicked(object sender, System.EventArgs e)
        {
            eventTracker.SendEvent("Click02", "Comment", "Hello Events");
        }

        async void OnButton03Clicked(object sender, System.EventArgs e)
        {
            var dictionary = new Dictionary<string, string>
            {
                {"Name", "John Xamarin"},
                {"Phone", "55 555 555 555"},
                {"Email", "johnxamarin@john.com"}
            };
            eventTracker.SendEvent("Click03", dictionary);
        }
    }


}
