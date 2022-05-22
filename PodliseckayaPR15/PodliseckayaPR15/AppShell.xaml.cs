using PodliseckayaPR15.ViewModels;
using PodliseckayaPR15.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PodliseckayaPR15
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
