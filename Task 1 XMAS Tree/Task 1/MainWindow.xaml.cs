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

namespace Task_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void GenerateButtonClicked(object sender, RoutedEventArgs e)
        {
            outputTextBox.Text = "";

            outputTextBox.Text += "\n";

            outputTextBox.Text += HeaderInputTextBox.Text;

            outputTextBox.Text += "\n\n";

            int rows = int.Parse(rowsTextBox.Text);

            GenerateTree(rows);

            outputTextBox.Text += "\n";

            outputTextBox.Text += FooterInputTextBox.Text;

            outputTextBox.Text += "\n\n";
        }
        private int GenerateTree(int a)
        {
            int space = a - 1;

            for (int i = 1; i < space; i++)
            {
                outputTextBox.Text += " ";
                if (i + 1 == space)
                {
                    outputTextBox.Text += "*\n";
                }
            }

            int midspace = 1;
           
            space--;

            for(int sp = space; sp > 1; sp--)
            {
                
                for(int i = 1; i < sp; i++)
                {
                    outputTextBox.Text += " ";
                    if (i + 1 == sp)
                    {
                        outputTextBox.Text += "*";
                        
                    }
                }

                for (int j = midspace; j > 0; j--)
                {
                    
                    outputTextBox.Text += " ";
                    
                    
                    if (j == 1)
                    {
                        outputTextBox.Text += "*\n";
                        
                    }
                }

                midspace += 2;


            }

            midspace += 2;

            for(int i = midspace; i > 0; i--)
            {
               
                 outputTextBox.Text += "*";

            }

            outputTextBox.Text += "\n";

            space++;

            for (int i = 1; i < space; i++)
            {
                outputTextBox.Text += " ";
                if (i + 1 == space)
                {
                    outputTextBox.Text += "*\n";
                }
            }

            return 0;
        }
    }
}
