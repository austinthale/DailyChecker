using DailyChecker.Models;
using DailyChecker.Views.DetailViews;
using DailyChecker.Views.DetailViews.SettingsViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DailyChecker.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listview; } }
        public List<MasterMenuItem> items;

        public MasterPage()
        {
            InitializeComponent();
            SetItems();
        }

        void SetItems()
        {
            items = new List<MasterMenuItem>();
            items.Add(new MasterMenuItem("InfoScreen1", "testIcon.png", Color.White, typeof(InfoScreen1)));
            items.Add(new MasterMenuItem("InfoScreen2", "testIcon.png", Color.White, typeof(InfoScreen2)));
            items.Add(new MasterMenuItem("Settings", "testIcon.png", Color.White, typeof(SettingsScreen)));
            ListView.ItemsSource = items;
        }
    }
}