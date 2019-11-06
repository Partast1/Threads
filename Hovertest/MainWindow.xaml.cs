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

namespace Hovertest
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TextboxHover_Enter(object sender, EventArgs e)
        {

            TextboxHover.Background = new SolidColorBrush(FromRgbExample());
            Hoverpage.
        }
        private Color FromRgbExample()
        {
            // Create a green color using the FromRgb static method.
            Color myRgbColor = new Color();
            myRgbColor = Color.FromRgb(0, 255, 0);
            return myRgbColor;
        }
    }
}
