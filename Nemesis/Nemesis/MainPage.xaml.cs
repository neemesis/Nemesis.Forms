﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nemesis {
    public partial class MainPage {
        public MainPage() {
            InitializeComponent();

            nsbTest.ItemsSource = new ObservableCollection<string> { "str1", "str2" };
        }
    }
}
