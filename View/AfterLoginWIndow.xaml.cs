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
using System.Windows.Shapes;

namespace NOTE_ID.View
{
    /// <summary>
    /// Interaction logic for AfterLoginWIndow.xaml
    /// </summary>
    public partial class AfterLoginWindow : Window
    {
        public AfterLoginWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new QuickNote());
        }
    }
}
