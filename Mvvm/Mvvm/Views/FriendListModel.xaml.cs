﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendListModel : ContentView
    {
        public FriendListModel()
        {
            InitializeComponent();
        }
    }
}