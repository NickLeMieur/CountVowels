using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

namespace CountVowels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int total;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loadMain_Loaded(object sender, RoutedEventArgs e)
        {
            total = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            total = 0;
            String test = userInput.Text;

            if (test == null)
            {

            }
            else
            {

                for (int i = 0; i < test.Length; i++)
                {
                    Char compare = test[i];
                    if (compare == 'a' || compare == 'e' || compare == 'i' || compare == 'o' || compare == 'u')
                    {
                        total++;
                    }
                    else if (compare == 'A' || compare == 'E' || compare == 'I' || compare == 'O' || compare == 'U')
                    {
                        total++;
                    }


                }
                txtTotal.Text = Convert.ToString(total);
            }

        }

        private void userInput_TextChanged(object sender, TextChangedEventArgs e)
        { 

            txtTotal.Text = Convert.ToString("");

        }

       
    }
}
