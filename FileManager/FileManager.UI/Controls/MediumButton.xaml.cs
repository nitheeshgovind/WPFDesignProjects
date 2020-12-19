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
    /// Interaction logic for MediumButton.xaml
    /// </summary>
    public partial class MediumButton : UserControl
    {
        public MediumButton()
        {
            InitializeComponent();
        }

        public string Header
        {
            get { return header.Text; }
            set
            {
                header.Text = value;
            }
        }

        public string SubText
        {
            get { return subText.Text; }
            set
            {
                subText.Text = value;
            }
        }

        public ImageSource ImageSource
        {
            get { return icon.Source; }
            set
            {
                icon.Source = value;
            }
        }

    }
}
