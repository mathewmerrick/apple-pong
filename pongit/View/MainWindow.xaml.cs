﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using pongit.ViewModel;


namespace pongit.View {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private GameViewModel VM;
        
        public MainWindow() {
            InitializeComponent();
            VM = new GameViewModel();
            this.DataContext = VM;
        }

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e) {
            VM.input(sender, e);
        }
    }
}
