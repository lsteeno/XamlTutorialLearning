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

namespace XamlTutorialLearning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel viewModel;
        
        public MainWindow()
        {
            var emp = new Employee();
            emp.Name = "Lance Olsen";
            emp.Title = "Developer";

            viewModel = new MainWindowViewModel(emp);

            DataContext = viewModel;
            InitializeComponent();
        }
    }
}