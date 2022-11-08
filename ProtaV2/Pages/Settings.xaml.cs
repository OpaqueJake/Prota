﻿using ProtaV2.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProtaV2 {
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page {
        public Settings() {
            InitializeComponent();
        }

        private void FontSizes_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e) {

            Window resetWindow = new Attention();
            
            resetWindow.ShowDialog();
        }

    }
}
