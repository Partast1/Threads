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

namespace RGB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       //public BrushConverter bc();
        private void Sli_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            SolidColorBrush magicBrush = (SolidColorBrush)this.Resources["magicBrush"];

            if ((RedSlider != null) && (GreenSlider != null) && (BlueSlider != null))
            {
                magicBrush.Color = Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
            }
            string hexcolor = magicBrush.Color.ToString();
            Hex.Content = hexcolor;
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            //Copies the hex code from the label "Hex".
            Clipboard.SetText(Hex.Content.ToString());
            //Displays what Hex code have been copied.
            Copy.Content = Hex.Content + " " + "Copied to clipboard";
            

        }
    }
}
