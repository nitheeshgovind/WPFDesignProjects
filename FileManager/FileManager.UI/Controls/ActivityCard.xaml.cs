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

namespace FileManager.UI.Controls
{
    /// <summary>
    /// Interaction logic for ActivityCard.xaml
    /// </summary>
    public partial class ActivityCard : UserControl
    {
        public ActivityCard()
        {
            InitializeComponent();
        }

        public string TimeText { get; set; }

        public bool IsVideo { get; set; }

        public ImageSource Image1 { get; set; }

        public ImageSource Image2 { get; set; }

        public ImageSource Image3 { get; set; }

        public ImageSource TypeImage { get; set; }

        public string TypeName { get; set; }

        public string SourceName { get; set; }

        public int ItemCount { get; set; }
    }
}
