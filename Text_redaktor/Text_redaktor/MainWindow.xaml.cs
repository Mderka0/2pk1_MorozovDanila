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

namespace Text_redaktor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filename = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bold_but(object sender, RoutedEventArgs e)
        {
            Boolean bold = false;
            if (bold == false)
            {
                txt.FontWeight = FontWeights.Bold;
                bold = true;
            }
            else
            {
                txt.FontWeight = FontWeights.Normal;
                bold = false;
            }
        }
        
        private void italic_but(object sender, RoutedEventArgs e)
        {
            Boolean italic = false;
            if (italic == false)
            {
                txt.FontStyle = FontStyles.Italic;
                italic = true;
            }
            else
            {
                txt.FontStyle = FontStyles.Normal;
                italic = false;
            }
        }

        private void underline_but(object sender, RoutedEventArgs e)
        {
            Boolean underline = false;
            if (underline == false)
            {
                txt.TextDecorations = TextDecorations.Underline;
                underline = true;
            }
            else
            {
                txt.TextDecorations = TextDecorations.Baseline;
                underline = false;
            }
        }

        private void newFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
            {
                filename = createFileWindow.FileName;
                filesLB.Items.Add(filename);

                CreateFile(filename);
            }

        }

        private void CreateFile(string name)
        {
            
        }


    }
}
