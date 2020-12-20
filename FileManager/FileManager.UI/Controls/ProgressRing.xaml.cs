using System;
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
    /// Interaction logic for ProgressRing.xaml
    /// </summary>
    public partial class ProgressRing : UserControl
    {
        public ProgressRing()
        {
            InitializeComponent();
        }

        public double ArcThickness
        {
            get { return (double)GetValue(ArcThicknessProperty); }
            set { SetValue(ArcThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArcThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArcThicknessProperty =
            DependencyProperty.Register("ArcThickness", typeof(double), typeof(ProgressRing), new PropertyMetadata(2.0));


        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(ProgressRing), new PropertyMetadata(0.0));


        public Brush ProgressTrackBrush
        {
            get { return (Brush)GetValue(ProgressTrackBrushProperty); }
            set { SetValue(ProgressTrackBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProgressTrackBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressTrackBrushProperty =
            DependencyProperty.Register("ProgressTrackBrush", typeof(Brush), typeof(ProgressRing));


        public Brush ProgressBrush
        {
            get { return (Brush)GetValue(ProgressBrushProperty); }
            set { SetValue(ProgressBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProgressBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProgressBrushProperty =
            DependencyProperty.Register("ProgressBrush", typeof(Brush), typeof(ProgressRing));



    }
}
