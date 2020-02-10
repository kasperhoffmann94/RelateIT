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

namespace RelateITApp.UWP
{
    public sealed partial class MainPage
    {
        private readonly string authenticationKey =
            "NRHTK2peNSMBw6gcSJuW~qIBw5QKFs0sWR72xtTgzJg~AoG283d-lMr4E3BZ_SVS382RhY22uHUjrpnAFQdiNPaduxrTXhSNeMEOQeieuePa";
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new RelateITApp.App());
            Xamarin.FormsMaps.Init(authenticationKey);
            Windows.Services.Maps.MapService.ServiceToken = authenticationKey;
        }
    }
}
