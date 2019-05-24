using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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





namespace Comma
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

        //BrowseFile() uses OpenFileDialog to open a text.

        static string BrowseFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                DefaultExt = ".txt",
                Multiselect = false,
                Filter = "txt files (*.txt)|*.txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
            };

            bool? result = fileDialog.ShowDialog();
            //result == true
            if (result == true)
            {

                return fileDialog.FileName;



            }
            else
            {
                return "Ingen fil valgt!";
            }
        }

          void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
         
            //Creates a new StreamReader which change the encoding.
            using (var reader = new StreamReader(
                    new FileStream(BrowseFile(), FileMode.Open), Encoding.GetEncoding("iso-8859-1")))
            {
                while (!reader.EndOfStream)
                {
                    
                    string line = reader.ReadLine();
                    string textFile = line;
                    string textcontent = Trimming(textFile);
                    Content.Text = textcontent;
                }

            }


        }
        //Method Trimming recieves a 'string'.. removes capital letters and .,


        //private void Content_TextChanged(object sender, EventArgs e)
        //{

        //    Regex regex = new Regex(@",\.");
        //    MatchCollection matches = regex.Matches(Content.Text);

        //}

        //private void Content_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //    Regex regex = new Regex(@",\.");
        //    MatchCollection matches = regex.Matches(Content.Text);

        //}

    }
}
