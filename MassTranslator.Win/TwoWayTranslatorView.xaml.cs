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

namespace MassTranslator.Win
{
    /// <summary>
    /// Interaction logic for TwoWayTranslatorView.xaml
    /// </summary>
    public partial class TwoWayTranslatorView : UserControl
    {
        public TwoWayTranslatorView()
        {
            InitializeComponent();
            var model = new TranslatorModel();
            var viewModel = new TwoWayTranslatorViewModel(model);
            this.DataContext = viewModel;
        }
    }
}